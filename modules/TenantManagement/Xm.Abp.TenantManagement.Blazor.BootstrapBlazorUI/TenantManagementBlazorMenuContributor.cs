﻿using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace Xm.Abp.TenantManagement.Blazor.BootstrapBlazorUI;

public class TenantManagementBlazorMenuContributor : IMenuContributor
{
    public virtual Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name != StandardMenus.Main)
        {
            return Task.CompletedTask;
        }

        var administrationMenu = context.Menu.GetAdministration();

        var l = context.GetLocalizer<AbpTenantManagementResource>();

        var tenantManagementMenuItem = new ApplicationMenuItem(
            TenantManagementMenuNames.GroupName,
            l["Menu:TenantManagement"],
            icon: "fa fa-users"
        );
        administrationMenu.AddItem(tenantManagementMenuItem);

        tenantManagementMenuItem.AddItem(new ApplicationMenuItem(
            TenantManagementMenuNames.Tenants,
            l["Tenants"],
            url: "~/tenant-management/tenants",
            icon: "fa fa-users"
        ).RequirePermissions(TenantManagementPermissions.Tenants.Default));

        return Task.CompletedTask;
    }
}
