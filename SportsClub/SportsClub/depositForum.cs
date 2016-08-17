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
    public partial class depositForum : Form
    {
        Deposit selectedDeposit;
        String newDepositString = "New...";
        mainForm mf;
        public depositForum(mainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            update_depositCombo();
        }

        private void update_depositCombo()
        {
            string strConnection = App.getConnectionString();
            //here is the SQL statements to retrive the ClubMember information
            string strSQL = "Select * from Deposits";

            //get a datatable with one row which holds the ClubMember data
            DataTable depositsDataTable = App.getGenericData(strSQL);

            //remove current items
            depositComboBox.Items.Clear();
            // add new user selection string
            depositComboBox.Items.Add(newDepositString);
            string[] arr = new String[depositsDataTable.Rows.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = depositsDataTable.Rows[i]["DepositNumber"].ToString();
            }
            depositComboBox.Items.AddRange(arr);
        }

        private void depositComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (depositComboBox.Text == newDepositString)
            {

            }
            else
            {
                selectedDeposit = new Deposit(depositComboBox.Text);
                deposittotal_label.Text = "$ " + selectedDeposit.depositTotal.ToString();
                depositDataGrid.DataSource = selectedDeposit.getTransactions();
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)  //add or remove deposit button
        {
            editDeposits ed = new editDeposits();
            ed.ShowDialog();
            update_depositCombo();
        }



    }
}
