using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;

public interface IPageToolbarContributor
{
    Task ContributeAsync(PageToolbarContributionContext context);
}
