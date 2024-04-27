using MicrosoftAzure.EventGrid.API.Data.SimpleModels;

namespace MicrosoftAzure.EventGrid.API.Data.Core
{
    public interface IFeedProcessEventGridCore
    {
        Task  PushEvent(OrderDetailsSampleModel inputMessage);
        //Task<List<string>> PopEvent();
    }
}
