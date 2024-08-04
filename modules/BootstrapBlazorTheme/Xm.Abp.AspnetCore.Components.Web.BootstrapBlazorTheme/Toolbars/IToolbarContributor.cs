using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

public interface IToolbarContributor
{
    Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
}
