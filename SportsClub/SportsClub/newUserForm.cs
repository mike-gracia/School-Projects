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
    public partial class newUserForm : Form
    {
        public ClubMember target;

        public newUserForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)      //OK
        {
            target = new ClubMember(textBox1.Text);

           target.firstName = "new";
           target.lastName = "user";
           target.nickName = " ";

           target.dateOfBirth = DateTime.Today;



           target.homePhone = "";
           target.cellPhone = "";
           target.email = "";

           target.emergencyContact1 = "";
           target.emergencyContact1Relation = "";
           target.emergencyContact1Phone = "";

           target.emergencyContact2 = "";
           target.emergencyContact2Relation = "";
           target.emergencyContact2Phone = "";

           target.addressLine1 = "";
           target.addressLine2 = "";
           target.city = "";
           target.state = "";
           target.zip = "";

           target.insuranceCompanyName = "";
           target.insurancePolicyNumber = "";
           target.insuranceGroupNumber = "";

           target.status = "Inactive";

            target.Save();
            DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)      //cancel
        {
            this.Dispose();
        }
    }
}
