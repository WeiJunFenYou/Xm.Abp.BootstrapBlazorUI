﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Toolbars;

public class AbpToolbarOptions
{
    [NotNull]
    public List<IToolbarContributor> Contributors { get; }

    public AbpToolbarOptions()
    {
        Contributors = new List<IToolbarContributor>();
    }
}
