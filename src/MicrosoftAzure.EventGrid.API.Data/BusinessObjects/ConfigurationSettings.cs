using Microsoft.Extensions.Configuration;

namespace MicrosoftAzure.EventGrid.API.Data.BusinessObject
{
    public class ConfigurationSettings : IConfigurationSettings
    {
        #region Global Variable(s)
        private readonly IConfiguration _configuration;
        #endregion

        public ConfigurationSettings(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(IConfiguration));
        }
        #region Public Prop(s)
        public string AzureEventGridTopicEndpoint => _configuration["AzureEventGrid:TopicEndpoint"];
        public string AzureEventGridTopicKey => _configuration["AzureEventGrid:TopicKey"];
        public string AzureEventGridTopicName => _configuration["AzureEventGrid:TopicName"];
        public string AzureEventGridSubscription => _configuration["AzureEventGrid:Subscription"];

        #endregion

    }
}
