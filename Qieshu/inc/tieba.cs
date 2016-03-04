using System;

namespace Qieshu.inc
{
    public class image
    {
        public string url;
        public string format;
        public int width, height;
    }
    public class floor
    {
        public string content;
        public image[] images;
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
        public bool status = false;

        public string getPostId()
        {
            string pattern = "thread_id:[0-9]*,";
            string r = match.preg_match(raw, pattern);
            pattern = ":[0-9]*,";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public string getPostTitle()
        {
            string pattern = "title:.*?\",";
            string r = match.preg_match(raw, pattern);
            pattern = "\".*\"";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public string getPostAuthor()
        {
            string pattern = "author:.*?\",";
            string r = match.preg_match(raw, pattern);
            pattern = "\".*\"";
            r = match.preg_match(r, pattern);
            return r.Substring(1, r.Length - 2);
        }
        public int getPostPageCount()
        {
            string pattern = "pn=[0-9]*\">尾页</a>";
            string r = match.preg_match(raw, pattern);
            if (r == "") return 1;
            pattern = "=[0-9]*\"";
            r = match.preg_match(r, pattern);
            r = r.Substring(1, r.Length - 2);
            return Convert.ToInt32(r);
        }
        public image[] getFloorImages(string rawfloor)
        {
            string pattern = "<img class=\"BDE_Image\".*?>";
            string[] rawimages = match.preg_match_multi(rawfloor, pattern);
            image[] images = new image[rawimages.Length];
            for(int i = 0; i < rawimages.Length; i++)
            {
                images[i] = new image();
                string tag = rawimages[i];

                pattern = "width=\"[0-9].*?\"";
                string ws = match.preg_match(tag, pattern);
                ws = ws.Substring(7, ws.Length - 8);
                images[i].width = Convert.ToInt32(ws);

                pattern = "height=\"[0-9].*?\"";
                // height="450"
                // 0123456789AB
                string hs = match.preg_match(tag, pattern);
                hs = hs.Substring(8, hs.Length - 9);
                images[i].height = Convert.ToInt32(hs);

                pattern = "src=\".*?\"";
                // src="s.jpg"
                // 0123456789A
                string src = match.preg_match(tag, pattern);
                src = src.Substring(5, src.Length - 6);
                images[i].url = src;
                pattern = "\\.\\w+$";
                images[i].format = match.preg_match(src, pattern);
            }
            eliThreading.floorUpdate(0, images.Length);
            return images;
        }
        public floor[] getPageFloors(int number)
        {
            string url = from + (Options.doSeeLZonly ? "?see_lz=1&pn=" : "?pn=") + number;
            if (number != 1) raw = http.get(url);
            string pattern = "<cc>.*?</cc>";
            string[] rawfloors = match.preg_match_multi(raw, pattern);
            floor[] floors = new floor[rawfloors.Length];
            for(int i = 0; i < rawfloors.Length; i++)
            {
                floors[i] = new floor();
                floors[i].content = match.html2plain(rawfloors[i]);
                if (Options.doRemoveShort)
                {
                    if (floors[i].content.Length < Options.vVal)
                    {
                        floors[i].content = "";
                    }
                }
                floors[i].images = getFloorImages(rawfloors[i]);
            }
            eliThreading.floorUpdate(floors.Length, 0);
            return floors;
        }
        public page[] getPostPages() {
            page[] ps = new page[pn];
            for(int i=0;i < pn; i++)
            {
                eliThreading.setUpdate(i + 1, pn, title);
                ps[i] = new page();
                ps[i].floors = getPageFloors(i + 1);
                eliThreading.textUpdate(i + 1);
            }
            return ps;
        }

        public post() { }
        public post(string url) {
            if (url.Contains("?")) url = url.Substring(0, url.IndexOf("?") + 1);
            if (Options.doSeeLZonly) url += "?see_lz=1";

            raw = http.get(url);
            title = getPostTitle();
            title = match.htmlspecialchars_decode(title);
            pid = getPostId();
            lz = getPostAuthor();
            pn = getPostPageCount();
            from = "http://tieba.baidu.com/p/" + pid;
            eliThreading.setUpdate(0, pn, title);
            pages = getPostPages();
            status = true;
        }
    }
}
