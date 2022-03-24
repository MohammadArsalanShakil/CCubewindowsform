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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            string cnic = this.cnicTB.Text;
            string name = this.nametb.Text;
            MainForm.manager.RegisterNewPlayer(new Player(cnic, name));
            MessageBox.Show("Player has been registered");
            this.cnicTB.Text = "";
            this.nametb.Text = "";
        }
    }
}
