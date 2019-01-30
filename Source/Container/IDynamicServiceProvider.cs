using System;
using Microsoft.Extensions.DependencyInjection;

namespace Avtec.DevMorningFix.Container
{
    public interface IDynamicServiceProvider
    {
        IServiceProvider OurServiceProvider { get; }
        IServiceCollection ServicesCollection { get; set; }
    }
}