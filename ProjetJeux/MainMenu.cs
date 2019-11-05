using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetJeux
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableButtons()
        {
            BtnStart.Enabled = BtnLoad.Enabled = BtnExit.Enabled = BtnStart.Visible = BtnLoad.Visible = BtnExit.Visible = false;
        }
        private void DisableButtons()
        {
            BtnStart.Enabled = BtnLoad.Enabled = BtnExit.Enabled = BtnStart.Visible = BtnLoad.Visible = BtnExit.Visible = true;
        }
    }
}
