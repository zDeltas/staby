using System.IO;
using System.Windows.Forms;

namespace Staby
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            try
            {
                string html = File.ReadAllText("help-staby.html");
                webBrowser.DocumentText = html;
            }
            catch
            {
                webBrowser.Visible = false;
                label1.Visible = true;
            }
        }
    }
}
