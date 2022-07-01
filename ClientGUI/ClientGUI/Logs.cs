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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        public string appendtextbox
        {
            set { textBox1.AppendText(value); }
        }
        public string Label1Text
        {
            set { label1.Text = value; }
        }
        public string Label2Text
        {
            set { label2.Text = value; }  
        }
    }
}
