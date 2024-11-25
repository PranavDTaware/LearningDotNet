using Membership;
using Warehouse;

namespace Warehouse1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent(); // code is written in seperate designer.cs file

            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        private void OnToolsSignIn(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }
    }
}
