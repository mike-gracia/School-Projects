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
    public partial class addTransForm : Form
    {
        public mainForm mf;
        
        public addTransForm( mainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            
        }

        private void button4_Click(object sender, EventArgs e)  //add trans forum cancel button
        {
            
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaction currentTransaction = new Transaction();
            currentTransaction.type = typeTrans_comboBox.Text;
            currentTransaction.semester = semester_comboBox.Text;
            currentTransaction.username = mf.target.getUsername();
            currentTransaction.transDate = DateTime.Today;
            //fix for no deposit number
            if (depositeNum_textbox.Text == String.Empty)
            {  }
            else
                currentTransaction.depositNumber = depositeNum_textbox.Text;
            

            currentTransaction.checkNumber = checkNumb_textBox.Text;
            currentTransaction.description = description_textbox.Text;
            currentTransaction.amount = decimal.Parse(amount_textbox.Text);

            currentTransaction.Save();
            //mf.target.addTransaction(currentTransaction);
            mf.update_trans();
            DialogResult = DialogResult.OK;
            
           
        }
    }
}
