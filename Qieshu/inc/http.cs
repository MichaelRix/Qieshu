using System.Net;
using System.IO;

namespace Qieshu.inc
{
    
    public class http
    {
        public static string get(string url)
        {
            WebRequest request;
            request = WebRequest.Create(url);
            request.Proxy = WebRequest.DefaultWebProxy;
            Stream response = request.GetResponse().GetResponseStream();
            StreamReader read = new StreamReader(response);
            string responseText = read.ReadToEnd();
            return responseText;
        }
    }
}
