using System.Windows.Forms;

namespace XPControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Input.InitializeAsync();
        }
    }
}