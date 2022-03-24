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
    public partial class _1PersonGame : Form
    {
        public _1PersonGame()
        {
            InitializeComponent();
        }

        private void startgamebtn_Click(object sender, EventArgs e)
        {
            MainForm.manager.StartGamefor1(p1cnictb.Text, p1cnictb.Text);
            MessageBox.Show("Your game will begin shortly");
        }
    }
}
