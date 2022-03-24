using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgrammingLogic;

namespace CCubewindowsform
{
    public partial class MainForm : Form
    {
        public static Manager manager = new Manager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void registerplayerbtn_Click(object sender, EventArgs e)
        {
            RegisterForm rpf = new RegisterForm();
            //this.Hide();
            rpf.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Are yo usure you want to close?", "Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void searchplayerbtn_Click(object sender, EventArgs e)
        {
            SearchPlayerInfo spi = new SearchPlayerInfo();
            spi.Show();
        }

        private void updateplayerbtn_Click(object sender, EventArgs e)
        {
            UpdatePlayerinfo upi = new UpdatePlayerinfo();
            upi.Show();
        }

        private void deleteplayerbtn_Click(object sender, EventArgs e)
        {
            DeletePlayerInfo dpi = new DeletePlayerInfo();
            dpi.Show();
        }

        private void gamebtn_Click(object sender, EventArgs e)
        {
            StartGame game = new StartGame();
            game.Show();
        }
    }
}
