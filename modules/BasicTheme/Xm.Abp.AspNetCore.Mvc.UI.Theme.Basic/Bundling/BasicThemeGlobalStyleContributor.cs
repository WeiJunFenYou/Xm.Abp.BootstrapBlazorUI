using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Xm.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling;

public class BasicThemeGlobalStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add("/themes/basic/layout.css");
        //context.Files.Add("/themes/basic/logHB.png");
    }
}
