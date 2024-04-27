using Microsoft.AspNetCore.Mvc;
using MicrosoftAzure.EventGrid.API.Data.Core;
using MicrosoftAzure.EventGrid.API.Data.SimpleModels;

namespace MicrosoftAzure.EventGrid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedProcessEventGridApiController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IFeedProcessEventGridCore _feedProcessEventGridCore;
        public FeedProcessEventGridApiController(IConfiguration configuration, IFeedProcessEventGridCore feedProcessEventGridCore)
        {
            _feedProcessEventGridCore = feedProcessEventGridCore;
            _configuration = configuration;
        }
        
        [HttpPost]
        public void Post([FromBody] OrderDetailsSampleModel value)
        {
            _feedProcessEventGridCore.PushEvent(value);
        }
       
    }
}
