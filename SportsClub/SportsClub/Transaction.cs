//March 30, 2012 at 11:32PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace SportsClub
{
    public class Transaction
    {
        int transNo;
        public string type;
        public string semester;
        public string username;
        public DateTime transDate;
        public string depositNumber;
        public string checkNumber;
        public string description;
        public decimal amount;
        public string DBstatus;

        public Transaction()
        {
            //to add a new transaction use the addTransaction of the ClubMember class.
        }

        public Transaction(int transnumber)
        {
            //use this constructor to create a transaction instance
            //that shadows a database row that already exists
            this.transNo = transnumber;
            //here is the SQL statement to retrive the transaction information
            string strSQL = "Select * from Transactions where TransNo = " + this.transNo;

            //get a datatable with one row which holds the ClubMember data
            DataTable MyTransTable = App.getGenericData(strSQL);

            if (MyTransTable.Rows.Count == 0)
            {
                //the transaction was not found
                this.DBstatus = "Not Exists";
            }
            else
            {
                //the transaction was found
                this.DBstatus = "Exists";
                this.type = MyTransTable.Rows[0]["type"].ToString();
                this.semester = MyTransTable.Rows[0]["Semester"].ToString();
                this.username = MyTransTable.Rows[0]["Username"].ToString();
                this.transDate = DateTime.Parse(MyTransTable.Rows[0]["transDate"].ToString());
                this.depositNumber = MyTransTable.Rows[0]["depositNumber"].ToString();
                this.checkNumber = MyTransTable.Rows[0]["checkNumber"].ToString();
                this.description = MyTransTable.Rows[0]["description"].ToString();
                this.amount = Decimal.Parse(MyTransTable.Rows[0]["amount"].ToString());
            }
        }


        public int getTransNo()
        {
            //the PK is the one data member that I have not allowed
            //public access to but I do want someone to be able to read
            //this information so this is the get method for the username
            return this.transNo;
        }

        public void Save()
        {
            //update transaction information
            string strDML = "Update transactions set Type= ?, Semester= ?, username= ?, transDate=?, ";
            if (String.IsNullOrEmpty(this.depositNumber))
            {
                //no deposit number yet so do not try to save one
                Debug.WriteLine("No Depositnumber");
            }
            else
            {
                strDML = strDML + "depositNumber = ?, ";
                Debug.WriteLine("Depositnumber [" + this.depositNumber + "]");
            }
            strDML = strDML + "checknumber =?, description = ?, amount = ?  where TransNo = ?";

            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);
            cmd.Parameters.Add(new OleDbParameter("type", this.type));
            cmd.Parameters.Add(new OleDbParameter("semester", this.semester));
            cmd.Parameters.Add(new OleDbParameter("username", this.username));
            cmd.Parameters.Add(new OleDbParameter("transDate", this.transDate));
            if (String.IsNullOrEmpty(this.depositNumber))
            {
                //no deposit number yet so do not try to save one
            }
            else
            {
                cmd.Parameters.Add(new OleDbParameter("depositNumber", this.depositNumber));
            }
            cmd.Parameters.Add(new OleDbParameter("checkNumber", this.checkNumber));
            cmd.Parameters.Add(new OleDbParameter("description", this.description));
            cmd.Parameters.Add(new OleDbParameter("amount", this.amount));
            cmd.Parameters.Add(new OleDbParameter("transNo", this.transNo));

            Debug.WriteLine(strDML);
            string message = App.runDML(cmd);
            if (message == "Success")
            {
                this.DBstatus = "Existing";
                Debug.WriteLine("Successful Transaction Save");
            }
            else
            {
                this.DBstatus = "Error";
                Debug.WriteLine("Failure on Transaction Save");
            }
        }


        public void Delete()
        {
            //delete the transaction
            string strDML = "Delete from Transactions where TransNo = " + transNo;

            string message = App.runDML(strDML);
            if (message == "Success")
            {
                this.DBstatus = "Not Exists";
            }
            else
            {
                this.DBstatus = "Exists";
            }
        }

    }
}