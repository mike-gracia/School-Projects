using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsClub
{
    public partial class editDeposits : Form
    {
        Deposit d;
        String selected;
        public editDeposits()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void add_radio_CheckedChanged(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            selected = "add";
        }

        private void remove_radio_CheckedChanged(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            selected = "remove";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (selected == "add")
                d = new Deposit(textBox1.Text);
            else
            {
                d = new Deposit(textBox1.Text);
                d.Delete();
                MessageBox.Show("Success", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
