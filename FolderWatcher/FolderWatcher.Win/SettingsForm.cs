using System;
using System.Windows.Forms;
using System.Xml.XPath;
using FolderWatcher.Core;

namespace FolderWatcher.Win
{
    public partial class SettingsForm : Form
    {
        #region Private Variables 
        private readonly AppConfig _config;
        #endregion

        private SettingsForm(AppConfig config)
        {
            InitializeComponent();
            _config = config;
        }

        #region Form Events
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxLaunchOnWindowsStart.Checked = _config.LaunchOnWindowsStartUp;
            checkBoxAutoStartWatchers.Checked = _config.AutoStartWatchers;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        #endregion

        #region Public Static Methods
        public static AppConfig Create(Form parentForm, AppConfig config)
        {
            var form = new SettingsForm(config);
            var result = form.ShowDialog(parentForm);
            if (result == DialogResult.OK)
            {
                config = form.GetConfig();
            }
            return config;
        }
        #endregion

        #region Private Functions
        private AppConfig GetConfig()
        {
            if (checkBoxLaunchOnWindowsStart.Checked)
            {
                _config.ActivateLaunchOnWindowsStartUp(Application.ExecutablePath);
            }
            else
            {
                _config.DeactivateLaunchOnWindowsStartUp();
            }
            _config.AutoStartWatchers = checkBoxAutoStartWatchers.Checked;
            return _config;
        }
        #endregion
    }
}
