using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DemoWebApiOne.Entities
{
    // 验证失败结果模型
    public class ValidationFailedResultModel:WebApiResultModel
    {
        public ValidationFailedResultModel(ModelStateDictionary modelState,MultilingualLanguage language)
        {
            Code = 422;
            Message = "参数不合法";
            Result = modelState.Keys
            .SelectMany(key =>modelState[key].Errors.Select(x =>new ValidationError(key,language.GetErrorMessage(x.ErrorMessage,language.Language))))
            .ToList();
        }
    }
}