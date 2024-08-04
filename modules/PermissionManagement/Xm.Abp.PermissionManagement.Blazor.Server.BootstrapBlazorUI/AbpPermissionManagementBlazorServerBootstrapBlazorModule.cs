using Xm.Abp.AspnetCore.Components.Server.BootstrapBlazorTheme;
using Xm.Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Xm.Abp.PermissionManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule),
    typeof(AbpAspNetCoreComponentsServerBootstrapBlazorThemeModule)
)]
public class AbpPermissionManagementBlazorServerBootstrapBlazorModule : AbpModule
{
}
