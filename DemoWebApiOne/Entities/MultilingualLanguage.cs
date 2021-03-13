using Microsoft.Extensions.Configuration;

namespace DemoWebApiOne.Entities
{
    public class MultilingualLanguage
    {
        public string Language{get;set;}
        public string   GetErrorMessage(string errorCode,string language)
        {
            string errorMessage = string.Empty;
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //添加 json 文件路径
            builder.AddJsonFile("Other/Translate.json");
            //创建配置根对象
            IConfigurationRoot root = builder.Build();
            // 取配置根下的 name（errorCode） 部分
            errorMessage = root.GetSection("1001")[language];
             return errorMessage;
        }
    }
}