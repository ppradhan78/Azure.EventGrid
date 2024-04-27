using MicrosoftAzure.EventGrid.API.Data.BusinessObject;
using MicrosoftAzure.EventGrid.API.Data.BusinessObjects;
using MicrosoftAzure.EventGrid.API.Data.Core;

namespace MicrosoftAzure.EventGrid.API.Extension
{
    public static class DependencyRegistrationExtension
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection Services)
        {

            Services.AddSingleton<IConfigurationSettings, ConfigurationSettings>();
            Services.AddTransient<IFeedProcessEventGridCore, FeedProcessEventGridCore>();
            Services.AddTransient<IFeedProcessEventGridBo, FeedProcessEventGridBo>();
            return Services;
        }
        public static IServiceCollection AddApiDependencies(this IServiceCollection Services)
        {
            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen();
            Services.AddControllers();
            Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            return Services;
        }
    }
}
