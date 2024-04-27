namespace MicrosoftAzure.EventGrid.API.Data.BusinessObject
{
    public interface IConfigurationSettings
    {
        string AzureEventGridTopicEndpoint { get; }
        string AzureEventGridTopicKey { get; }
        string AzureEventGridTopicName { get; }
        string AzureEventGridSubscription { get; }
        
            
    }
}
