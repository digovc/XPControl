using System;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace XPControl
{
    public partial class FormMain : Form
    {
        private readonly CultureInfo _cultureInfo = CultureInfo.GetCultureInfo("en-US");

        public FormMain()
        {
            InitializeComponent();

            Input.InitializeAsync();
            XPlane.InitializeAsync();

            LoadConfiguration();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            SaveConfiguration();
        }

        private double GetDoubleConfiguration(string name)
        {
            var value = ConfigurationManager.AppSettings[name];

            return Convert.ToDouble(value, _cultureInfo);
        }

        private void LoadConfiguration()
        {
            this.txtAddress.Text = ConfigurationManager.AppSettings["Address"];
            this.txtPort.Text = ConfigurationManager.AppSettings["Port"];
            this.tkbHeading.Value = (int)(GetDoubleConfiguration("Heading") * 100);
            this.tkbRoll.Value = (int)(GetDoubleConfiguration("Roll") * 100);
            this.tkbPitch.Value = (int)(GetDoubleConfiguration("Pitch") * 100);
        }

        private void SaveConfiguration()
        {
            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            SetConfig(config, "Address", this.txtAddress.Text);
            SetConfig(config, "Port", this.txtPort.Text);
            SetConfig(config, "Heading", ((double)this.tkbHeading.Value / 100).ToString(_cultureInfo));
            SetConfig(config, "Roll", ((double)this.tkbRoll.Value / 100).ToString(_cultureInfo));
            SetConfig(config, "Pitch", ((double)this.tkbPitch.Value / 100).ToString(_cultureInfo));

            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SetConfig(Configuration config, string name, string value)
        {
            config.AppSettings.Settings.Remove(name);
            config.AppSettings.Settings.Add(name, value);
        }
    }
}