﻿using Volo.Abp.AspNetCore.Components;
using Volo.Abp.FeatureManagement.Localization;

namespace Xm.Abp.FeatureManagement.Blazor.BootstrapBlazorUI;

public abstract class AbpFeatureManagementComponentBase : AbpComponentBase
{
    protected AbpFeatureManagementComponentBase()
    {
        LocalizationResource = typeof(AbpFeatureManagementResource);
    }
}
