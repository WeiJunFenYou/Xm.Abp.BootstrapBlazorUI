using Xm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Xm.Abp.SettingManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Xm.Abp.SettingManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpSettingManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpSettingManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
