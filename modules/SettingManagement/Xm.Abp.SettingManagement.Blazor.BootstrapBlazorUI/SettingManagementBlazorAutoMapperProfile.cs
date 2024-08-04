using AutoMapper;
using Volo.Abp.SettingManagement;

namespace Xm.Abp.SettingManagement.Blazor.BootstrapBlazorUI;

public class SettingManagementBlazorAutoMapperProfile : Profile
{
    public SettingManagementBlazorAutoMapperProfile()
    {
        CreateMap<EmailSettingsDto, UpdateEmailSettingsDto>();
    }
}
