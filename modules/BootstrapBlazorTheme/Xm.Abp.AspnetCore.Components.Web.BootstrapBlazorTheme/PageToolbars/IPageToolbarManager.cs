using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;

public interface IPageToolbarManager
{
    Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
}
