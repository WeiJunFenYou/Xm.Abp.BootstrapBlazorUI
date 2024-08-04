using System.Threading.Tasks;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

public interface IToolbarManager
{
    Task<Toolbar> GetAsync(string name);
}
