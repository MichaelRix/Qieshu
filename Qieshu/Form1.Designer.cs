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
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vValNum)).BeginInit();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetButton.Location = new System.Drawing.Point(568, 15);
            this.GetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(87, 26);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "采集";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // Url
            // 
            this.Url.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Url.Location = new System.Drawing.Point(187, 17);
            this.Url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(375, 23);
            this.Url.TabIndex = 1;
            this.Url.TextChanged += new System.EventHandler(this.Url_TextChanged);
            // 
            // ContentBox
            // 
            this.ContentBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ContentBox.Location = new System.Drawing.Point(43, 71);
            this.ContentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentBox.MaxLength = 2147483647;
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(613, 409);
            this.ContentBox.TabIndex = 2;
            // 
            // TipUrl
            // 
            this.TipUrl.AutoSize = true;
            this.TipUrl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipUrl.Location = new System.Drawing.Point(41, 21);
            this.TipUrl.Name = "TipUrl";
            this.TipUrl.Size = new System.Drawing.Size(117, 17);
            this.TipUrl.TabIndex = 3;
            this.TipUrl.Text = "帖URL（或粘貼id）:";
            // 
            // checkSeeLZonly
            // 
            this.checkSeeLZonly.AutoSize = true;
            this.checkSeeLZonly.Checked = true;
            this.checkSeeLZonly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSeeLZonly.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkSeeLZonly.Location = new System.Drawing.Point(43, 46);
            this.checkSeeLZonly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSeeLZonly.Name = "checkSeeLZonly";
            this.checkSeeLZonly.Size = new System.Drawing.Size(75, 21);
            this.checkSeeLZonly.TabIndex = 4;
            this.checkSeeLZonly.Text = "衹看樓主";
            this.checkSeeLZonly.UseVisualStyleBackColor = true;
            this.checkSeeLZonly.CheckedChanged += new System.EventHandler(this.checkSeeLZonly_CheckedChanged);
            // 
            // checkRemoveShort
            // 
            this.checkRemoveShort.AutoSize = true;
            this.checkRemoveShort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkRemoveShort.Location = new System.Drawing.Point(124, 46);
            this.checkRemoveShort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkRemoveShort.Name = "checkRemoveShort";
            this.checkRemoveShort.Size = new System.Drawing.Size(111, 21);
            this.checkRemoveShort.TabIndex = 5;
            this.checkRemoveShort.Text = "屏蔽短句，閾值";
            this.checkRemoveShort.UseVisualStyleBackColor = true;
            this.checkRemoveShort.CheckedChanged += new System.EventHandler(this.checkRemoveShort_CheckedChanged);
            // 
            // checkTrimLeft
            // 
            this.checkTrimLeft.AutoSize = true;
            this.checkTrimLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkTrimLeft.Location = new System.Drawing.Point(323, 46);
            this.checkTrimLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkTrimLeft.Name = "checkTrimLeft";
            this.checkTrimLeft.Size = new System.Drawing.Size(111, 21);
            this.checkTrimLeft.TabIndex = 6;
            this.checkTrimLeft.Text = "去除空格、空行";
            this.checkTrimLeft.UseVisualStyleBackColor = true;
            this.checkTrimLeft.CheckedChanged += new System.EventHandler(this.checkTrimLeft_CheckedChanged);
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutputButton.Location = new System.Drawing.Point(568, 42);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(87, 26);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 487);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(708, 24);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusText
            // 
            this.statusText.AutoSize = false;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(150, 19);
            this.statusText.Text = "沒有進行采集：0/0";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalStatus
            // 
            this.totalStatus.AutoSize = false;
            this.totalStatus.Name = "totalStatus";
            this.totalStatus.Size = new System.Drawing.Size(100, 18);
            // 
            // currentMission
            // 
            this.currentMission.Name = "currentMission";
            this.currentMission.Size = new System.Drawing.Size(113, 19);
            this.currentMission.Text = "未載入任何任務。";
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "txt";
            this.exportDialog.Filter = "純文本檔|*.txt";
            this.exportDialog.Title = "輸出至純文本檔";
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // vValNum
            // 
            this.vValNum.Location = new System.Drawing.Point(241, 44);
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
            this.vValNum.Size = new System.Drawing.Size(76, 23);
            this.vValNum.TabIndex = 11;
            this.vValNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.vValNum.ValueChanged += new System.EventHandler(this.vValNum_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 511);
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
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "竊書不能算偷竊書";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vValNum)).EndInit();
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
    }
}

