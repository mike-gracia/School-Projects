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
    public partial class delTransForm : Form
    {
        mainForm mf;

        public delTransForm(mainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
        }

        private void button1_Click(object sender, EventArgs e)  //OK
        {
            mf.target.removeTransaction(int.Parse(textBox1.Text));
            mf.update_trans();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
