using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userName = nameTextBox.Text;
            String passwd = passwdTextBox.Text;
            if(userName == "" || passwd == "")
            {
                MessageBox.Show("A box can not be empty");
            }
            else if (passwd.Equals("hello") == false)
            {
                MessageBox.Show("Wrong password");
            }
            else
            {
                Form2 form2 = new Form2(userName);
                form2.Show();
                this.Hide();
            }
        }
    }
}
