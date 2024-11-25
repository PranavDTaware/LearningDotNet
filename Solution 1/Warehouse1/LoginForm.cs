using Membership;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Event Handlers

        //Developer should focus more on Handling events with the help of Event handlers

        private void OnSignIn(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status = false;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                //MessageBox.Show("Welcome to WareHouse App");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User, please try again");
            }
        }

    }
}
