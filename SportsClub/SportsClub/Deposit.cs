// March 24, 2012 at 12:58AM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace SportsClub
{
    class Deposit
    {
        string depositNumber;
        public DateTime depositDate;
        public Int16 depositCheckCount;
        public Decimal depositTotal;
        public string DBstatus;

        public Deposit(string strDepositNumber)
        {
            //set the Deposit Number of the new Deposit to what was passed in to the constructor
            this.depositNumber = strDepositNumber;

            //here is the SQL statement to retrieve the deposit information
            string strSQL = "Select * from Deposits where depositNumber = '" + this.depositNumber + "'";

            //get a datatable with one row which holds the deposit info
            DataTable MyDepositTable = App.getGenericData(strSQL);

            if (MyDepositTable.Rows.Count == 0)
            {
                //this is a new deposit
                Debug.WriteLine("Creating New Deposit");
                this.depositTotal = 0;
                this.depositDate = DateTime.Today;
                //insert the new deposit
                string strDML = "Insert Into Deposits(depositNumber, depositDate) Values(?,?)";
                //string strDML = "Insert Into Deposits(depositNumber) Values(?)";
                //Create a DML command  with parameters for each of the question marks above
                OleDbCommand cmd = new OleDbCommand(strDML);
                cmd.Parameters.Add(new OleDbParameter("depositNumber", this.depositNumber));
                cmd.Parameters.Add(new OleDbParameter("depositDate", this.depositDate));

                string message = App.runDML(cmd);
                if (message == "Success")
                {
                    this.DBstatus = "Existing";
                    Debug.WriteLine("Successful Deposit Creation");
                }
                else
                {
                    this.DBstatus = "Error";
                    Debug.WriteLine("Deposit Creation Failure");
                }

                this.AdoptUndepositedChecks();

            }
            else
            {
                //load the instance values from the returned data
                this.DBstatus = "Existing";
                this.depositDate = DateTime.Parse(MyDepositTable.Rows[0]["depositDate"].ToString());
            }
            this.ComputeTotal();
        }

        public string getDepositNumber()
        {
            //the PK is the one data member that I have not allowed
            //public access to but I do want someone to be able to read
            //this information so this is the get method for the username
            return this.depositNumber;
        }

        public void Save()
        {
            //update deposit information
            string strDML = "Update Deposits set DepositDate= ? where DepositNumber = ?";
            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);
            cmd.Parameters.Add(new OleDbParameter("depositDate", this.depositDate));
            cmd.Parameters.Add(new OleDbParameter("depositNumber", this.depositNumber));

            string message = App.runDML(cmd);
            if (message == "Success")
            {
                this.DBstatus = "Existing";
            }
            else
            {
                this.DBstatus = "Error";
            }
        }

        public void Delete()
        {
            //delete the deposit
            string strDML = "Delete from Deposits where DepositNumber = ?";
            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);
            cmd.Parameters.Add(new OleDbParameter("depositNumber", this.depositNumber));

            string message = App.runDML(cmd);
            if (message == "Success")
            {
                this.DBstatus = "Deleted";
            }
            else
            {
                this.DBstatus = "Existing";
            }
        }

        public void AdoptUndepositedChecks()
        {
            //associate all undeposited payments with this deposit
            Debug.WriteLine("Adopting Checks");
            string strDML = "Update Transactions set DepositNumber = ? where type='Payment' and DepositNumber is Null ";
            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd2 = new OleDbCommand(strDML);
            Debug.WriteLine(this.depositNumber);
            cmd2.Parameters.Add(new OleDbParameter("depositNumber", this.depositNumber));
            string message2 = App.runDML(cmd2);
            Debug.WriteLine(message2);
        }

        public void ComputeTotal()
        {
            Debug.WriteLine("Computing Deposit Total");
            string strSQL = "Select sum(amount) as total from Transactions where depositNumber = '" + this.depositNumber + "'";
            DataTable MyTransTotal = App.getGenericData(strSQL);
            this.depositTotal = App.MyDecParse(MyTransTotal.Rows[0]["total"].ToString());
        }

        public DataTable getTransactions()
        {
            string strSQL = "Select * from Transactions where depositNumber = '" + this.depositNumber + "'";
            DataTable MyTransTable = App.getGenericData(strSQL);
            return MyTransTable;
        }
    }
}