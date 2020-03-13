namespace AutoBackup {
    partial class Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.openFolderButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.timerBox = new System.Windows.Forms.NumericUpDown();
            this.enableDisableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastBackupTextbox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backupPathTextBox = new System.Windows.Forms.TextBox();
            this.backupButton = new System.Windows.Forms.Button();
            this.backupFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.countdownTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMinimize = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerBox)).BeginInit();
            this.notifyIconContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolderButton
            // 
            resources.ApplyResources(this.openFolderButton, "openFolderButton");
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // folderPathTextBox
            // 
            resources.ApplyResources(this.folderPathTextBox, "folderPathTextBox");
            this.folderPathTextBox.Name = "folderPathTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timerBox
            // 
            resources.ApplyResources(this.timerBox, "timerBox");
            this.timerBox.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.timerBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerBox.Name = "timerBox";
            this.timerBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // enableDisableButton
            // 
            this.enableDisableButton.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.enableDisableButton, "enableDisableButton");
            this.enableDisableButton.Name = "enableDisableButton";
            this.enableDisableButton.UseVisualStyleBackColor = true;
            this.enableDisableButton.Click += new System.EventHandler(this.enableDisableButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lastBackupTextbox
            // 
            this.lastBackupTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.lastBackupTextbox, "lastBackupTextbox");
            this.lastBackupTextbox.Name = "lastBackupTextbox";
            this.lastBackupTextbox.ReadOnly = true;
            this.lastBackupTextbox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backupPathTextBox
            // 
            resources.ApplyResources(this.backupPathTextBox, "backupPathTextBox");
            this.backupPathTextBox.Name = "backupPathTextBox";
            // 
            // backupButton
            // 
            resources.ApplyResources(this.backupButton, "backupButton");
            this.backupButton.Name = "backupButton";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // countdownTextBox
            // 
            resources.ApplyResources(this.countdownTextBox, "countdownTextBox");
            this.countdownTextBox.Name = "countdownTextBox";
            this.countdownTextBox.ReadOnly = true;
            this.countdownTextBox.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextStrip;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconContextStrip
            // 
            this.notifyIconContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconContextStrip.Name = "notifyIconContextStrip";
            resources.ApplyResources(this.notifyIconContextStrip, "notifyIconContextStrip");
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            resources.ApplyResources(this.maximizeToolStripMenuItem, "maximizeToolStripMenuItem");
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.DoubleClick += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyMinimize
            // 
            this.notifyMinimize.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyMinimize, "notifyMinimize");
            this.notifyMinimize.ContextMenuStrip = this.notifyIconContextStrip;
            this.notifyMinimize.DoubleClick += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countdownTextBox);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.backupPathTextBox);
            this.Controls.Add(this.lastBackupTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enableDisableButton);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.openFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.timerBox)).EndInit();
            this.notifyIconContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timerBox;
        private System.Windows.Forms.Button enableDisableButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastBackupTextbox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox backupPathTextBox;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.FolderBrowserDialog backupFolderDialog;
        private System.Windows.Forms.TextBox countdownTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextStrip;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyMinimize;
    }
}

