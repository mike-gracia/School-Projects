using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();
            EmployeeInfoService service = new EmployeeInfoService();
            deptComboBox.DataSource = service.getDepartmentList();
            deptComboBox.DisplayMember = "DEPT";

            IDcomboBox.DataSource = service.getEmployeeList();
            IDcomboBox.DisplayMember = "EMPID";
            lnameTextBox.Text = "";
            IDcomboBox.Text = "";
            salaryTextBox.Text = "";
            editFlip(false);
        }



        private void updateFields(String target)
        {
            EmployeeInfoService service = new EmployeeInfoService();
            Employee emp = service.getEmployee(target);
            fNameTextBox.Text = emp.fname;
            lnameTextBox.Text = emp.lname;
            phoneTextBox.Text = emp.phone;
            salaryTextBox.Text = emp.salary.ToString("C");
            sexComboBox.Text = emp.sex;
            deptComboBox.Text = emp.dept;

        }

        private void saveFields()
        {
            EmployeeInfoService service = new EmployeeInfoService();
            Employee emp = service.getEmployee(IDcomboBox.Text);
            emp.fname = fNameTextBox.Text;
            emp.lname = lnameTextBox.Text;
            emp.phone = phoneTextBox.Text;
            emp.sex = sexComboBox.Text;
            emp.dept = deptComboBox.Text;
            emp.salary = MyDecParse(salaryTextBox.Text);
            MessageBox.Show(service.saveEmployee(emp));
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            updateFields(IDcomboBox.Text);
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFields(IDcomboBox.Text);
            editFlip(true);
        }


        public void editFlip(Boolean flipflop)
        {
            saveEmpButton.Enabled = flipflop;
            deptComboBox.Enabled = flipflop;
            sexComboBox.Enabled = flipflop;
            phoneTextBox.Enabled = flipflop;
            salaryTextBox.Enabled = flipflop;
            lnameTextBox.Enabled = flipflop;
            fNameTextBox.Enabled = flipflop;
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
            if (string_to_parse.Contains('$'))
            {
                int symbol_location = string_to_parse.LastIndexOf("$");
                string_to_parse = string_to_parse.Substring(0, symbol_location) + string_to_parse.Substring(symbol_location + 1);
            }
            //get rid of any commas in the string
            while (string_to_parse.Contains(','))
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

        private void saveEmpButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save Employee?", "Confirm Save", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                saveFields();
            }
            else
            {
                //dont save
            }
        }

    }
}
