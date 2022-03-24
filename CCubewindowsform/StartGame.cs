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
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2PersonGame personGame = new _2PersonGame();
            personGame.Show();
        }

        private void startgame1btn_Click(object sender, EventArgs e)
        {
            _1PersonGame person1game = new _1PersonGame();
            person1game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}