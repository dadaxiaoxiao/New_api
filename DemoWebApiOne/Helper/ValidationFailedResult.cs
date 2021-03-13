using DemoWebApiOne.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DemoWebApiOne.Helper
{
    public class ValidationFailedResult: ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState,MultilingualLanguage language): base(new ValidationFailedResultModel(modelState,language))
        {
            StatusCode = StatusCodes.Status422UnprocessableEntity;
        }
    }
}