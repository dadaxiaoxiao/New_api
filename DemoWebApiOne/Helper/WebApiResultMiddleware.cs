using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using DemoWebApiOne.Entities;

namespace DemoWebApiOne.Helper
{
    public class WebApiResultMiddleware:ActionFilterAttribute
    {
        
        private readonly MultilingualLanguage _language;

        public WebApiResultMiddleware(MultilingualLanguage  language)
        {
            _language = language;
        }
        
        public override  void OnActionExecuting(ActionExecutingContext context)
        {
           //在Action执行之前由 MVC 框架调用。
            _language.Language = context.HttpContext.Request.Headers["Accept-Language"];
            _language.Language = string.IsNullOrEmpty(_language.Language) ?"zh-CN":_language.Language;
            base.OnActionExecuting(context);
        }

         public override void OnResultExecuting(ResultExecutingContext context)
         {
             //在执行Result之前由 MVC 框架调用。
            if (!context.ModelState.IsValid)
            {
                // 自定义生成返回格式
                context.Result = new ValidationFailedResult(context.ModelState,_language);// 把language传下去翻译
            }
            if (context.Result is ValidationFailedResult)
            {
                var objectResult = context.Result as ObjectResult;
                context.Result = objectResult;
            }
            else
            {
                var objectResult = context.Result as ObjectResult;
                 // OkObjectResult 方法生成返回格式
                context.Result = new OkObjectResult(new WebApiResultModel(code: 200, result: objectResult.Value));
            }

         }


    }
}