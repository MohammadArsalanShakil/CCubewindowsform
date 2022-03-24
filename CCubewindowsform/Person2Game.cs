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
    public partial class _2PersonGame : Form
    {
        public _2PersonGame()
        {
            InitializeComponent();
        }

        private void startgamebtn_Click(object sender, EventArgs e)
        {
            bool wait = MainForm.manager.StartGamefor2(p1cnictb.Text, p1nametb.Text, p2cnictb.Text, p2nametb.Text);
            if (wait)
                MessageBox.Show("Game Started");
            else
                MessageBox.Show("Wait for your turn as table are not free");
            this.Close();
        }
    }
}
