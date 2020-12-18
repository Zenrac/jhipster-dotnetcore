using JhipsterSampleApplication.Configuration;
using JhipsterSampleApplication.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JhipsterSampleApplication.Configuration {
    public static class NhipsterSettingsConfiguration {
        public static IServiceCollection AddNhipsterModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JHipsterSettings>(configuration.GetSection("jhipster"));
            return services;
        }
    }
}
