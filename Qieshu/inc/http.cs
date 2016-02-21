using System;
using System.IO;
using System.Net;

namespace Qieshu.inc
{
    
    public class http
    {
        public static string get(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
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

        public static void download(string url, string filepath)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri(url);
                client.DownloadFileAsync(uri, filepath);
            }
            catch (Exception)
            {
                throw new Exception("（╯－＿－）╯╧╧");
            }
        }
    }
}
