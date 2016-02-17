using System;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Qieshu.inc;

namespace Qieshu
{
    public partial class MainForm : Form
    {
        private void ThreadFunc()
        {
            while (true)
            {
                if (eliThreading.isFinished)
                {
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
                    eliThreading.isFinished = false;
                    eliThreading.isWorking = false;
                    return;
                }
                if (eliThreading.doRequireUpdate)
                {
                    statusText.Text = eliThreading.status;
                    totalStatus.Value = eliThreading.percentage;
                    currentMission.Text = eliThreading.mission;
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
            eliThreading.isFinished = false;
            string url = Url.Text;
            Data.p = new post(url, true);
            eliThreading.isFinished = true;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Url_TextChanged(object sender, EventArgs e)
        {
            string text = Url.Text;
            if(text.IndexOf("http://tieba.baidu.com/p/") == 0)
            {
                // Do nothing;
            }else if(text.IndexOf("tieba.baidu.com/p/") == 0)
            {
                text = "http://" + text;
                Url.Text = text;
            }
            else
            {
                if(match.preg_match(text, "[0-9]*") != "")
                {
                    text = "http://tieba.baidu.com/p/" + text;
                }
                Url.Text = text;
                Url.SelectionStart = Url.Text.Length;
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            if (eliThreading.isWorking) return;
            string url = Url.Text;
            if (url.IndexOf("http://tieba.baidu.com/p/") != 0) return;
            if (url != "")
            {
                statusText.Text = "正在載入……";
                currentMission.Text = "讀取中： " + url;

                Thread worker = new Thread(WorkingThread);
                worker.IsBackground = true;
                worker.Start();

                Thread sleepThread = new Thread(ThreadFunc);
                sleepThread.IsBackground = true;
                sleepThread.Start();
            }
        }

        private void checkSeeLZonly_CheckedChanged(object sender, EventArgs e)
        {
            Options.doSeeLZonly = checkSeeLZonly.Checked;
        }

        private void checkRemoveShort_CheckedChanged(object sender, EventArgs e)
        {
            Options.doRemoveShort = checkRemoveShort.Checked;
        }

        private void checkTrimLeft_CheckedChanged(object sender, EventArgs e)
        {
            Options.doTrimLeft = checkTrimLeft.Checked;
        }

        private void vValNum_ValueChanged(object sender, EventArgs e)
        {
            Options.vVal =  (int)vValNum.Value;
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            exportDialog.FileName = Data.p.title + ".txt";
            exportDialog.ShowDialog();
        }

        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = exportDialog.FileName;
            if(filename != "")
            {
                FileStream fs = new FileStream(filename, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs);
                StringBuilder sb = new StringBuilder();
                foreach(page p in Data.p.pages)
                {
                    foreach(floor f in p.floors)
                    {
                        sb.Append(f.content);
                    }
                }
                sw.Write(sb.ToString());
                sw.Close();
                fs.Close();
                MessageBox.Show("保存完成！" + Environment.NewLine + filename, "導出", MessageBoxButtons.OK);
            }
        }
    }
    public class eliThreading
    {
        public static string status;
        public static int percentage;
        public static string mission;
        public static bool isWorking = false;
        public static bool isFinished = false;
        public static bool doRequireUpdate = false;

        public static void reportUpdated()
        {
            doRequireUpdate = false;
        }

        public static void setUpdate(int workingPage, int pn, string title)
        {
            status = "正在讀取頁面：" + workingPage + "/" + pn;
            percentage = (int)(((double)workingPage / (double)pn) * 100);
            if(title != "")
            {
                mission = "正在處理中：" + title + "……";
            }
            doRequireUpdate = true;
        }
    }
    public class Data
    {
        public static post p;
    }
    public class Options
    {
        public static bool doSeeLZonly = true;
        public static bool doRemoveShort = false;
        public static int vVal = 50;
        public static bool doTrimLeft = false;
    }
}
