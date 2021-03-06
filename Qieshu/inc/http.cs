﻿using System;
using System.IO;
using System.Net;

namespace Qieshu.inc
{
    
    public class http
    {
        public static string get(string url, int errorlevel = 0)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Proxy = WebRequest.DefaultWebProxy;
                Stream response = request.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(response);
                string responseText = reader.ReadToEnd();
                return responseText;
            }catch(WebException e)
            {
                if(errorlevel < 3)
                {
                    return get(url, errorlevel + 1);
                } else
                {
                    throw new Exception("開發者：我勒個去，" + e.Message);
                }
            }
        }

        public static void download(string url, string filepath, int errorlevel = 0)
        {
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri(url);
                client.DownloadFileAsync(uri, filepath);
            }
            catch (WebException e)
            {
                if (errorlevel < 3)
                {
                    download(url, filepath, errorlevel + 1);
                } else
                {
                    throw new Exception("開發者：我勒個去，" + e.Message);
                }
            }
        }
    }
}
