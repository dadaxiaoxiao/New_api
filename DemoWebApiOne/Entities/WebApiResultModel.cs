using Newtonsoft.Json;

namespace DemoWebApiOne.Entities
{
    public class WebApiResultModel
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
        public WebApiResultModel(int? code = null, string message = null,
            object result = null)
        {
            this.Code = code;
            this.Result = result;
            this.Message = message;
        }

           // 这个类是抓取
        public class ValidationError
        {
             // 对象转JSON为NULL 时候忽略
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string Field { get; }
            public string Message { get; }
            public ValidationError(string field, string message)
            {
                Field = field != string.Empty ? field : null;
                Message = message;
            }
        }

    }
}