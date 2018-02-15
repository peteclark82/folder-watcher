namespace FolderWatcher.Win
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.checkBoxLaunchOnWindowsStart = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxAutoStartWatchers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxLaunchOnWindowsStart
            // 
            this.checkBoxLaunchOnWindowsStart.AutoSize = true;
            this.checkBoxLaunchOnWindowsStart.Location = new System.Drawing.Point(12, 12);
            this.checkBoxLaunchOnWindowsStart.Name = "checkBoxLaunchOnWindowsStart";
            this.checkBoxLaunchOnWindowsStart.Size = new System.Drawing.Size(213, 17);
            this.checkBoxLaunchOnWindowsStart.TabIndex = 0;
            this.checkBoxLaunchOnWindowsStart.Text = "Launch application on windows start up";
            this.checkBoxLaunchOnWindowsStart.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(237, 206);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(64, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(167, 206);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(64, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxAutoStartWatchers
            // 
            this.checkBoxAutoStartWatchers.AutoSize = true;
            this.checkBoxAutoStartWatchers.Location = new System.Drawing.Point(12, 35);
            this.checkBoxAutoStartWatchers.Name = "checkBoxAutoStartWatchers";
            this.checkBoxAutoStartWatchers.Size = new System.Drawing.Size(117, 17);
            this.checkBoxAutoStartWatchers.TabIndex = 3;
            this.checkBoxAutoStartWatchers.Text = "Auto start watchers";
            this.checkBoxAutoStartWatchers.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 241);
            this.Controls.Add(this.checkBoxAutoStartWatchers);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBoxLaunchOnWindowsStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLaunchOnWindowsStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxAutoStartWatchers;
    }
}