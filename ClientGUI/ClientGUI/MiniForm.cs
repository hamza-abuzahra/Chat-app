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
    public partial class MiniForm : Form
    {
        String selected;
        public MiniForm()
        {
            InitializeComponent();
            foreach (string item in Nameslb.Items)
            {
                if (item.Contains(Login.currentuser))
                {
                    Nameslb.Items.Remove(item);
                    break;
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = Nameslb.GetItemText(Nameslb.SelectedItem);
            this.Close();
        }
        public string getSelected()
        {
            return selected;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            selected = "";
            this.Close();
        }

        private void Nameslb_SelectedValueChanged(object sender, EventArgs e)
        {
            Selectbtn.Enabled = true;
        }

    }
}
