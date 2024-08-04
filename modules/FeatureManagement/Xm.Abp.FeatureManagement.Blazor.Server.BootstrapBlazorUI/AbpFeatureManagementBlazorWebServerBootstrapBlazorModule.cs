using Xm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Xm.Abp.FeatureManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Xm.Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpFeatureManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpFeatureManagementBlazorWebServerBootstrapBlazorModule : AbpModule
{
}
