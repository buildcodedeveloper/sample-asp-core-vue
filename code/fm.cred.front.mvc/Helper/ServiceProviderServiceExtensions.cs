using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace fm.cred.front.mvc.Helper {
    public static class ServiceProviderServiceExtensions {
        public static object GetRequiredService<T> (this IServiceProvider provider, Type serviceType) {
            var requiredServiceSupportingProvider = provider as ISupportRequiredService;
            if (requiredServiceSupportingProvider != null) {
                return requiredServiceSupportingProvider.GetRequiredService (serviceType);
            }
            var services = provider.GetServices (typeof (T));
            var service = services.First (o => o.GetType () == serviceType);
            if (service == null) {
                throw new InvalidOperationException ("Not registered service!");
            }

            return service;
        }
    }
}