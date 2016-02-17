using System;

namespace Qieshu.inc
{
    public class floor
    {
        public string content;
    }
    public class page
    {
        public floor[] floors;
    }
    public class post
    {
        public string pid;
        public string title;
        public string from;
        public int pn;
        public page[] pages;
        public string lz;
        public string raw;

        public string getPostId()
        {
            string pattern = "thread_id:[0-9]*,";
            string r = match.preg_match(raw, pattern);
            // thread_id:4039232986,
            pattern = ":[0-9]*,";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public string getPostTitle()
        {
            string pattern = "title:.*?\",";
            string r = match.preg_match(raw, pattern);
            // title: "海未「惨剧之馆」番外篇",
            pattern = "\".*\"";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public string getPostAuthor()
        {
            string pattern = "author:.*?\",";
            string r = match.preg_match(raw, pattern);
            // author: "AIR丶珍惜",
            pattern = "\".*\"";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public int getPostPageCount()
        {
            string pattern = "pn=[0-9]*\">尾页</a>";
            string r = match.preg_match(raw, pattern);
            if (r == "") return 1;
            // ?pn=11">尾页</a>
            // 01234567
            pattern = "=[0-9]*\"";
            r = match.preg_match(r, pattern);
            r = r.Substring(1, r.Length - 2);
            return Convert.ToInt32(r);
        }

        public page[] getSinglePage()
        {
            page[] ps = new page[1];
            string pattern = "<cc>.*?</cc>";
            string[] rawfloors = match.preg_match_multi(raw, pattern);
            ps[0].floors = new floor[rawfloors.Length];
            for (int i = 0; i < rawfloors.Length; i++)
            {
                ps[0].floors[i] = new floor();
                ps[i].floors[i].content = match.html2plain(rawfloors[i]);
                if (ps[0].floors[i].content.Length < Options.vVal)
                {
                    ps[0].floors[i].content = "";
                }
            }
            return ps;
        }
        public page[] getPostPages() {
            page[] ps = new page[pn + 1];
            for(int i=0;i <= pn; i++)
            {
                eliThreading.setUpdate(i, pn, title);
                ps[i] = new page();
                string url = from + (Options.doSeeLZonly ? "?see_lz=1&pn=" : "?pn=") + i;
                raw = http.get(url);
                string pattern = "<cc>.*?</cc>";
                match m = new match();
                string[] rawfloors = match.preg_match_multi(raw, pattern);
                ps[i].floors = new floor[rawfloors.Length];
                for (int j = 0; j < rawfloors.Length; j++)
                {
                    ps[i].floors[j] = new floor();
                    ps[i].floors[j].content = match.html2plain(rawfloors[j]);
                    if (Options.doRemoveShort)
                    {
                        if(ps[i].floors[j].content.Length < Options.vVal)
                        {
                            ps[i].floors[j].content = "";
                        }
                    }
                }
            }
            return ps;
        }

        public post() { }
        public post(string html) {
            raw = html;
            pid = getPostId();
            lz = getPostAuthor();
            pn = getPostPageCount();
            from = "http://tieba.baidu.com/p/" + pid;
            pages = getSinglePage();
        }
        public post(string url, bool fromurl = true) {
            if (url.Contains("?")) url = url.Substring(0, url.IndexOf("?") + 1);
            if (Options.doSeeLZonly) url += "?see_lz=1";

            raw = http.get(url);
            title = getPostTitle();
            pid = getPostId();
            lz = getPostAuthor();
            pn = getPostPageCount();
            from = "http://tieba.baidu.com/p/" + pid;
            eliThreading.setUpdate(0, pn, title);
            pages = getPostPages();
        }
    }
}
