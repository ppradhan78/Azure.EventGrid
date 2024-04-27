using Azure;
using Azure.Messaging.EventGrid;
using Microsoft.Extensions.Configuration;
using MicrosoftAzure.EventGrid.API.Data.BusinessObject;
using MicrosoftAzure.EventGrid.API.Data.Infrastructure;
using MicrosoftAzure.EventGrid.API.Data.SimpleModels;

namespace MicrosoftAzure.EventGrid.API.Data.BusinessObjects
{
    public class FeedProcessEventGridBo : IFeedProcessEventGridBo
    {
        private readonly IConfigurationSettings _configuration;
        public FeedProcessEventGridBo(IConfigurationSettings configuration)
        {
            _configuration = configuration;
        }

        public async Task PushEvent(OrderDetailsSampleModel inputMessage)
        {
            try
            {
                var eventGridClient = CreateEventGridPublisherClient();
                EventGridEvent egEvent = new EventGridEvent("Subject", "receive", "1.0", inputMessage);
                await eventGridClient.SendEventAsync(egEvent);
            }
            catch (Exception ex)
            {
            }
        }
        //public async Task<List<string>> PopEvent()
        //{
        //    var reciveMessage = new List<string>();
        //    try
        //    {
        //        string url = "https://feedprocessserverlessapi-topic.westus-1.eventgrid.azure.net";
        //        // Construct the client using an Endpoint for a namespace as well as the access key
        //        var client = new EventGridClient(new Uri(url),
        //                                         new AzureKeyCredential(CommonConstants.AzureEventGridTopicKey));

        //        // Receive the published CloudEvents
        //        ReceiveResult result = await client.ReceiveCloudEventsAsync(CommonConstants.AzureEventGridTopicName, CommonConstants.AzureEventGridSubscription, 3);

        //        var output = result.Value;
        //        foreach (var item in output)
        //        {

        //            reciveMessage.Add(item.Event.Data.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return reciveMessage;
        //}

        private EventGridPublisherClient CreateEventGridPublisherClient()
        {
           
            var eventGridClient = new EventGridPublisherClient(new Uri(_configuration.AzureEventGridTopicEndpoint), new AzureKeyCredential(_configuration.AzureEventGridTopicKey));
            return eventGridClient;
        }
    }
}
