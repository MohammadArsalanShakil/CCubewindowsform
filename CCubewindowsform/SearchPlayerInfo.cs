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
    public partial class SearchPlayerInfo : Form
    {
        public SearchPlayerInfo()
        {
            InitializeComponent();
        }

        private void SearchPlayerInfo_Load(object sender, EventArgs e)
        {
            inputGB.Visible = false;
            optioncb.SelectedIndex = 0;
            this.playerinfortb.Text = MainForm.manager.DisplayAllPlayers();
        }

        private void optioncb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optioncb.SelectedIndex == 0)
            {
                this.playerinfortb.Text = MainForm.manager.DisplayAllPlayers();
            }
            else if (optioncb.SelectedIndex == 1)
            {
                inputGB.Visible = true;
                optionlb.Text = "Enter Name : ";
            }
            else if (optioncb.SelectedIndex == 2)
            {
                inputGB.Visible = true;
                optionlb.Text = "Enter CNIC : ";
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (this.optionlb.Text == "Enter CNIC : " && optiontb.Text != string.Empty)
            {
                this.playerinfortb.Text = MainForm.manager.SearchPlayerInfobyCNIC(optiontb.Text);
                optiontb.Text = "";
            }
            else if (this.optionlb.Text == "Enter Name : " && optiontb.Text != string.Empty)
            {
                this.playerinfortb.Text = MainForm.manager.SearchPlayerInfobyName(optiontb.Text);
                optiontb.Text = "";

            }
        }
    }
}
