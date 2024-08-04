using AutoMapper;
using Volo.Abp.TenantManagement;

namespace Xm.Abp.TenantManagement.Blazor.BootstrapBlazorUI;

public class AbpTenantManagementBlazorAutoMapperProfile : Profile
{
    public AbpTenantManagementBlazorAutoMapperProfile()
    {
        CreateMap<TenantDto, TenantUpdateDto>()
            .MapExtraProperties();
    }
}
