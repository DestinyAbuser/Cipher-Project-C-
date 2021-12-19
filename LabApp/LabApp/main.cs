using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labapp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void PracticB_Click(object sender, EventArgs e)
        {
            this.Hide();
            prmain open = new prmain();
            open.Show();
        }

        private void Exit1B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void TheoryB_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    thmain open = new thmain();
        //    open.Show();
        //}
        private void ExitToMainPanel_Click(object sender, EventArgs e)
        {
            this.MainPanel.Show();
        }

        private void TheoryB_Click(object sender, EventArgs e)
        {

        }
    }
}
