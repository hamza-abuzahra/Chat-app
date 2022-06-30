﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ClientGUI
{
    public partial class Main : Form
    {
        public Socket clientSk;
        public Main()
        {
            InitializeComponent();
        }

        private void Generalbtn_Click(object sender, EventArgs e)
        {
            currentchatlbl.Text = "To Everyone";
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
            Login.sendMsg("2");
            string users = Login.getMsg();
            DateTime now = DateTime.Now;
            MessageBox.Show(users, now.ToString(), MessageBoxButtons.OK);

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            //Login.sendMsg("3");
            string msg = msgtxtbx.Text + "\r\n";
            //Login.sendMsg(msg);
            chattxtbx.AppendText(msg);
            //chatlstbx.Items[chatlstbx.Items.Count].BackColor = 
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
