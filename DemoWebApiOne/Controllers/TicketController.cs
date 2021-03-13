using System.Net;
using DemoWebApiOne.IServices;
using Microsoft.AspNetCore.Mvc;
//Microsoft.AspNetCore.Mvc 命名空间提供可用于配置 Web API 控制器的行为和操作方法的属性。
namespace DemoWebApiOne.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TicketController: Controller
    {
        private readonly TicketIService _ticketIService;
        
         public TicketController(TicketIService ticketIService)
        {
            _ticketIService = ticketIService;
        }

        [HttpGet]
        public IActionResult Query(string data)
        {
            return Ok(_ticketIService.Query(data));
        }


    }
}