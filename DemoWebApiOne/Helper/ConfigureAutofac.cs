using System.Reflection;
using Autofac;
using DemoWebApiOne.IServices;
using DemoWebApiOne.Services;

namespace DemoWebApiOne.Helper
{
    public class ConfigureAutofac:Autofac.Module
    {
         protected override void Load(ContainerBuilder containerBuilder)
        {
           
            #region
             // 1 单个类和接口
            // 左边的是实现类，右边的As是接口
            //containerBuilder.RegisterType<TestServiceE>().As<ITestServiceE>().SingleInstance();
            #endregion
            
            #region
             // 2  程序集注入
             //服务层接口程序集命名空间
            //Assembly iservice = Assembly.Load("Wistron.WM.IServices"); //需要添加项目进来,不然会加载不到它

            //服务层程序集命名空间
            //Assembly service = Assembly.Load("Wistron.WM.Services"); //需要添加项目进来,不然会加载不到它
            //containerBuilder.RegisterAssemblyTypes(service, iservice)
            //    .Where(t => t.Name.EndsWith("Service"))
            //    .AsImplementedInterfaces();
            #endregion

            #region
            // 3 Load 适用于无接口注入
            // var assemblysServices = Assembly.Load("MultilingualLanguage");
            // containerBuilder.RegisterAssemblyTypes(assemblysServices)
            //          .AsImplementedInterfaces()
            //          .InstancePerLifetimeScope();

            // var assemblysErrorMessage = Assembly.Load("ValidateErrorMessage");
            // containerBuilder.RegisterAssemblyTypes(assemblysErrorMessage)
            //          .AsImplementedInterfaces()
            //          .InstancePerLifetimeScope();       
          
            #endregion


            containerBuilder.RegisterType<TicketService>().As<TicketIService>().SingleInstance();
        }
    }
}