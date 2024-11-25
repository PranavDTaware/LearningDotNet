using Membership;

namespace Warehouse1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent(); // code is written in seperate designer.cs file
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnSignIn(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status = false;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                MessageBox.Show("Welcome to WareHouse App");
            }
            else
            {
                MessageBox.Show("Invalid User, please try again");
            }
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
    }
}
