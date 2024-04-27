using MicrosoftAzure.EventGrid.API.Data.SimpleModels;

namespace MicrosoftAzure.EventGrid.API.Data.BusinessObjects
{
    public interface IFeedProcessEventGridBo
    {
        Task  PushEvent(OrderDetailsSampleModel inputMessage);
        //Task  PopEvent();
    }
}
