using DemoWebApiOne.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoWebApiOne.Helper
{
    public class ExceptionAttribute : IExceptionFilter
    {
        // 异常处理
        public void OnException(ExceptionContext context)
        {
            string errorMessage = string.Empty;
            string developmentMessage = string.Empty;
            // 设置为true，表示异常已经被处理了
            context.ExceptionHandled = true;
            if (context.Exception.GetType() == typeof(UserOperationException))
            {
                errorMessage = context.Exception.Message;
                developmentMessage = context.Exception.StackTrace;
                context.Result = new ExceptionResult(200, context.Exception);
            } else
            {
                errorMessage = "未知错误";
                context.Result = new ExceptionResult(500, context.Exception);
              
            }

           
        }
        
    }
}