using System.Threading;
using System.Text;
using Qieshu.inc;

namespace Qieshu
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private void ThreadFunc()
        {
            while (true)
            {
                if (!eliThreading.isWorking)
                {
                    ContentBox.Text += eliThreading.updateText;
                    ContentBox.Text += "數據已經獲取，3s之後預覽内容……";
                    Thread.Sleep(3000);
                    StringBuilder sb = new StringBuilder();
                    foreach (page pg in Data.p.pages)
                    {
                        foreach (floor f in pg.floors)
                        {
                            sb.Append(f.content);
                        }
                    }
                    ContentBox.Text = sb.ToString();
                    statusText.Text = "載入完畢！" + Data.p.pn + "/" + Data.p.pn;
                    currentMission.Text = "處理完成：" + Data.p.title + " 由 " + Data.p.lz + " 發佈。";
                    totalStatus.Value = 100;
                    eliThreading.status = "";
                    eliThreading.percentage = 0;
                    eliThreading.mission = "";
                    return;
                }
                if (eliThreading.doRequireUpdate)
                {
                    statusText.Text = eliThreading.status;
                    totalStatus.Value = eliThreading.percentage;
                    currentMission.Text = eliThreading.mission;
                    ContentBox.Text += eliThreading.updateText;
                    eliThreading.reportUpdated();
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void WorkingThread()
        {
            eliThreading.isWorking = true;
            string url = Url.Text;
            Data.p = new post(url);
            eliThreading.isWorking = false;
        }
    }
}

namespace Qieshu.inc
{
    public class eliThreading
    {
        public static string status;
        public static int percentage;
        public static string mission;
        public static bool isWorking = false;
        public static bool doRequireUpdate = false;
        public static string updateText = "";
        private static int n1 = 0, n2 = 0;

        public static void reportUpdated()
        {
            updateText = "";
            doRequireUpdate = false;
        }

        public static void setUpdate(int workingPage, int pn, string title)
        {
            status = "正在讀取頁面：" + workingPage + "/" + pn;
            percentage = (int)(((double)workingPage / (double)pn) * 100);
            if (title != "")
            {
                mission = "正在處理中：" + title + "……";
            }
            doRequireUpdate = true;
        }

        public static void floorUpdate(int replies, int pics)
        {
            n1 += replies;
            n2 += pics;
        }

        public static void textUpdate(int workingPage)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[" + System.DateTime.Now.ToLongTimeString() + "] ");
            sb.Append("頁面");
            sb.Append(workingPage);
            sb.Append("，采集評論");
            sb.Append(n1);
            sb.Append("條，");
            if(n2 > 0)
            {
                sb.Append(n2);
                sb.Append("張圖片。");
            }
            else
            {
                sb.Append("沒有圖片。");
            }
            sb.Append(System.Environment.NewLine);
            updateText += sb.ToString();
            n1 = 0;
            n2 = 0;
        }
    }
}
