using SqlSugar;
using DemoWebApiOne.Entities;

namespace DemoWebApiOne.Helper
{
    public class SqlSugarHelp
    {
        public SqlSugarClient sqlSugar { get; set; }
        public SqlSugarHelp()
        {
            sqlSugar = new SqlSugarClient(
                new ConnectionConfig(){
                    // 读取 appsettings.json 的连接符
                    ConnectionString = ConfigExtensions.Configuration["DbConn:ConnectionString"],
                   // 使用的数据库方言
                   DbType = DbType.MySql,
                  IsAutoCloseConnection = true,
                  InitKeyType = InitKeyType.Attribute//从特性读取主键自增信息
                }
            );
         
             //添加Sql打印事件，开发中可以删掉这个代码
            sqlSugar.Aop.OnLogExecuting = (sql, pars) =>
            {
                NLogHelp.InfoLog(sql);
            };

         

        }


        



    }
}