using MyProject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MyProject.Blazor;

public abstract class MyProjectComponentBase : AbpComponentBase
{
    protected MyProjectComponentBase()
    {
        LocalizationResource = typeof(MyProjectResource);
    }
}
