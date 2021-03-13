using DemoWebApiOne.Entities;

namespace DemoWebApiOne.IServices
{
    public interface TicketIService
    {
         public TicketQueryRequest Query(TicketQueryRequest data);
         //定义接口
    }
}