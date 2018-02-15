using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FolderWatcher.Core;
using Microsoft.Win32;

namespace FolderWatcher.Win
{
    public partial class Form1 : Form
    {
        private const string ConfigFilename = "folderWatchConfig.xml";
        private readonly ConfigManager _configManager;
        private AppConfig _config;

        private Watcher _activeWatcher;
        private bool _isRunning;
        private bool _isListBoxLocked;
        private bool _hasUserUpdatedWatcher;
        private readonly LogManager _logger;

        public Form1()
        {
            InitializeComponent();

            var configFullFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), ConfigFilename);
            _configManager = new ConfigManager(configFullFilename);
            _config = _configManager.Load() ?? new AppConfig();

            var logger = new SimpleLogger();
            logger.DebugReceived += (source, message) => WriteToLog("DEBUG", source, message, Color.DimGray); 
            logger.InfoReceived += (source, message) => WriteToLog("INFO", source, message, Color.DarkBlue); 
            logger.ErrorReceived += (source, message) => WriteToLog("ERROR", source, message, Color.DarkRed, fontStyle : FontStyle.Italic | FontStyle.Bold);                
            LogManager.SetLogger(logger);

            _logger = LogManager.Create("MainForm");
        }

        #region Form Events
        private void Form1_Load(object sender, EventArgs e)
        {           
            UpdateCheckedListBox();
            if (_config.AutoStartWatchers)
            {
                StartWatchers();
                tabControl1.SelectTab(tabPageMainOutput);
            }         
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIconFolderWatcher_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void checkedListBoxWatchers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _activeWatcher = checkedListBoxWatchers.SelectedItem as Watcher;
                     
            if (_activeWatcher != null)
            {
                if (_hasUserUpdatedWatcher)
                {                    
                    _hasUserUpdatedWatcher = false;
                }
                if (propertyGridWatcher.SelectedObject != _activeWatcher) { propertyGridWatcher.SelectedObject = _activeWatcher; }
                if (propertyGridWatcherTrigger.SelectedObject != _activeWatcher.Trigger) { propertyGridWatcherTrigger.SelectedObject = _activeWatcher.Trigger; }
                if (propertyGridWatcherAction.SelectedObject != _activeWatcher.Action) { propertyGridWatcherAction.SelectedObject = _activeWatcher.Action; }
            }
            else
            {
                propertyGridWatcher.SelectedObject = null;
                propertyGridWatcherTrigger.SelectedObject = null;
                propertyGridWatcherAction.SelectedObject = null;
            }
        }

        private void checkedListBoxWatchers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isListBoxLocked)
            {
                e.NewValue = e.CurrentValue;
            }
            else
            {
                var watcher = checkedListBoxWatchers.Items[e.Index] as Watcher;
                watcher.Active = e.NewValue == CheckState.Checked;
            }
        }

        private void buttonAddWatcher_Click(object sender, EventArgs e)
        {
            _config.Watchers.Add(new Watcher
            {
                Title = "New Watcher",
                Trigger = new FileSystemChangedTrigger(),
                Action = new RunBatchFileAction(),
                Active = false
            });

            UpdateCheckedListBox();
        }

        private void buttonRemoveWatcher_Click(object sender, EventArgs e)
        {
            var selectedWatcher = checkedListBoxWatchers.SelectedItem as Watcher;
            var result = MessageBox.Show(string.Format("Are you sure you want to delete the watcher '{0}'?", selectedWatcher.Title), "Delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _config.Watchers.Remove(selectedWatcher);

                UpdateCheckedListBox();
            }
        }

        private void buttonSaveWatcher_Click(object sender, EventArgs e)
        {
            _configManager.Save(_config);
            _logger.Info("Your configuration has been saved!");
            MessageBox.Show("Your configuration has been saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                //Stop it
                StopWatchers();
            } else
            {
                //Start it
                StartWatchers();
            }
        }

        private void propertyGridWatcher_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _hasUserUpdatedWatcher = true;
        }

        private void propertyGridWatcherTrigger_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _hasUserUpdatedWatcher = true;
        }

        private void propertyGridWatcherAction_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _hasUserUpdatedWatcher = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _config = SettingsForm.Create(this, _config);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _config = SettingsForm.Create(this, _config);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Private Methods

        private void StartWatchers()
        {
            _isRunning = true;
            _isListBoxLocked = true;
            labelCurrentStatus.Text = "Running...";
            buttonStartStop.Text = "Stop";

            propertyGridWatcher.Enabled = false;
            propertyGridWatcherTrigger.Enabled = false;
            propertyGridWatcherAction.Enabled = false;
            buttonAddWatcher.Enabled = false;
            buttonRemoveWatcher.Enabled = false;
            buttonSaveWatcher.Enabled = false;

            foreach (var watcher in _config.Watchers)
            {
                watcher.Start();
            }
        }

        private void StopWatchers()
        {
            _isRunning = false;
            _isListBoxLocked = false; 
            labelCurrentStatus.Text = "Not running.";
            buttonStartStop.Text = "Start";

            propertyGridWatcher.Enabled = true;
            propertyGridWatcherTrigger.Enabled = true;
            propertyGridWatcherAction.Enabled = true;
            buttonAddWatcher.Enabled = true;
            buttonRemoveWatcher.Enabled = true;
            buttonSaveWatcher.Enabled = true;

            foreach (var watcher in _config.Watchers)
            {
                watcher.Stop();
            }
        }

        private void UpdateCheckedListBox()
        {
            checkedListBoxWatchers.DataSource = null;
            checkedListBoxWatchers.DataSource = _config.Watchers;
            checkedListBoxWatchers.DisplayMember = "Title";

            var oldListBoxLocked = _isListBoxLocked;
            _isListBoxLocked = false;
            for (var i = 0; i < checkedListBoxWatchers.Items.Count; i++)
            {
                var item = (Watcher)checkedListBoxWatchers.Items[i];
                checkedListBoxWatchers.SetItemChecked(i, item.Active);
            }
            _isListBoxLocked = oldListBoxLocked;
        }

        private void WriteToLog(string logType, string source, string message, Color textColor, FontStyle fontStyle = FontStyle.Regular)
        {
            Invoke((Action)(() =>
            {
                richTextBoxWatcherOutput.SelectionStart = richTextBoxWatcherOutput.TextLength;
                richTextBoxWatcherOutput.SelectionLength = 0;
                richTextBoxWatcherOutput.SelectionColor = textColor;
                var oldFont = richTextBoxWatcherOutput.SelectionFont;
                richTextBoxWatcherOutput.SelectionFont = new Font(oldFont, fontStyle);
                richTextBoxWatcherOutput.AppendText(string.Format("{0} [{1}] <{2}> {3}\n", DateTime.Now.ToString("HH:mm:ss"), source, logType, message));
                richTextBoxWatcherOutput.SelectionFont = oldFont;
            }));            
        }

        #endregion
    }
}
