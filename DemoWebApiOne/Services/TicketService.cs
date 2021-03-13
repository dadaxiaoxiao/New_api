using DemoWebApiOne.IServices;
using DemoWebApiOne.Entities;

namespace DemoWebApiOne.Services
{
    public class TicketService:TicketIService
    {
        public TicketQueryRequest Query(TicketQueryRequest data)
        {
            // if(data.plant =="2")
            // {
            //     int a =0;
            //     int b =1;
            //     int c= b/a;
            // }
            
        
            return data;
        }
    }
}