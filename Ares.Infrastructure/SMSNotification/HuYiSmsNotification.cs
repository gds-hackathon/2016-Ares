using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;
using Ares.Infrastructure.Logging;

namespace Ares.Infrastructure.SMSNotification
{
    public class HuYiSmsNotification : IMessageNotification
    {

        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];
        public static string Account = ConfigurationManager.AppSettings["HuYiAccount"];
        public static string APIKey = ConfigurationManager.AppSettings["HuYIAPIKey"];

        public void Send(string message)
        {
            try
            {
                string account = Account;
                string password = APIKey;//请登录用户中心->验证码、通知短信->帐户及签名设置->APIKEY
                string mobile = System.Web.HttpContext.Current.Request.QueryString["mobile"];
                
                string content = string.Format("您的验证码是：{0}。请不要把验证码泄露给其他人。", message);

                //Session["mobile"] = mobile;
                //Session["mobile_code"] = mobile_code;

                string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

                UTF8Encoding encoding = new UTF8Encoding();
                byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
                myRequest.Method = "POST";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentLength = postData.Length;

                Stream newStream = myRequest.GetRequestStream();
                // Send the data.
                newStream.Write(postData, 0, postData.Length);
                newStream.Flush();
                newStream.Close();

                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                if (myResponse.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        string res = reader.ReadToEnd();
                        int len1 = res.IndexOf("</code>");
                        int len2 = res.IndexOf("<code>");
                        string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                        //Response.Write(code);

                        int len3 = res.IndexOf("</msg>");
                        int len4 = res.IndexOf("<msg>");
                        string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                        System.Web.HttpContext.Current.Response.Write(msg);

                        System.Web.HttpContext.Current.Response.End();
                    }
                }
                else
                {
                    //访问失败
                    LoggingFactory.GetLogger().Log("访问验证码服务器失败");
                }
            }
            catch (Exception ex)
            {

                LoggingFactory.GetLogger().Error(ex.Message, ex);
            }
            
        }
    }
}
