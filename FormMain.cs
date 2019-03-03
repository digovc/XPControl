using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace XPControl
{
    public partial class FormMain : Form
    {
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

        private void LoadConfiguration()
        {
            this.txtAddress.Text = ConfigurationManager.AppSettings["Address"];
            this.txtPort.Text = ConfigurationManager.AppSettings["Port"];
            this.tkbHeading.Value = (int)(Convert.ToDouble(ConfigurationManager.AppSettings["Heading"]) * 100);
            this.tkbRoll.Value = (int)(Convert.ToDouble(ConfigurationManager.AppSettings["Roll"]) * 100);
            this.tkbPitch.Value = (int)(Convert.ToDouble(ConfigurationManager.AppSettings["Pitch"]) * 100);
        }

        private void SaveConfiguration()
        {
            ConfigurationManager.AppSettings["Address"] = this.txtAddress.Text;
        }
    }
}