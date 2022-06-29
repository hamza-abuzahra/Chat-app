using System;
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
    }
}
