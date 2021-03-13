using DemoWebApiOne.IServices;


namespace DemoWebApiOne.Services
{
    public class TicketService:TicketIService
    {
        public string Query(string data)
        {
            return "成功";
        }
    }
}