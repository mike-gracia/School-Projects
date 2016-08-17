using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace aspx2
{
    public partial class _Default : System.Web.UI.Page
    {
        EmployeeInfoService service = new EmployeeInfoService();

        String id;
        Employee jdoe;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == true)
            {
                //do postback stuff
            }
            else
            {

                empSelectDropDown.DataSource = service.getEmployeeList();
                empSelectDropDown.DataTextField = "EMPID";
                empSelectDropDown.DataBind();

                DeptDropDown.DataSource = service.getDepartmentList();
                DeptDropDown.DataTextField = "DEPT";
                DeptDropDown.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("^[a-zA-Z]+$");
            WarningLabel.BackColor = System.Drawing.Color.Red;

            if (MyDecParse(salaryTextBox.Text) <= 20000 || MyDecParse(salaryTextBox.Text) >= 999999)
            {
                WarningLabel.Text = "Save Unsuccessful: Salary out of bounds!";
            }
            else if (fnameTextBox.Text.Length <= 2 )
            {
                WarningLabel.Text = "Save Unsuccessful: Name out of bounds!";
            }
            else if (!re.IsMatch(fnameTextBox.Text)||!re.IsMatch(lnameTextBox.Text))
            {
                WarningLabel.Text = "Save Unsuccessful: Illegal characters in first/last name!";
            }
            else
            {
                EmployeeInfoService service = new EmployeeInfoService();
                Employee emp = service.getEmployee(empSelectDropDown.Text);
                emp.fname = fnameTextBox.Text;
                emp.lname = lnameTextBox.Text;
                emp.phone = phoneTextBox.Text;
                emp.salary = MyDecParse(salaryTextBox.Text);
                emp.sex = sexDropDown.Text;
                emp.dept = DeptDropDown.Text;
                service.saveEmployee(emp);
                WarningLabel.Text = "Save Successful";
                WarningLabel.BackColor = System.Drawing.Color.Green;
           }
            
        }

        public void fetchInfo()
        {
            fnameTextBox.Text = jdoe.fname;
            lnameTextBox.Text = jdoe.lname;
            phoneTextBox.Text = jdoe.phone;
            salaryTextBox.Text = jdoe.salary.ToString("C");
            DeptDropDown.Text = jdoe.dept;
            sexDropDown.Text = jdoe.sex;
        }

        protected void empSelectDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = empSelectDropDown.Text;
            jdoe = service.getEmployee(id);
            fetchInfo();
        }

        protected void LoadButton_Click(object sender, EventArgs e)
        {
            WarningLabel.Text = "";
            id = empSelectDropDown.SelectedItem.Text;
            jdoe = service.getEmployee(id);
            fetchInfo();
        }
        public static decimal MyDecParse(string string_to_parse)
        {
            //this method is used to parse a string to a decimal
            //It takes a string such as $10,000.00 and scrubs out
            //the dollar sign and commas in order to parse without errors

            //if zero length string change it to a zero
            if (string_to_parse.Length == 0)
            {
                string_to_parse = "0";
            }

            //get rid of any dollar sign or commas from the string
            if (string_to_parse.Contains("$"))
            {
                int symbol_location = string_to_parse.LastIndexOf("$");
                string_to_parse = string_to_parse.Substring(0, symbol_location) + string_to_parse.Substring(symbol_location + 1);
            }
            //get rid of any commas in the string
            while (string_to_parse.Contains(","))
            {
                int symbol_location = string_to_parse.LastIndexOf(",");
                string_to_parse = string_to_parse.Substring(0, symbol_location) + string_to_parse.Substring(symbol_location + 1);
            }
            //replace parenthesis with negative sign if needed
            if (string_to_parse.Substring(0, 1) == "(")
            {
                // replace the first character with negative sign
                string_to_parse = "-" + string_to_parse.Substring(1);
                int stringLength = string_to_parse.Length;
                // get rid of the final closing paren
                string_to_parse = string_to_parse.Substring(0, stringLength - 1);
                //Debug.WriteLine(string_to_parse);
            }

            //now that the string is clear of special charcters use PARSE to create a decimal
            try
            {
                return decimal.Parse(string_to_parse);
            }
            catch
            {
                //must be a blank string or invalid string
                //Debug.WriteLine("myParseFailure");
                return (Decimal)0.0;
            }
            finally
            {
                //comment here
            }
        }
             
    }
}
