using System;
using System.Net;
using System.IO;

namespace Qieshu.inc
{
    
    public class http
    {
        public static string get(string url)
        {
            try
            {
                WebRequest request;
                request = WebRequest.Create(url);
                request.Proxy = WebRequest.DefaultWebProxy;
                Stream response = request.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(response);
                string responseText = reader.ReadToEnd();
                return responseText;
            }catch(Exception)
            {
                throw new Exception("（╯－＿－）╯╧╧");
            }
        }
    }
}
