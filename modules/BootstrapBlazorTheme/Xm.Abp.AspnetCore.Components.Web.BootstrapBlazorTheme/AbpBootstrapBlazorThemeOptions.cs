﻿using Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Settings;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme;

public class AbpBootstrapBlazorThemeOptions
{
    public BootstrapBlazorThemes Theme { get; set; }
    public MenuPlacement MenuPlacement { get; set; }

    public AbpBootstrapBlazorThemeOptions()
    {
        Theme = BootstrapBlazorThemes.Default;
        MenuPlacement = MenuPlacement.Left;
    }
}
