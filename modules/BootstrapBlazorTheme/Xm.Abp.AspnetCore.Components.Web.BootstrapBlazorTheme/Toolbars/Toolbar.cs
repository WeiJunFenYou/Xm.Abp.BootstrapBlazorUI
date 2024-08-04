using System.Collections.Generic;
using JetBrains.Annotations;
using Volo.Abp;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

public class Toolbar
{
    public string Name { get; }

    public List<ToolbarItem> Items { get; }

    public Toolbar([NotNull] string name)
    {
        Name = Check.NotNull(name, nameof(name));
        Items = new List<ToolbarItem>();
    }
}
