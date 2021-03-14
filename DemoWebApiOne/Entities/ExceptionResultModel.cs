using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApiOne.Entities
{
    public class ExceptionResultModel:WebApiResultModel
    {
         public ExceptionResultModel(int? code, Exception exception)
        {
            Code = code;
            Message = exception.InnerException != null ?
                exception.InnerException.Message :
                exception.Message;
            Result = null;
        }
    }

    public class ExceptionResult : ObjectResult
    {
        public ExceptionResult(int? code, Exception exception)
            : base(new ExceptionResultModel(code, exception))
        {
            StatusCode = code;
        }
    }


}