using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Craps
{
    public partial class WagerDialog : Form
    {
        public WagerDialog()
        {
            InitializeComponent();
        }

        public static int dWager;

        private void WagerDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permit only digit entries
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {

            window_Main dataStuff = new window_Main();

            //Validate input
            if (Tb_WagerBox.Text == "" || Tb_WagerBox.Text == null)
            {
                MessageBox.Show("Wager cannot be empty.");
            }
            else
            {
                dWager = int.Parse(Tb_WagerBox.Text);
                this.Close();
            }
        }

        private void WagerDialog_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Tb_WagerBox;
        }
    }
}
