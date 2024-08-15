﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Xm.Abp.BootstrapBlazorUI;
using Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;
using Xm.Abp.FeatureManagement.Blazor.BootstrapBlazorUI.Components;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.EntityActions;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.TableColumns;
using Volo.Abp.FeatureManagement;
using Volo.Abp.ObjectExtending;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.Localization;
using BootstrapBlazor.Components;

namespace Xm.Abp.TenantManagement.Blazor.BootstrapBlazorUI.Pages;

public partial class TenantManagement
{
    protected const string FeatureProviderName = "T";

    protected bool HasManageFeaturesPermission;
    protected string ManageFeaturesPolicyName;

    protected FeatureManagementModal FeatureManagementModal;

    protected PageToolbar Toolbar { get; } = new();

    protected List<TableColumn> TenantManagementTableColumns => TableColumns.Get<TenantManagement>();

    public TenantManagement()
    {
        LocalizationResource = typeof(AbpTenantManagementResource);
        ObjectMapperContext = typeof(AbpTenantManagementBlazorBootstrapBlazorModule);

        CreatePolicyName = TenantManagementPermissions.Tenants.Create;
        UpdatePolicyName = TenantManagementPermissions.Tenants.Update;
        DeletePolicyName = TenantManagementPermissions.Tenants.Delete;

        ManageFeaturesPolicyName = TenantManagementPermissions.Tenants.ManageFeatures;
    }

    protected override ValueTask SetBreadcrumbItemsAsync()
    {
        BreadcrumbItems.Add(new AbpBreadcrumbItem(L["Menu:TenantManagement"]));
        BreadcrumbItems.Add(new AbpBreadcrumbItem(L["Tenants"]));

        return base.SetBreadcrumbItemsAsync();
    }

    protected override async Task SetPermissionsAsync()
    {
        await base.SetPermissionsAsync();

        HasManageFeaturesPermission = await AuthorizationService.IsGrantedAsync(ManageFeaturesPolicyName);
    }

    protected override string GetDeleteConfirmationMessage(TenantDto entity)
    {
        return string.Format(L["TenantDeletionConfirmationMessage"], entity.Name);
    }

    protected override ValueTask SetToolbarItemsAsync()
    {
        Toolbar.AddButton(L["ManageHostFeatures"],
            async () => await FeatureManagementModal.OpenAsync(FeatureProviderName),
            "fa fa-cog",
            requiredPolicyName: FeatureManagementPermissions.ManageHostFeatures);

        Toolbar.AddButton(L["NewTenant"],
            OpenCreateModalAsync,
            "fa fa-plus",
            requiredPolicyName: CreatePolicyName);

        return base.SetToolbarItemsAsync();
    }

    protected override ValueTask SetEntityActionsAsync()
    {
        EntityActions
            .Get<TenantManagement>()
            .AddRange(new EntityAction[]
            {
                new EntityAction
                {
                    Text = L["Edit"],
                    Icon = "fas fa-pen",
                    Visible = (data) => HasUpdatePermission,
                    Clicked = async (data) => { await OpenEditModalAsync(data.As<TenantDto>()); }
                },
                new EntityAction
                {
                    Text = L["Features"],
                    Icon = "fas fa-users-between-lines",
                    Visible = (data) => HasManageFeaturesPermission,
                    Clicked = async (data) =>
                    {
                        var tenant = data.As<TenantDto>();
                        await FeatureManagementModal.OpenAsync(FeatureProviderName, tenant.Id.ToString());
                    }
                },
                new EntityAction
                {
                    Text = L["Delete"],
                    Color = Color.Danger,
                    Icon = "fas fa-trash-can",
                    Visible = (data) => HasDeletePermission,
                    Clicked = async (data) => await DeleteEntityAsync(data.As<TenantDto>()),
                    ConfirmationMessage = (data) => GetDeleteConfirmationMessage(data.As<TenantDto>())
                }
            });

        return base.SetEntityActionsAsync();
    }

    protected override ValueTask SetTableColumnsAsync()
    {
        TenantManagementTableColumns
            .AddRange(new TableColumn[]
            {
                new TableColumn
                {
                    Title = L["TenantName"],
                    Data = nameof(TenantDto.Name),
                },
                new TableColumn
                {
                    Title = L["Actions"],
                    Actions = EntityActions.Get<TenantManagement>()
                },
            });

        TenantManagementTableColumns.AddRange(GetExtensionTableColumns(
            TenantManagementModuleExtensionConsts.ModuleName,
            TenantManagementModuleExtensionConsts.EntityNames.Tenant));

        return base.SetTableColumnsAsync();
    }
}
