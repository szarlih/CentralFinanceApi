using EmailInvoiceExctractor;
using Microsoft.AspNetCore.Mvc;

namespace CentralFinanceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IActiveAccounts _scrapperService;

        public EmailController(IActiveAccounts scrapperService)
        {
            _scrapperService = scrapperService;
        }

        [HttpGet(Name = "GetEmailMessagesCount")]
        public int EmailMessages()
        {
            _scrapperService.TriggerImmediateCheck();
            return _scrapperService.GetProcessedEmailCount();
        }

        [HttpPatch(Name = "StartAccountsScrapping")]
        public void StartScrapping()
        {
            
        }
    }
}
