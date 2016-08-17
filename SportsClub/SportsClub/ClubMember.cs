//April 3, 2012 at 9:39 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace SportsClub
{
    public class ClubMember
    {
        string username;
        public string firstName;
        public string lastName;
        public string nickName;
        public string homePhone;
        public string cellPhone;
        public string email;
        public string emergencyContact1;
        public string emergencyContact1Relation;
        public string emergencyContact1Phone;
        public string emergencyContact2;
        public string emergencyContact2Relation;
        public string emergencyContact2Phone;
        public string addressLine1;
        public string addressLine2;
        public string city;
        public string state;
        public string zip;
        public string insuranceCompanyName;
        public string insurancePolicyNumber;
        public string insuranceGroupNumber;
        public DateTime dateOfBirth;
        public string status;
        public decimal balanceDue;
        public DataTable transactions;
        public string DBstatus;

        //there are several static methods in the App class used 
        //for application level settings and drop down list data
        //the database connection string is one of those settings.
        string strConnection = App.getConnectionString();

        public ClubMember(string strUsername)
        {
            //set the ClubMember username of the new ClubMember to what was passed in to the constructor
            this.username = strUsername;

            //get the transactions for this clubmember
            this.getTransactions();

            //here is the SQL statements to retrive the ClubMember information
            string strSQL = "Select * from ClubMembers where username = '" + this.username + "'";

            //get a datatable with one row which holds the ClubMember data
            DataTable MyClubMemberTable = App.getGenericData(strSQL);

            if (MyClubMemberTable.Rows.Count == 0)
            {
                //the ClubMember was not found in the database
                //insert a new row into the database
                Debug.WriteLine("no row");
                string DML = "Insert Into ClubMembers(username) Values('" + this.username + "')";
                string message = App.runDML(DML);
                if (message == "Success")
                {
                    this.DBstatus = "existing";
                }
                else
                {
                    this.DBstatus = "Error";
                }
            }
            else
            {
                Debug.WriteLine("row");
                //the ClubMember was found in the database so populate the
                //data members of the ClubMember instance with the data from the database
                this.DBstatus = "existing";
                this.lastName = MyClubMemberTable.Rows[0]["lastName"].ToString();
                this.firstName = MyClubMemberTable.Rows[0]["firstName"].ToString();
                this.nickName = MyClubMemberTable.Rows[0]["nickName"].ToString();
                this.homePhone = MyClubMemberTable.Rows[0]["homePhone"].ToString();
                this.cellPhone = MyClubMemberTable.Rows[0]["cellPhone"].ToString();
                this.email = MyClubMemberTable.Rows[0]["email"].ToString();
                this.emergencyContact1 = MyClubMemberTable.Rows[0]["emergencyContact1"].ToString();
                this.emergencyContact1Relation = MyClubMemberTable.Rows[0]["emergencyContact1Relation"].ToString();
                this.emergencyContact1Phone = MyClubMemberTable.Rows[0]["emergencyContact1Phone"].ToString();
                this.emergencyContact2 = MyClubMemberTable.Rows[0]["emergencyContact2"].ToString();
                this.emergencyContact2Relation = MyClubMemberTable.Rows[0]["emergencyContact2Relation"].ToString();
                this.emergencyContact2Phone = MyClubMemberTable.Rows[0]["emergencyContact2Phone"].ToString();
                this.addressLine1 = MyClubMemberTable.Rows[0]["addressLine1"].ToString();
                this.addressLine2 = MyClubMemberTable.Rows[0]["addressLine2"].ToString();
                this.city = MyClubMemberTable.Rows[0]["city"].ToString();
                this.state = MyClubMemberTable.Rows[0]["state"].ToString();
                this.zip = MyClubMemberTable.Rows[0]["zip"].ToString();
                this.insuranceCompanyName = MyClubMemberTable.Rows[0]["insuranceCompanyName"].ToString();
                this.insurancePolicyNumber = MyClubMemberTable.Rows[0]["insurancePolicyNumber"].ToString();
                this.insuranceGroupNumber = MyClubMemberTable.Rows[0]["insuranceGroupNumber"].ToString();
                this.status = MyClubMemberTable.Rows[0]["status"].ToString();
                if (String.IsNullOrEmpty(MyClubMemberTable.Rows[0]["dateOfBirth"].ToString()))
                {
                    //no birthday in database so ignor this field
                }
                else
                {
                    this.dateOfBirth = DateTime.Parse(MyClubMemberTable.Rows[0]["dateOfBirth"].ToString());
                }
            }
        }

        public string getUsername()
        {
            //the PK is the one data member that I have not allowed
            //public access to but I do want someone to be able to read
            //this information so this is the get method for the username
            return this.username;
        }

        public void setUsername(string newUsername)
        {
            this.username = newUsername;
        }

        public string Save()
        {
            //this method causes the ClubMember object to update the database for changes,
            //I use a parameterized command to illustrate that method
            //which avoids string concatenation and thus less exposed to SQL injection attacks
            //note that this does not flush the transactions table since those will have been already saved
            //through other actions

            string strDML;
            strDML = "Update ClubMembers set firstName = ?, lastName = ?, nickName = ?, ";
            strDML += "homePhone = ?, cellPhone = ?, email = ?, ";
            strDML += "emergencyContact1 = ?, emergencyContact1Relation = ?, emergencyContact1Phone = ?, ";
            strDML += "emergencyContact2 = ?, emergencyContact2Relation = ?, emergencyContact2Phone = ?, ";
            strDML += "addressLine1 = ?, addressline2 = ?, city = ?, state = ?, zip = ?, ";
            strDML += "insuranceCompanyName = ?, insurancePolicyNumber = ?, insuranceGroupNumber = ?, ";
            strDML += "dateOfBirth = ?, status = ? ";
            strDML += "where username = ? ";

            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);

            cmd.Parameters.Add(new OleDbParameter("firstName", this.firstName));
            cmd.Parameters.Add(new OleDbParameter("lastName", this.lastName));
            cmd.Parameters.Add(new OleDbParameter("nickName", this.nickName));

            cmd.Parameters.Add(new OleDbParameter("homePhone", this.homePhone));
            cmd.Parameters.Add(new OleDbParameter("cellPhone", this.cellPhone));
            cmd.Parameters.Add(new OleDbParameter("email", this.email));

            cmd.Parameters.Add(new OleDbParameter("emergencyContact1", this.emergencyContact1));
            cmd.Parameters.Add(new OleDbParameter("emergencyContact1Relation", this.emergencyContact1Relation));
            cmd.Parameters.Add(new OleDbParameter("emergencyContact1Phone", this.emergencyContact1Phone));

            cmd.Parameters.Add(new OleDbParameter("emergencyContact2", this.emergencyContact2));
            cmd.Parameters.Add(new OleDbParameter("emergencyContact2Relation", this.emergencyContact2Relation));
            cmd.Parameters.Add(new OleDbParameter("emergencyContact2Phone", this.emergencyContact2Phone));

            cmd.Parameters.Add(new OleDbParameter("addressLine1", this.addressLine1));
            cmd.Parameters.Add(new OleDbParameter("addressLine2", this.addressLine2));
            cmd.Parameters.Add(new OleDbParameter("city", this.city));
            cmd.Parameters.Add(new OleDbParameter("state", this.state));
            cmd.Parameters.Add(new OleDbParameter("zip", this.zip));

            cmd.Parameters.Add(new OleDbParameter("insuranceCompanyName", this.insuranceCompanyName));
            cmd.Parameters.Add(new OleDbParameter("insurancePolicyNumber", this.insurancePolicyNumber));
            cmd.Parameters.Add(new OleDbParameter("insuranceGroupNumber", this.insuranceGroupNumber));

            cmd.Parameters.Add(new OleDbParameter("dateOfBirth", this.dateOfBirth));
            cmd.Parameters.Add(new OleDbParameter("status", this.status));

            cmd.Parameters.Add(new OleDbParameter("username", this.username));

            string result = App.runDML(cmd);
            if (result == "Success")
            {
                DBstatus = "Not Exists";
                return ("Success");
            }
            else
            {
                this.DBstatus = "Not Exists";
                return ("Failure");
            }
        }

        public void Delete()
        {
            //delete the deposit
            string strDML = "Delete from ClubMembers where username = '" + this.username + "'";

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


        public string addTransaction(Transaction t)
        {
            string strDML;
            if (String.IsNullOrEmpty(t.depositNumber))
            {
                strDML = "Insert into Transactions(type, semester, username, transDate, checkNumber, description, amount) ";
                strDML += "values(?, ?, ?, ?, ?, ?, ?)";
            }
            else
            {
                strDML = "Insert into Transactions(type, semester, username, transDate, depositNumber, checkNumber, description, amount) ";
                strDML += "values(?, ?, ?, ?, ?, ?, ?, ?)";
            }

            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);

            cmd.Parameters.Add(new OleDbParameter("type", t.type));
            cmd.Parameters.Add(new OleDbParameter("semester", t.semester));
            cmd.Parameters.Add(new OleDbParameter("username", t.username));
            cmd.Parameters.Add(new OleDbParameter("transDate", t.transDate));
            if (String.IsNullOrEmpty(t.depositNumber))
            {
                // not inserting deposit number so don't add parameter
            }
            else
            {
                cmd.Parameters.Add(new OleDbParameter("depositNumber", t.depositNumber));
            }
            cmd.Parameters.Add(new OleDbParameter("checkNumber", t.checkNumber));
            cmd.Parameters.Add(new OleDbParameter("description", t.description));
            cmd.Parameters.Add(new OleDbParameter("amount", t.amount));

            string result = App.runDML(cmd);
            if (result == "Success")
            {
                return ("Success");
            }
            else
            {
                return ("Failure");
            }

        }

        public string removeTransaction(int tnum)
        {
            string strDML;
            strDML = "Delete from Transactions where username = ? and transNo = ? ";

            //Create a DML command  with parameters for each of the question marks above
            OleDbCommand cmd = new OleDbCommand(strDML);

            cmd.Parameters.Add(new OleDbParameter("username", this.username));
            cmd.Parameters.Add(new OleDbParameter("transNum", tnum));

            string result = App.runDML(cmd);
            if (result == "Success")
            {
                return ("Success");
            }
            else
            {
                return ("Failure");
            }

        }

        public void ComputeBalanceDue()
        {
            string strSQL = "Select sum(amount) as total from Transactions where username = '" + this.username + "'";
            DataTable MyTransTotal = App.getGenericData(strSQL);
            this.balanceDue = App.MyDecParse(MyTransTotal.Rows[0]["total"].ToString());
        }


        public void getTransactions()
        {
            //here is the SQL statements to retrive the transactions
            string strSQL2 = "Select transno, type, semester, transdate, depositnumber, ";
            strSQL2 = strSQL2 + "checknumber, description, amount  from Transactions where username = '" + this.username + "'";

            //get a datatable which holds the Transactions Rows
            DataTable MyTransactionsTable = App.getGenericData(strSQL2);

            if (MyTransactionsTable.Rows.Count == 0)
            {
                //no transactions found
                //initially set the transactions table to have no rows but defined column headings
                this.transactions = GetEmptyTransTable();
                this.balanceDue = 0;
            }
            else
            {
                //set the Transactions of the ClubMember to the results of the transactions query
                //Transactions is a DataTable but could also be coded as a collection of transaction objects
                this.transactions = MyTransactionsTable;
                this.ComputeBalanceDue();
                Debug.WriteLine("successful clubmember.getTransaction");
            }
        }

        private static DataTable GetEmptyTransTable()
        {
            // to avoid having a NULL skills table we create one but with no rows
            DataTable NoTrans = new DataTable();

            DataColumn col1 = new DataColumn("TransNo");
            DataColumn col2 = new DataColumn("Type");
            DataColumn col3 = new DataColumn("Semester");
            DataColumn col4 = new DataColumn("username");
            DataColumn col5 = new DataColumn("TransDate");
            DataColumn col6 = new DataColumn("DepositNumber");
            DataColumn col7 = new DataColumn("CheckNumber");
            DataColumn col8 = new DataColumn("Description");
            DataColumn col9 = new DataColumn("Amount");

            col1.DataType = System.Type.GetType("System.Int16");
            col2.DataType = System.Type.GetType("System.String");
            col3.DataType = System.Type.GetType("System.String");
            col4.DataType = System.Type.GetType("System.String");
            col5.DataType = System.Type.GetType("System.DateTime");
            col6.DataType = System.Type.GetType("System.String");
            col7.DataType = System.Type.GetType("System.String");
            col8.DataType = System.Type.GetType("System.String");
            col9.DataType = System.Type.GetType("System.Decimal");

            NoTrans.Columns.Add(col1);
            NoTrans.Columns.Add(col2);
            NoTrans.Columns.Add(col3);
            NoTrans.Columns.Add(col4);
            NoTrans.Columns.Add(col5);
            NoTrans.Columns.Add(col6);
            NoTrans.Columns.Add(col7);
            NoTrans.Columns.Add(col8);
            NoTrans.Columns.Add(col9);

            return NoTrans;
        }
    }
}