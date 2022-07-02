using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ClientGUI
{
    public partial class Main : Form
    {
        public string[] users;
        public Main()
        {
            InitializeComponent();
            this.Text = Login.currentuser;
        }
        public void updateChat()
        {
            while (true)
            {
                if (Login.flag)
                {
                    break;
                }
                string sender = currentchatlbl.Text;
                if (sender != "")
                {
                    Login.s.WaitOne();
                    if (Login.flag)
                    {
                        break;
                    }
                    Login.send("4");
                    Login.send(sender);
                    Login.send(Login.currentuser);
                    chattxtbx.Invoke(new Action ( ()=> chattxtbx.Text = ""));
                    while (true)
                    {
                        string msg = Login.recieve();
                        if (msg == "END")
                        {
                            break;
                        }
                        string msender = Login.recieve();
                        string mreciever = Login.recieve();
                        string ms = Login.idnames[Int32.Parse(msender)-1];
                        if (ms == Login.currentuser){
                            ms = "You";
                        }
                        else {
                            int index = ms.IndexOf("@");
                            if (index >= 0)
                            {
                                ms = ms.Substring(0, index);
                            }

                        }
                        chattxtbx.Invoke(new Action(() => chattxtbx.AppendText(ms +" :  " + msg + "\r\n")));
                    }
                    Login.s.Release();
                }
                else
                {
                    Console.WriteLine("select a reciever");
                }
                Thread.Sleep(2000);
            }
        }

        private void Generalbtn_Click(object sender, EventArgs e)
        {
            currentchatlbl.Text = "Everyone";
        }

        private void Directbtn_Click(object sender, EventArgs e)
        {
            MiniForm miniForm = new MiniForm();
            miniForm.ShowDialog();
            String name = miniForm.getSelected();
            if (name != "")
                currentchatlbl.Text = name;
            
        }
        
        private void activebtn_Click(object sender, EventArgs e)
        {
            Login.s.WaitOne();
            Login.send("2");
            string users = Login.recieve();
            Console.WriteLine(users);
            Login.s.Release();
            DateTime now = DateTime.Now;
            MessageBox.Show(users, now.ToString(), MessageBoxButtons.OK);
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Login.s.WaitOne();
            string msg = msgtxtbx.Text;
            string receiver = currentchatlbl.Text;
            Login.send("3");
            Login.send(msg);
            Login.send(receiver);
            Login.send(Login.currentuser);
            Login.s.Release();
            chattxtbx.AppendText("You :  " + msg + "\r\n"); 
            msgtxtbx.Text = "";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Login.handleClosing();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
