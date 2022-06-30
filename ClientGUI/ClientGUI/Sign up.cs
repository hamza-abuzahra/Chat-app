using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string username = this.untxtbx.Text;
            string password = this.passtxtbx.Text;
            string confirmpass = this.confirmpasstxtbx.Text;
            if (confirmpass != password)
            {
                MessageBox.Show("Password has to be entered twice!");
                
            }
            else {
                Login.sendMsg("0");
                Login.sendMsg(username);
                Login.sendMsg(password);
                string response = Login.getMsg();
                Console.WriteLine(response);

                if (response == "you are in")
                {
                    MessageBox.Show("you are registerd succefully");
                }
                else
                {
                    MessageBox.Show("Only employees inside the company can register");
                }
                this.Close();
            }
            
        }
    }
}
