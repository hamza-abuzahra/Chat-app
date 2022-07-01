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
    public partial class Superuser : Form
    {
        public Superuser()
        {
            InitializeComponent();
        }

        private void activebtn_Click(object sender, EventArgs e)
        {
            Login.s.WaitOne();
            Login.send("2");
            string users = Login.recieve();
            Login.s.Release();
            DateTime now = DateTime.Now;
            MessageBox.Show(users, now.ToString(), MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem1 = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Remove(selecteditem1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem2 = comboBox2.SelectedItem.ToString();
            comboBox1.Items.Remove(selecteditem2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string u1 = comboBox1.Text;
            string u2 = comboBox2.Text;
            if (u1 == "Everyone" || u2 == "Everyone")
            {
                u1 = "Everyone";
                u2 = "Everyone";
            }
            else if (u1 == "" || u2 == ""){
                MessageBox.Show("please choose the two employees to see the log");
                return;
            }
            Login.send("6");
            Login.send(u1);
            Login.send(u2);
            Logs logs = new Logs();
            logs.Label1Text = u1;
            logs.Label2Text = u2;
            while (true)
            {
                string msg = Login.recieve();
                if (msg == "END")
                {
                    break;
                }
                string msender = Login.recieve();
                string mreciever = Login.recieve();
                string ms = Login.idnames[Int32.Parse(msender) - 1];
                int index = ms.IndexOf("@");
                if (index >= 0)
                {
                    ms = ms.Substring(0, index);
                }
                logs.appendtextbox = msender + " :  " + ms;
            }
            logs.ShowDialog();
        }
    }
}
