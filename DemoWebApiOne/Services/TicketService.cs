using DemoWebApiOne.IServices;
using DemoWebApiOne.Entities;
using DemoWebApiOne.Helper;
using SqlSugar;

namespace DemoWebApiOne.Services
{
    public class TicketService:TicketIService
    {
        private readonly SqlSugarClient _db;
        public TicketService (SqlSugarHelp db) {
            _db = db.sqlSugar;
        }
        public TicketQueryRequest Query(TicketQueryRequest data)
        {
            if (data.plant == "1") {
                UserOperationException a = new UserOperationException ("正常报错");
                //throw new UserOperationException ("正常报错");
                throw a;
            }
            if(data.plant =="2")
            {
                int a =0;
                int b =1;
                int c= b/a;
            }
              // DbFirst
            // _db.DbFirst.IsCreateAttribute ().Where ("cimuser").CreateClassFile ("D:\\Code\\dotnetcode\\New_api\\DemoWebApiOne\\Entities\\Tables"); //缺什么加什么


            return data;
        }
    }
}