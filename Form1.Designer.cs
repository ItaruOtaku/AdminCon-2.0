using System; //提供Exception类（第26行）。

namespace Win10Maid
{
    partial class winmaidForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch(Exception ex)
            {
                //不对此异常进行处理（忽略）。
                string exeptionMessage = ex.Message; //I HATE WARNINGS. :(
            }
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winmaidForm));
            this.endAllProcessButton = new System.Windows.Forms.Button();
            this.regeditButton = new System.Windows.Forms.Button();
            this.tempButton = new System.Windows.Forms.Button();
            this.taskmgrButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.ipInputBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.pingButton = new System.Windows.Forms.Button();
            this.devmgmtButton = new System.Windows.Forms.Button();
            this.diskmgmtButton = new System.Windows.Forms.Button();
            this.cleanmgrButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.powershellButton = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.taskkillButton = new System.Windows.Forms.Button();
            this.PNameTextBox = new System.Windows.Forms.TextBox();
            this.PNameLabel = new System.Windows.Forms.Label();
            this.getPIDorTASKKILLcheckBox = new System.Windows.Forms.CheckBox();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.PIDlistButton = new System.Windows.Forms.Button();
            this.runAllButton = new System.Windows.Forms.Button();
            this.ipConfigButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // endAllProcessButton
            // 
            this.endAllProcessButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endAllProcessButton.ForeColor = System.Drawing.Color.Red;
            this.endAllProcessButton.Location = new System.Drawing.Point(770, 381);
            this.endAllProcessButton.Margin = new System.Windows.Forms.Padding(2);
            this.endAllProcessButton.Name = "endAllProcessButton";
            this.endAllProcessButton.Size = new System.Drawing.Size(119, 54);
            this.endAllProcessButton.TabIndex = 10;
            this.endAllProcessButton.Text = "End All Programs (.exe)";
            this.endAllProcessButton.UseVisualStyleBackColor = true;
            this.endAllProcessButton.Click += new System.EventHandler(this.endAllProcessButton_Click);
            // 
            // regeditButton
            // 
            this.regeditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.regeditButton.Location = new System.Drawing.Point(39, 258);
            this.regeditButton.Margin = new System.Windows.Forms.Padding(2);
            this.regeditButton.Name = "regeditButton";
            this.regeditButton.Size = new System.Drawing.Size(92, 39);
            this.regeditButton.TabIndex = 9;
            this.regeditButton.Text = "regedit.exe";
            this.regeditButton.UseVisualStyleBackColor = true;
            this.regeditButton.Click += new System.EventHandler(this.regeditButton_Click);
            // 
            // tempButton
            // 
            this.tempButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tempButton.Location = new System.Drawing.Point(40, 340);
            this.tempButton.Margin = new System.Windows.Forms.Padding(2);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(90, 35);
            this.tempButton.TabIndex = 8;
            this.tempButton.Text = "%temp%";
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // taskmgrButton
            // 
            this.taskmgrButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.taskmgrButton.Location = new System.Drawing.Point(40, 108);
            this.taskmgrButton.Margin = new System.Windows.Forms.Padding(2);
            this.taskmgrButton.Name = "taskmgrButton";
            this.taskmgrButton.Size = new System.Drawing.Size(91, 44);
            this.taskmgrButton.TabIndex = 7;
            this.taskmgrButton.Text = "taskmgr.exe";
            this.taskmgrButton.UseVisualStyleBackColor = true;
            this.taskmgrButton.Click += new System.EventHandler(this.taskmgrButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.servicesButton.Location = new System.Drawing.Point(40, 66);
            this.servicesButton.Margin = new System.Windows.Forms.Padding(2);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(91, 33);
            this.servicesButton.TabIndex = 6;
            this.servicesButton.Text = "services.msc";
            this.servicesButton.UseVisualStyleBackColor = true;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // ipInputBox
            // 
            this.ipInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ipInputBox.Location = new System.Drawing.Point(173, 316);
            this.ipInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.ipInputBox.Name = "ipInputBox";
            this.ipInputBox.Size = new System.Drawing.Size(145, 20);
            this.ipInputBox.TabIndex = 4;
            this.ipInputBox.TextChanged += new System.EventHandler(this.ipInputBox_TextChanged);
            // 
            // ipLabel
            // 
            this.ipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ipLabel.AutoSize = true;
            this.ipLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ipLabel.Location = new System.Drawing.Point(173, 286);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(61, 13);
            this.ipLabel.TabIndex = 5;
            this.ipLabel.Text = "IP Address:";
            // 
            // pingButton
            // 
            this.pingButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pingButton.Location = new System.Drawing.Point(40, 301);
            this.pingButton.Margin = new System.Windows.Forms.Padding(2);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(91, 35);
            this.pingButton.TabIndex = 3;
            this.pingButton.Text = "ping.exe";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // devmgmtButton
            // 
            this.devmgmtButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.devmgmtButton.Location = new System.Drawing.Point(40, 156);
            this.devmgmtButton.Margin = new System.Windows.Forms.Padding(2);
            this.devmgmtButton.Name = "devmgmtButton";
            this.devmgmtButton.Size = new System.Drawing.Size(91, 44);
            this.devmgmtButton.TabIndex = 2;
            this.devmgmtButton.Text = "devmgmt.msc";
            this.devmgmtButton.UseVisualStyleBackColor = true;
            this.devmgmtButton.Click += new System.EventHandler(this.devmgmtButton_Click);
            // 
            // diskmgmtButton
            // 
            this.diskmgmtButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.diskmgmtButton.Location = new System.Drawing.Point(40, 206);
            this.diskmgmtButton.Margin = new System.Windows.Forms.Padding(2);
            this.diskmgmtButton.Name = "diskmgmtButton";
            this.diskmgmtButton.Size = new System.Drawing.Size(91, 44);
            this.diskmgmtButton.TabIndex = 1;
            this.diskmgmtButton.Text = "diskmgmt.msc";
            this.diskmgmtButton.UseVisualStyleBackColor = true;
            this.diskmgmtButton.Click += new System.EventHandler(this.diskmgmtButton_Click);
            // 
            // cleanmgrButton
            // 
            this.cleanmgrButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cleanmgrButton.Location = new System.Drawing.Point(40, 18);
            this.cleanmgrButton.Margin = new System.Windows.Forms.Padding(2);
            this.cleanmgrButton.Name = "cleanmgrButton";
            this.cleanmgrButton.Size = new System.Drawing.Size(91, 44);
            this.cleanmgrButton.TabIndex = 0;
            this.cleanmgrButton.Text = "Cleanmgr.exe";
            this.cleanmgrButton.UseVisualStyleBackColor = true;
            this.cleanmgrButton.Click += new System.EventHandler(this.cleanmgrButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel.BackgroundImage")));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.14379F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.85621F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel.Controls.Add(this.cleanmgrButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.regeditButton, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.servicesButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.taskmgrButton, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.devmgmtButton, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.diskmgmtButton, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.powershellButton, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.processLabel, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.taskkillButton, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.PNameTextBox, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.PNameLabel, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.getPIDorTASKKILLcheckBox, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.OutputRichTextBox, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.pingButton, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.tempButton, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.ipLabel, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.ipInputBox, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.OutputLabel, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.PIDlistButton, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.endAllProcessButton, 3, 8);
            this.tableLayoutPanel.Controls.Add(this.runAllButton, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.ipConfigButton, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 1, 9);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.06306F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.93694F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(917, 553);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // powershellButton
            // 
            this.powershellButton.Location = new System.Drawing.Point(771, 67);
            this.powershellButton.Name = "powershellButton";
            this.powershellButton.Size = new System.Drawing.Size(96, 29);
            this.powershellButton.TabIndex = 13;
            this.powershellButton.Text = "Powershell";
            this.powershellButton.UseVisualStyleBackColor = true;
            this.powershellButton.Click += new System.EventHandler(this.powershellButton_Click);
            // 
            // processLabel
            // 
            this.processLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processLabel.AutoSize = true;
            this.processLabel.BackColor = System.Drawing.Color.Transparent;
            this.processLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.processLabel.Location = new System.Drawing.Point(771, 51);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(108, 13);
            this.processLabel.TabIndex = 14;
            this.processLabel.Text = "Processes Operation:";
            // 
            // taskkillButton
            // 
            this.taskkillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskkillButton.ForeColor = System.Drawing.Color.Red;
            this.taskkillButton.Location = new System.Drawing.Point(771, 119);
            this.taskkillButton.Name = "taskkillButton";
            this.taskkillButton.Size = new System.Drawing.Size(118, 32);
            this.taskkillButton.TabIndex = 15;
            this.taskkillButton.Text = "Kill Process By Name";
            this.taskkillButton.UseVisualStyleBackColor = true;
            this.taskkillButton.Click += new System.EventHandler(this.taskkillButton_Click);
            // 
            // PNameTextBox
            // 
            this.PNameTextBox.Location = new System.Drawing.Point(771, 157);
            this.PNameTextBox.Name = "PNameTextBox";
            this.PNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.PNameTextBox.TabIndex = 16;
            this.PNameTextBox.Tag = "";
            this.PNameTextBox.TextChanged += new System.EventHandler(this.PNameTextBox_TextChanged);
            // 
            // PNameLabel
            // 
            this.PNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNameLabel.AutoSize = true;
            this.PNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PNameLabel.ForeColor = System.Drawing.Color.White;
            this.PNameLabel.Location = new System.Drawing.Point(686, 154);
            this.PNameLabel.Name = "PNameLabel";
            this.PNameLabel.Size = new System.Drawing.Size(79, 13);
            this.PNameLabel.TabIndex = 17;
            this.PNameLabel.Text = "Process Name:";
            // 
            // getPIDorTASKKILLcheckBox
            // 
            this.getPIDorTASKKILLcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getPIDorTASKKILLcheckBox.AutoSize = true;
            this.getPIDorTASKKILLcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.getPIDorTASKKILLcheckBox.ForeColor = System.Drawing.Color.Yellow;
            this.getPIDorTASKKILLcheckBox.Location = new System.Drawing.Point(667, 134);
            this.getPIDorTASKKILLcheckBox.Name = "getPIDorTASKKILLcheckBox";
            this.getPIDorTASKKILLcheckBox.Size = new System.Drawing.Size(98, 17);
            this.getPIDorTASKKILLcheckBox.TabIndex = 18;
            this.getPIDorTASKKILLcheckBox.Text = "Get Process ID";
            this.getPIDorTASKKILLcheckBox.UseVisualStyleBackColor = false;
            this.getPIDorTASKKILLcheckBox.CheckedChanged += new System.EventHandler(this.getPIDorTASKKILLcheckBox_CheckedChanged);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(174, 382);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(479, 133);
            this.OutputRichTextBox.TabIndex = 20;
            this.OutputRichTextBox.Text = "";
            this.OutputRichTextBox.TextChanged += new System.EventHandler(this.OutputRichTextBox_TextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.ForeColor = System.Drawing.Color.White;
            this.OutputLabel.Location = new System.Drawing.Point(174, 366);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(346, 13);
            this.OutputLabel.TabIndex = 22;
            this.OutputLabel.Text = "Output (Do not operate for another output until current output is finished)";
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // PIDlistButton
            // 
            this.PIDlistButton.Location = new System.Drawing.Point(771, 255);
            this.PIDlistButton.Name = "PIDlistButton";
            this.PIDlistButton.Size = new System.Drawing.Size(118, 37);
            this.PIDlistButton.TabIndex = 19;
            this.PIDlistButton.Text = "List All Processes and PID";
            this.PIDlistButton.UseVisualStyleBackColor = true;
            this.PIDlistButton.Click += new System.EventHandler(this.PIDlistButton_Click);
            // 
            // runAllButton
            // 
            this.runAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runAllButton.ForeColor = System.Drawing.Color.Blue;
            this.runAllButton.Location = new System.Drawing.Point(659, 382);
            this.runAllButton.Name = "runAllButton";
            this.runAllButton.Size = new System.Drawing.Size(106, 53);
            this.runAllButton.TabIndex = 11;
            this.runAllButton.Text = "Run All Programs";
            this.runAllButton.UseVisualStyleBackColor = true;
            this.runAllButton.Click += new System.EventHandler(this.runAllButton_Click);
            // 
            // ipConfigButton
            // 
            this.ipConfigButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ipConfigButton.Location = new System.Drawing.Point(40, 382);
            this.ipConfigButton.Name = "ipConfigButton";
            this.ipConfigButton.Size = new System.Drawing.Size(91, 39);
            this.ipConfigButton.TabIndex = 21;
            this.ipConfigButton.Text = "ipConfig";
            this.ipConfigButton.UseVisualStyleBackColor = true;
            this.ipConfigButton.Click += new System.EventHandler(this.ipConfigButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(173, 520);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(480, 19);
            this.progressBar.TabIndex = 23;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // winmaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 550);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "winmaidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminConsole";
            this.Load += new System.EventHandler(this.winmaidForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button endAllProcessButton;
        private System.Windows.Forms.Button regeditButton;
        private System.Windows.Forms.Button tempButton;
        private System.Windows.Forms.Button taskmgrButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.TextBox ipInputBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Button devmgmtButton;
        private System.Windows.Forms.Button diskmgmtButton;
        private System.Windows.Forms.Button cleanmgrButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button runAllButton;
        private System.Windows.Forms.Button powershellButton;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Button taskkillButton;
        private System.Windows.Forms.TextBox PNameTextBox;
        private System.Windows.Forms.Label PNameLabel;
        private System.Windows.Forms.CheckBox getPIDorTASKKILLcheckBox;
        private System.Windows.Forms.Button PIDlistButton;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Button ipConfigButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

