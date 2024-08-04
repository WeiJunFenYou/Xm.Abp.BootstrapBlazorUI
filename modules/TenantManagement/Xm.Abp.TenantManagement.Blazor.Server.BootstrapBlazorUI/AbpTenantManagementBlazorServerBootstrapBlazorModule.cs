using Xm.Abp.FeatureManagement.Blazor.Server.BootstrapBlazorUI;
using Xm.Abp.TenantManagement.Blazor.BootstrapBlazorUI;
using Volo.Abp.Modularity;

namespace Xm.Abp.TenantManagement.Blazor.Server.BootstrapBlazorUI;

[DependsOn(
    typeof(AbpTenantManagementBlazorBootstrapBlazorModule),
    typeof(AbpFeatureManagementBlazorWebServerBootstrapBlazorModule)
)]
public class AbpTenantManagementBlazorServerBootstrapBlazorModule : AbpModule
{
    
}
