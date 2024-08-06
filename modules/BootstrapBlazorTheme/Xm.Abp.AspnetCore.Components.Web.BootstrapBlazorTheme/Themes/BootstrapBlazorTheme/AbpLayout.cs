using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Themes.BootstrapBlazorTheme;

/// <summary>
/// 自定义布局
/// </summary>
public class AbpLayout : BootstrapBlazor.Components.Layout
{
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();


        //IsAuthenticated = true;
        //Todo 这里以后要改
    }
}