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
        public string owner;
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
            string pattern = @"(?<=thread_id\s*:\s*)\d+(?=,)";
            string r = match.preg_match(raw, pattern);
            return r;
        }
        public string getPostTitle()
        {
            string pattern = "(?<=title\\s*:\\s*\").+?(?=\",)";
            string r = match.preg_match(raw, pattern);
            return r;
        }
        public string getPostAuthor()
        {
            string pattern = "(?<=author\\s*?:\\s*\").+?(?=\",)";
            string r = match.preg_match(raw, pattern);
            return r;
        }
        public int getPostPageCount()
        {
            string pattern = "(?<=\"total_page\":)\\d+(?=\\D)";
            string r = match.preg_match(raw, pattern);
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

                pattern = "(?<=width=\")\\d+?(?=\")";
                string ws = match.preg_match(tag, pattern);
                images[i].width = Convert.ToInt32(ws);

                pattern = "(?<=height=\")\\d+?(?=\")";
                string hs = match.preg_match(tag, pattern);
                images[i].height = Convert.ToInt32(hs);

                pattern = "(?<=src=\").*?(?=\")";
                string src = match.preg_match(tag, pattern);
                images[i].url = src;
                pattern = "(?!\\.)\\w+$";
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
            pattern = "(?<=<img\\s*?username=\").*?(?=\")";
            string[] owners = match.preg_match_multi(raw, pattern);
            floor[] floors = new floor[rawfloors.Length];
            for(int i = 0; i < rawfloors.Length; i++)
            {
                floors[i] = new floor();
                floors[i].owner = owners[i];
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
