using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperBox
{
    class Command
    {
        public const string URL_TO_CN = "http://translate.google.cn/translate_a/single?client=gtx&dt=t&dj=1&ie=UTF-8&sl=auto&tl=zh_CN&q=";
        public const string URL_TO_EN = "http://translate.google.cn/translate_a/single?client=gtx&dt=t&dj=1&ie=UTF-8&sl=auto&tl=en&q=";
        public static HttpClient httpClient = new HttpClient();

        public static string GITHUB_URL = "https://github.com/ayvytr/DeveloperBox";
        public static string ISSUES_URL = "https://github.com/Ayvytr/DeveloperBox/issues";
        public static string MAIL_URL = "mailto:ayvytr@163.com?subject=Bug-Report&body={}";

        static Command()
        {
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            httpClient.DefaultRequestHeaders.Add("charset", "utf-8");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36");
        }

        public enum Type
        {
            TRANSLATE_TO_CN,
            TRANSLATE_TO_EN,
            JSON_FORMAT,
            URL_ENCODE,
            URL_DECODE
        }

        public static async Task<string> translateToChinese(String str)
        {
            var body = await httpClient.GetStringAsync(URL_TO_CN + str);
            return body;
        }

        public static async Task<string> translateToEnglish(String str)
        {
            var text = System.Web.HttpUtility.UrlEncode(str);
            var body = await httpClient.GetStringAsync(URL_TO_EN + text);
            return body;
        }

        public static string jsonFormat(string str)
        {
            try
            {
                //格式化json字符串
                JsonSerializer serializer = new JsonSerializer();
                TextReader tr = new StringReader(str);
                JsonTextReader jtr = new JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 2,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
                else
                {
                    return null;
                }
            } 
            catch
            {
                return null;
            }
        }

        public static Bitmap resizeImage(Image image, int newW, int newH)
        {
            try
            {
                Bitmap b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);

                // 插值算法的质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(image, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
                g.Dispose();

                return b;
            }
            catch
            {
                return null;
            }

        }
    }
}
