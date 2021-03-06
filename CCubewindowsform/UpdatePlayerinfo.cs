using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCubewindowsform
{
    public partial class UpdatePlayerinfo : Form
    {
        public UpdatePlayerinfo()
        {
            InitializeComponent();
        }

        private void optioncb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optioncb.SelectedIndex == 0)
            {
                optionlb.Text = "Cnic : ";
            }
            else if (optioncb.SelectedIndex == 1)
            {
                optionlb.Text = "Name : ";
            }
        }

        private void deleteplayerbtn_Click(object sender, EventArgs e)
        {
            if (optioncb.SelectedIndex == 0)
            {
                MainForm.manager.EditPlayerInfobyCNIC(true, optiontb.Text, cnictb.Text, nametb.Text);
                nametb.Text = "";
                cnictb.Text = "";
                optiontb.Text = "";
                optionlb.Text = "";
                optioncb.SelectedIndex = -1;
            }
            else if (optioncb.SelectedIndex == 1)
            {
                MainForm.manager.EditPlayerInfobyName(true, optiontb.Text, cnictb.Text, nametb.Text);
                nametb.Text = "";
                cnictb.Text = "";
                optiontb.Text = "";
                optionlb.Text = "";
                optioncb.SelectedIndex = -1;
            }
        }
    }
}
