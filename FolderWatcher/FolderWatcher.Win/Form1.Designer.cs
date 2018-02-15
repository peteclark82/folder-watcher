namespace FolderWatcher.Win
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIconFolderWatcher = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxWatchers = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRemoveWatcher = new System.Windows.Forms.Button();
            this.buttonSaveWatcher = new System.Windows.Forms.Button();
            this.buttonAddWatcher = new System.Windows.Forms.Button();
            this.tabControlWatcherDetail = new System.Windows.Forms.TabControl();
            this.tabPageWatcherConfig = new System.Windows.Forms.TabPage();
            this.propertyGridWatcher = new System.Windows.Forms.PropertyGrid();
            this.tabPageTriggerConfig = new System.Windows.Forms.TabPage();
            this.propertyGridWatcherTrigger = new System.Windows.Forms.PropertyGrid();
            this.tabPageActionConfig = new System.Windows.Forms.TabPage();
            this.propertyGridWatcherAction = new System.Windows.Forms.PropertyGrid();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.richTextBoxWatcherOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMainConfiguration = new System.Windows.Forms.TabPage();
            this.tabPageMainOutput = new System.Windows.Forms.TabPage();
            this.menuStripApplication = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlWatcherDetail.SuspendLayout();
            this.tabPageWatcherConfig.SuspendLayout();
            this.tabPageTriggerConfig.SuspendLayout();
            this.tabPageActionConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMainConfiguration.SuspendLayout();
            this.tabPageMainOutput.SuspendLayout();
            this.menuStripApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconFolderWatcher
            // 
            this.notifyIconFolderWatcher.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconFolderWatcher.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconFolderWatcher.Icon")));
            this.notifyIconFolderWatcher.Text = "Folder Watcher";
            this.notifyIconFolderWatcher.Visible = true;
            this.notifyIconFolderWatcher.DoubleClick += new System.EventHandler(this.notifyIconFolderWatcher_DoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(117, 54);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem1.Text = "&Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkedListBoxWatchers
            // 
            this.checkedListBoxWatchers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxWatchers.FormattingEnabled = true;
            this.checkedListBoxWatchers.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxWatchers.Name = "checkedListBoxWatchers";
            this.checkedListBoxWatchers.Size = new System.Drawing.Size(283, 574);
            this.checkedListBoxWatchers.TabIndex = 1;
            this.checkedListBoxWatchers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxWatchers_ItemCheck);
            this.checkedListBoxWatchers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxWatchers_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveWatcher);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveWatcher);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddWatcher);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxWatchers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlWatcherDetail);
            this.splitContainer1.Size = new System.Drawing.Size(871, 613);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonRemoveWatcher
            // 
            this.buttonRemoveWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveWatcher.Location = new System.Drawing.Point(61, 586);
            this.buttonRemoveWatcher.Name = "buttonRemoveWatcher";
            this.buttonRemoveWatcher.Size = new System.Drawing.Size(59, 24);
            this.buttonRemoveWatcher.TabIndex = 3;
            this.buttonRemoveWatcher.Text = "Remove";
            this.buttonRemoveWatcher.UseVisualStyleBackColor = true;
            this.buttonRemoveWatcher.Click += new System.EventHandler(this.buttonRemoveWatcher_Click);
            // 
            // buttonSaveWatcher
            // 
            this.buttonSaveWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveWatcher.Location = new System.Drawing.Point(223, 586);
            this.buttonSaveWatcher.Name = "buttonSaveWatcher";
            this.buttonSaveWatcher.Size = new System.Drawing.Size(63, 24);
            this.buttonSaveWatcher.TabIndex = 4;
            this.buttonSaveWatcher.Text = "Save";
            this.buttonSaveWatcher.UseVisualStyleBackColor = true;
            this.buttonSaveWatcher.Click += new System.EventHandler(this.buttonSaveWatcher_Click);
            // 
            // buttonAddWatcher
            // 
            this.buttonAddWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddWatcher.Location = new System.Drawing.Point(3, 586);
            this.buttonAddWatcher.Name = "buttonAddWatcher";
            this.buttonAddWatcher.Size = new System.Drawing.Size(59, 24);
            this.buttonAddWatcher.TabIndex = 2;
            this.buttonAddWatcher.Text = "Add";
            this.buttonAddWatcher.UseVisualStyleBackColor = true;
            this.buttonAddWatcher.Click += new System.EventHandler(this.buttonAddWatcher_Click);
            // 
            // tabControlWatcherDetail
            // 
            this.tabControlWatcherDetail.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlWatcherDetail.Controls.Add(this.tabPageWatcherConfig);
            this.tabControlWatcherDetail.Controls.Add(this.tabPageTriggerConfig);
            this.tabControlWatcherDetail.Controls.Add(this.tabPageActionConfig);
            this.tabControlWatcherDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWatcherDetail.Location = new System.Drawing.Point(0, 0);
            this.tabControlWatcherDetail.Name = "tabControlWatcherDetail";
            this.tabControlWatcherDetail.SelectedIndex = 0;
            this.tabControlWatcherDetail.Size = new System.Drawing.Size(578, 613);
            this.tabControlWatcherDetail.TabIndex = 5;
            // 
            // tabPageWatcherConfig
            // 
            this.tabPageWatcherConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWatcherConfig.Controls.Add(this.propertyGridWatcher);
            this.tabPageWatcherConfig.Location = new System.Drawing.Point(4, 4);
            this.tabPageWatcherConfig.Name = "tabPageWatcherConfig";
            this.tabPageWatcherConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWatcherConfig.Size = new System.Drawing.Size(570, 587);
            this.tabPageWatcherConfig.TabIndex = 2;
            this.tabPageWatcherConfig.Text = "Watcher";
            // 
            // propertyGridWatcher
            // 
            this.propertyGridWatcher.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGridWatcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridWatcher.Location = new System.Drawing.Point(3, 3);
            this.propertyGridWatcher.Name = "propertyGridWatcher";
            this.propertyGridWatcher.Size = new System.Drawing.Size(564, 581);
            this.propertyGridWatcher.TabIndex = 1;
            this.propertyGridWatcher.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridWatcher_PropertyValueChanged);
            // 
            // tabPageTriggerConfig
            // 
            this.tabPageTriggerConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTriggerConfig.Controls.Add(this.propertyGridWatcherTrigger);
            this.tabPageTriggerConfig.Location = new System.Drawing.Point(4, 4);
            this.tabPageTriggerConfig.Name = "tabPageTriggerConfig";
            this.tabPageTriggerConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTriggerConfig.Size = new System.Drawing.Size(570, 587);
            this.tabPageTriggerConfig.TabIndex = 0;
            this.tabPageTriggerConfig.Text = "Trigger";
            // 
            // propertyGridWatcherTrigger
            // 
            this.propertyGridWatcherTrigger.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGridWatcherTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridWatcherTrigger.Location = new System.Drawing.Point(3, 3);
            this.propertyGridWatcherTrigger.Name = "propertyGridWatcherTrigger";
            this.propertyGridWatcherTrigger.Size = new System.Drawing.Size(564, 581);
            this.propertyGridWatcherTrigger.TabIndex = 0;
            this.propertyGridWatcherTrigger.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridWatcherTrigger_PropertyValueChanged);
            // 
            // tabPageActionConfig
            // 
            this.tabPageActionConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageActionConfig.Controls.Add(this.propertyGridWatcherAction);
            this.tabPageActionConfig.Location = new System.Drawing.Point(4, 4);
            this.tabPageActionConfig.Name = "tabPageActionConfig";
            this.tabPageActionConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActionConfig.Size = new System.Drawing.Size(570, 587);
            this.tabPageActionConfig.TabIndex = 1;
            this.tabPageActionConfig.Text = "Action";
            // 
            // propertyGridWatcherAction
            // 
            this.propertyGridWatcherAction.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGridWatcherAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridWatcherAction.Location = new System.Drawing.Point(3, 3);
            this.propertyGridWatcherAction.Name = "propertyGridWatcherAction";
            this.propertyGridWatcherAction.Size = new System.Drawing.Size(564, 581);
            this.propertyGridWatcherAction.TabIndex = 1;
            this.propertyGridWatcherAction.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridWatcherAction_PropertyValueChanged);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartStop.Location = new System.Drawing.Point(3, 27);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(59, 23);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.AutoSize = true;
            this.labelCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentStatus.Location = new System.Drawing.Point(68, 32);
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Size = new System.Drawing.Size(65, 13);
            this.labelCurrentStatus.TabIndex = 4;
            this.labelCurrentStatus.Text = "Not running.";
            // 
            // richTextBoxWatcherOutput
            // 
            this.richTextBoxWatcherOutput.BackColor = System.Drawing.Color.White;
            this.richTextBoxWatcherOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWatcherOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWatcherOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxWatcherOutput.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxWatcherOutput.Name = "richTextBoxWatcherOutput";
            this.richTextBoxWatcherOutput.ReadOnly = true;
            this.richTextBoxWatcherOutput.Size = new System.Drawing.Size(871, 613);
            this.richTextBoxWatcherOutput.TabIndex = 0;
            this.richTextBoxWatcherOutput.Text = "";
            this.richTextBoxWatcherOutput.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageMainConfiguration);
            this.tabControl1.Controls.Add(this.tabPageMainOutput);
            this.tabControl1.Location = new System.Drawing.Point(3, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 645);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageMainConfiguration
            // 
            this.tabPageMainConfiguration.Controls.Add(this.splitContainer1);
            this.tabPageMainConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageMainConfiguration.Name = "tabPageMainConfiguration";
            this.tabPageMainConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainConfiguration.Size = new System.Drawing.Size(877, 619);
            this.tabPageMainConfiguration.TabIndex = 0;
            this.tabPageMainConfiguration.Text = "Configuration";
            this.tabPageMainConfiguration.UseVisualStyleBackColor = true;
            // 
            // tabPageMainOutput
            // 
            this.tabPageMainOutput.Controls.Add(this.richTextBoxWatcherOutput);
            this.tabPageMainOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageMainOutput.Name = "tabPageMainOutput";
            this.tabPageMainOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainOutput.Size = new System.Drawing.Size(877, 619);
            this.tabPageMainOutput.TabIndex = 1;
            this.tabPageMainOutput.Text = "Output";
            this.tabPageMainOutput.UseVisualStyleBackColor = true;
            // 
            // menuStripApplication
            // 
            this.menuStripApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripApplication.Location = new System.Drawing.Point(0, 0);
            this.menuStripApplication.Name = "menuStripApplication";
            this.menuStripApplication.Size = new System.Drawing.Size(891, 24);
            this.menuStripApplication.TabIndex = 6;
            this.menuStripApplication.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 703);
            this.Controls.Add(this.menuStripApplication);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelCurrentStatus);
            this.Controls.Add(this.buttonStartStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripApplication;
            this.Name = "Form1";
            this.Text = "Folder Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlWatcherDetail.ResumeLayout(false);
            this.tabPageWatcherConfig.ResumeLayout(false);
            this.tabPageTriggerConfig.ResumeLayout(false);
            this.tabPageActionConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMainConfiguration.ResumeLayout(false);
            this.tabPageMainOutput.ResumeLayout(false);
            this.menuStripApplication.ResumeLayout(false);
            this.menuStripApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconFolderWatcher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBoxWatchers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRemoveWatcher;
        private System.Windows.Forms.Button buttonAddWatcher;
        private System.Windows.Forms.Button buttonSaveWatcher;
        private System.Windows.Forms.PropertyGrid propertyGridWatcherTrigger;
        private System.Windows.Forms.TabControl tabControlWatcherDetail;
        private System.Windows.Forms.TabPage tabPageTriggerConfig;
        private System.Windows.Forms.TabPage tabPageActionConfig;
        private System.Windows.Forms.PropertyGrid propertyGridWatcherAction;
        private System.Windows.Forms.TabPage tabPageWatcherConfig;
        private System.Windows.Forms.PropertyGrid propertyGridWatcher;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelCurrentStatus;
        private System.Windows.Forms.RichTextBox richTextBoxWatcherOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMainConfiguration;
        private System.Windows.Forms.TabPage tabPageMainOutput;
        private System.Windows.Forms.MenuStrip menuStripApplication;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

