using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Qieshu.inc;

namespace Qieshu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Tabs.SelectTab(1);
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
            if(Data.p != null)
            {
                if(MessageBox.Show("你確定要放棄當前所有内容并進行采集嗎？", "核准選項", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            string url = Url.Text;
            if (url.IndexOf("http://tieba.baidu.com/p/") != 0)
            {
                MessageBox.Show("你這是要上天啊！", "非法操作", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (url != "")
            {
                statusText.Text = "正在載入……";
                totalStatus.Value = 0;
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
            if (Data.p == null || !Data.p.status)
            {
                MessageBox.Show("然而并沒有什麽可以輸出的！", "無用操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            exportDialog.FileName = Data.p.title + ".txt";
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = exportDialog.FileName;
                if (filename != "")
                {
                    try
                    {
                    FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        StringBuilder sb = new StringBuilder();
                        foreach (page p in Data.p.pages)
                        {
                            foreach (floor f in p.floors)
                            {
                                sb.Append(f.content);
                            }
                        }
                        sw.Write(sb.ToString());
                        sw.Close();
                        fs.Close();
                        MessageBox.Show("保存完成！" + Environment.NewLine + filename, "導出", MessageBoxButtons.OK);
                    }
                    catch (Exception)
                    {
                        throw new Exception("（╯－＿－）╯╧╧");
                    }
                }
            }
        }

        private void Tabs_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    PostTreeView.Visible = true;
                    ContentBox.Visible = false;
                    break;
                case 1:
                    PostTreeView.Visible = false;
                    ContentBox.Visible = true;
                    break;
            }
        }
    }
    public class Data
    {
        public static post p = null;
    }
    public class Options
    {
        public static bool doSeeLZonly = true;
        public static bool doRemoveShort = false;
        public static int vVal = 50;
        public static bool doTrimLeft = false;
    }
}
