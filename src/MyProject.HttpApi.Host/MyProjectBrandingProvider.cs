using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyProject;

[Dependency(ReplaceServices = true)]
public class MyProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyProject";
}
