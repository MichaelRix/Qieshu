namespace Qieshu
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GetButton = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.TextBox();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.TipUrl = new System.Windows.Forms.Label();
            this.checkSeeLZonly = new System.Windows.Forms.CheckBox();
            this.checkRemoveShort = new System.Windows.Forms.CheckBox();
            this.checkTrimLeft = new System.Windows.Forms.CheckBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.currentMission = new System.Windows.Forms.ToolStripStatusLabel();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.vValNum = new System.Windows.Forms.NumericUpDown();
            this.PostTreeView = new System.Windows.Forms.TreeView();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vValNum)).BeginInit();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetButton.Location = new System.Drawing.Point(710, 7);
            this.GetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(124, 32);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "采集";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // Url
            // 
            this.Url.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Url.Location = new System.Drawing.Point(167, 10);
            this.Url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(534, 29);
            this.Url.TabIndex = 1;
            this.Url.TextChanged += new System.EventHandler(this.Url_TextChanged);
            // 
            // ContentBox
            // 
            this.ContentBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ContentBox.Location = new System.Drawing.Point(46, 81);
            this.ContentBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContentBox.MaxLength = 2147483647;
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(788, 500);
            this.ContentBox.TabIndex = 2;
            // 
            // TipUrl
            // 
            this.TipUrl.AutoSize = true;
            this.TipUrl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipUrl.Location = new System.Drawing.Point(43, 14);
            this.TipUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipUrl.Name = "TipUrl";
            this.TipUrl.Size = new System.Drawing.Size(97, 17);
            this.TipUrl.TabIndex = 3;
            this.TipUrl.Text = "帖URL（或tid）:";
            // 
            // checkSeeLZonly
            // 
            this.checkSeeLZonly.AutoSize = true;
            this.checkSeeLZonly.Checked = true;
            this.checkSeeLZonly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSeeLZonly.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkSeeLZonly.Location = new System.Drawing.Point(46, 46);
            this.checkSeeLZonly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkSeeLZonly.Name = "checkSeeLZonly";
            this.checkSeeLZonly.Size = new System.Drawing.Size(93, 25);
            this.checkSeeLZonly.TabIndex = 4;
            this.checkSeeLZonly.Text = "衹看樓主";
            this.checkSeeLZonly.UseVisualStyleBackColor = true;
            this.checkSeeLZonly.CheckedChanged += new System.EventHandler(this.checkSeeLZonly_CheckedChanged);
            // 
            // checkRemoveShort
            // 
            this.checkRemoveShort.AutoSize = true;
            this.checkRemoveShort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkRemoveShort.Location = new System.Drawing.Point(147, 46);
            this.checkRemoveShort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRemoveShort.Name = "checkRemoveShort";
            this.checkRemoveShort.Size = new System.Drawing.Size(94, 25);
            this.checkRemoveShort.TabIndex = 5;
            this.checkRemoveShort.Text = "避短 size";
            this.checkRemoveShort.UseVisualStyleBackColor = true;
            this.checkRemoveShort.CheckedChanged += new System.EventHandler(this.checkRemoveShort_CheckedChanged);
            // 
            // checkTrimLeft
            // 
            this.checkTrimLeft.AutoSize = true;
            this.checkTrimLeft.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkTrimLeft.Location = new System.Drawing.Point(354, 46);
            this.checkTrimLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkTrimLeft.Name = "checkTrimLeft";
            this.checkTrimLeft.Size = new System.Drawing.Size(61, 25);
            this.checkTrimLeft.TabIndex = 6;
            this.checkTrimLeft.Text = "去空";
            this.checkTrimLeft.UseVisualStyleBackColor = true;
            this.checkTrimLeft.CheckedChanged += new System.EventHandler(this.checkTrimLeft_CheckedChanged);
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutputButton.Location = new System.Drawing.Point(710, 45);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(124, 32);
            this.OutputButton.TabIndex = 7;
            this.OutputButton.Text = "輸出";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.totalStatus,
            this.currentMission});
            this.statusStrip.Location = new System.Drawing.Point(0, 601);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip.Size = new System.Drawing.Size(884, 30);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusText
            // 
            this.statusText.AutoSize = false;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(150, 25);
            this.statusText.Text = "沒有進行采集：0/0";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalStatus
            // 
            this.totalStatus.AutoSize = false;
            this.totalStatus.Name = "totalStatus";
            this.totalStatus.Size = new System.Drawing.Size(143, 24);
            // 
            // currentMission
            // 
            this.currentMission.Name = "currentMission";
            this.currentMission.Size = new System.Drawing.Size(113, 25);
            this.currentMission.Text = "未載入任何任務。";
            // 
            // exportDialog
            // 
            this.exportDialog.CreatePrompt = true;
            this.exportDialog.DefaultExt = "txt";
            this.exportDialog.Filter = "純文本檔|*.txt";
            this.exportDialog.Title = "輸出至純文本檔";
            // 
            // vValNum
            // 
            this.vValNum.Location = new System.Drawing.Point(237, 45);
            this.vValNum.Margin = new System.Windows.Forms.Padding(4);
            this.vValNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.vValNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vValNum.Name = "vValNum";
            this.vValNum.Size = new System.Drawing.Size(109, 29);
            this.vValNum.TabIndex = 11;
            this.vValNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.vValNum.ValueChanged += new System.EventHandler(this.vValNum_ValueChanged);
            // 
            // PostTreeView
            // 
            this.PostTreeView.Location = new System.Drawing.Point(46, 81);
            this.PostTreeView.Name = "PostTreeView";
            this.PostTreeView.Size = new System.Drawing.Size(788, 500);
            this.PostTreeView.TabIndex = 12;
            this.PostTreeView.Visible = false;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(546, 53);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(157, 27);
            this.Tabs.TabIndex = 13;
            this.Tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tabs_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(149, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "樹狀檢視";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(149, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文本檢視";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 631);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.PostTreeView);
            this.Controls.Add(this.vValNum);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.checkTrimLeft);
            this.Controls.Add(this.checkRemoveShort);
            this.Controls.Add(this.checkSeeLZonly);
            this.Controls.Add(this.TipUrl);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.GetButton);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "竊書不能算偷竊書";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vValNum)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Label TipUrl;
        private System.Windows.Forms.CheckBox checkSeeLZonly;
        private System.Windows.Forms.CheckBox checkRemoveShort;
        private System.Windows.Forms.CheckBox checkTrimLeft;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.NumericUpDown vValNum;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripProgressBar totalStatus;
        private System.Windows.Forms.ToolStripStatusLabel currentMission;
        private System.Windows.Forms.TreeView PostTreeView;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

