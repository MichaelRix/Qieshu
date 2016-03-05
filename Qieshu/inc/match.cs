using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace Qieshu.inc
{
    class match
    {
        public static string preg_match(string source, string pattern)
        {
            if (source == "" || pattern == "") return "";
            Regex r = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Multiline);
            Match m = r.Match(source);
            return m.Value;
        }

        public static string[] preg_match_multi(string source, string pattern)
        {
            if (source == "" || pattern == "") return null;
            Regex r = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Multiline);
            MatchCollection colle = r.Matches(source);
            string[] results = new string[colle.Count];
            for (int i = 0; i < colle.Count; i++)
            {
                results[i] = colle[i].Value;
            }
            return results;
        }
        
        public static string strip_tag(string source)
        {
            string pattern = ">.*?<";
            string[] results = preg_match_multi(source, pattern);
            StringBuilder sb = new StringBuilder();
            foreach(string single in results)
            {
                sb.Append(single.Substring(1, single.Length - 2));
            }
            return sb.ToString();
        }

        public static string trim_left(string source)
        {
            Regex r = new Regex("^\\s*", RegexOptions.Singleline | RegexOptions.Multiline);
            source = r.Replace(source, "");
            return source;
        }

        public static string htmlspecialchars_decode(string source)
        {
            return WebUtility.HtmlDecode(source);
        }

        public static string html2plain(string source)
        {
            source = source.Replace("<br>", Environment.NewLine);
            source = strip_tag(source);
            if (Options.doTrimLeft)
            {
                source = trim_left(source);
            }
            source = htmlspecialchars_decode(source);
            return source;
        }

        public static string excerpt(string source, int length = 40)
        {
            source = trim_left(source);
            if (source.Length < 30) return source;
            source = source.Substring(0, length);
            return source + "…";
        }
    }
}
