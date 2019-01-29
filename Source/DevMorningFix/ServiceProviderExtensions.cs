using System;

namespace Avtec.DevMorningFix
{
    public static class ServiceProviderExtensions
    {
        public static T GetService<T>(this IServiceProvider provider)
        {
            var serviceType = typeof(T);
            var service = provider.GetService(serviceType);
            return (T) service;
        }
    }
}