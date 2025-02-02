using EmailInvoiceExctractor;
using Microsoft.AspNetCore.Mvc;

namespace CentralFinanceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IEmailScrapper _scrapperService;

        public EmailController(IEmailScrapper scrapperService)
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
