﻿using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Settings;

public interface IBootstrapBlazorSettingsProvider
{
    Task<MenuPlacement> GetMenuPlacementAsync();
    Task<BootstrapBlazorThemes> GetThemeAsync();

    Task TriggerSettingChanged();
    
    public event BootstrapBlazorSettingsProvider.BootstrapBlazorSettingChangedHandler SettingChanged;
}
