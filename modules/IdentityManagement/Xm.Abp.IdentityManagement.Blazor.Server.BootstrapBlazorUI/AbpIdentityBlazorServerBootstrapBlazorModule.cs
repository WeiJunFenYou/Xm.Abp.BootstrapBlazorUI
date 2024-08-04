using Xm.Abp.IdentityManagement.Blazor.BootstrapBlazorUI;
using Xm.Abp.PermissionManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Xm.Abp.IdentityManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpIdentityBlazorBootstrapBlazorModule),
    typeof(AbpPermissionManagementBlazorBootstrapBlazorModule)
)]
public class AbpIdentityBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
