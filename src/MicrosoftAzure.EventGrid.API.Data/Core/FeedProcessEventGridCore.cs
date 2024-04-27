using Microsoft.Extensions.Configuration;
using MicrosoftAzure.EventGrid.API.Data.BusinessObjects;
using MicrosoftAzure.EventGrid.API.Data.SimpleModels;

namespace MicrosoftAzure.EventGrid.API.Data.Core
{
    public class FeedProcessEventGridCore : IFeedProcessEventGridCore
    {
        private readonly IConfiguration _configuration;
        private readonly IFeedProcessEventGridBo _feedProcessEventGridBo;

        public FeedProcessEventGridCore(IConfiguration configuration, IFeedProcessEventGridBo feedProcessEventGridBo)
        {
            _configuration = configuration;
            _feedProcessEventGridBo = feedProcessEventGridBo;
        }

        public async Task PushEvent(OrderDetailsSampleModel inputMessage)
        {
           await _feedProcessEventGridBo.PushEvent(inputMessage);
        }
    }
}
