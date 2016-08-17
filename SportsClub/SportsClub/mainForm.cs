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
    public partial class mainForm : Form
    {
        //global clubmember
        public ClubMember target;


        //whatever text for new user is desired
        String newUserString = "New...";

        //boolean for personal info editability
        Boolean editState = true;
        

        public mainForm()
        {
            InitializeComponent();
            update_MainCombo();     //put usernames in the combo
            enable_edit(false);     //turn off text fields and buttons
            enableEdit_button.Enabled = false;  //turn off edit personal info button
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox4.Text == newUserString)        //new user
            {
                newUserForm forum = new newUserForm();
                if (forum.ShowDialog() == DialogResult.OK)      //user clicks ok
                {

                    target = new ClubMember(forum.target.getUsername());
                    update_MainCombo();
                    comboBox4.SelectedItem = target.getUsername();
                }
                else                                            //user clicks cancel
                {
                    MessageBox.Show("No User Created");
                    comboBox4.SelectedIndex = 1;
                }

            }
            else
            {
                target = new ClubMember(comboBox4.Text);
            }
            
            update_textBoxs();
            update_trans();
            enableEdit_button.Enabled = true;
            
        }



        private void button2_Click(object sender, EventArgs e)      //reset button
        {
             update_textBoxs();
        }

        private void button1_Click(object sender, EventArgs e)      //update button
        {
            if (MessageBox.Show("Are you sure you want to update this member?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                update_ClubMemberObject();
                target.Save();
                update_textBoxs();
            }
        }

        private void enableEdit_button_Click(object sender, EventArgs e)
        {
            enable_edit(editState);
            if (editState) { enableEdit_button.Text = "Disable Editing"; }
            else { enableEdit_button.Text = "Enable Editing"; }
            editState = !editState;
        }

        private void update_MainCombo()
        {
            //everythig below is to generate the usernames selection in the combobox
            string strConnection = App.getConnectionString();
            //here is the SQL statements to retrive the ClubMember information
            string strSQL = "Select username from ClubMembers";

            //get a datatable with one row which holds the ClubMember data
            DataTable usernames = App.getGenericData(strSQL);

            //remove current items
            comboBox4.Items.Clear();
            // add new user selection string
            comboBox4.Items.Add(newUserString);
            string[] arr = new String[usernames.Rows.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = usernames.Rows[i]["username"].ToString();
            }
            comboBox4.Items.AddRange(arr);  
        }



        public void update_trans()
        {

            dataGridView1.DataSource = target.transactions;
            balance_label.Text = "$ " + target.balanceDue.ToString();
            this.Update();
        }
        
        private void update_textBoxs()
        {
            try
            {
                selected_label.Text = target.firstName + " " + target.lastName;
                fnameTextbox.Text = target.firstName;
                lnameTextbox.Text = target.lastName;
                nNametextBox.Text = target.nickName;

                DOBTimePicker.Value = target.dateOfBirth;



                hPhoneTextbox.Text = target.homePhone;
                cPhoneTextBox.Text = target.cellPhone;
                emailTextbox.Text = target.email;

                contact1nameTextbox.Text = target.emergencyContact1;
                contact1relationTextbox.Text = target.emergencyContact1Relation;
                contact1phoneTextbox.Text = target.emergencyContact1Phone;

                contact2relationTextbox.Text = target.emergencyContact2;
                contact2nameTextbox.Text = target.emergencyContact2Relation;
                contact2phoneTextbox.Text = target.emergencyContact2Phone;

                street1Textbox.Text = target.addressLine1;
                street2Textbox.Text = target.addressLine2;
                citytextBox.Text = target.city;
                stateTextbox.Text = target.state;
                zipTextbox.Text = target.zip;

                insuranceNameTextbox.Text = target.insuranceCompanyName;
                policyNumTextbox.Text = target.insurancePolicyNumber;
                groupNumTextbox.Text = target.insuranceGroupNumber;

                statusComboBox.SelectedItem = target.status;

            }
            catch { }
        
        }

        private void update_ClubMemberObject()
        {
            target.firstName = fnameTextbox.Text;
            target.lastName = lnameTextbox.Text;
            target.nickName = nNametextBox.Text;
            target.dateOfBirth = DOBTimePicker.Value;

            target.homePhone = hPhoneTextbox.Text;
            target.cellPhone = cPhoneTextBox.Text;
            target.email = emailTextbox.Text;
            
            target.emergencyContact1 = contact1nameTextbox.Text;
            target.emergencyContact1Relation = contact1relationTextbox.Text;
            target.emergencyContact1Phone = contact1phoneTextbox.Text;

            target.emergencyContact2 = contact2relationTextbox.Text;
            target.emergencyContact2Relation = contact2nameTextbox.Text;
            target.emergencyContact2Phone = contact2phoneTextbox.Text;

            target.addressLine1 = street1Textbox.Text;
            target.addressLine2 = street2Textbox.Text;
            target.city = citytextBox.Text;
            target.state = stateTextbox.Text;
            target.zip = zipTextbox.Text;

            target.insuranceCompanyName = insuranceNameTextbox.Text;
            target.insurancePolicyNumber = policyNumTextbox.Text;
            target.insuranceGroupNumber = groupNumTextbox.Text;

            target.status = statusComboBox.SelectedItem.ToString();
        
            
        }

        private void enable_edit(Boolean truth)
        {
            fnameTextbox.Enabled = truth;
            lnameTextbox.Enabled = truth;
            nNametextBox.Enabled = truth;
            DOBTimePicker.Enabled = truth;

            hPhoneTextbox.Enabled = truth;
            cPhoneTextBox.Enabled = truth;
            emailTextbox.Enabled = truth;

            contact1nameTextbox.Enabled = truth;
            contact1relationTextbox.Enabled = truth;
            contact1phoneTextbox.Enabled = truth;

            contact2relationTextbox.Enabled = truth;
            contact2nameTextbox.Enabled = truth;
            contact2phoneTextbox.Enabled = truth;

            street1Textbox.Enabled = truth;
            street2Textbox.Enabled = truth;
            citytextBox.Enabled = truth;
            stateTextbox.Enabled = truth;
            zipTextbox.Enabled = truth;

            insuranceNameTextbox.Enabled = truth;
            policyNumTextbox.Enabled = truth;
            groupNumTextbox.Enabled = truth;

            statusComboBox.Enabled = truth;

            updateInfo_Button.Enabled = truth;
            resetInfo_Button.Enabled = truth;
            deleteuser_Button.Enabled = truth;

            //----tab 2------------------
            addTrans_button.Enabled = truth;
            delTrans_button.Enabled = truth;
            dataGridView1.RowHeadersVisible = truth;

        }

        private void addTrans_button_Click(object sender, EventArgs e)
        {
                addTransForm transForum = new addTransForm(this);

                if (transForum.ShowDialog(this) == DialogResult.OK)
                {
                    target = new ClubMember(comboBox4.Text);
                    update_trans();

                    this.Update(); //this
                }

                transForum.Dispose();
                
                
               
                
        }

        private void delTrans_button_Click(object sender, EventArgs e)
        {
            delTransForm dt = new delTransForm(this);

            if (dt.ShowDialog(this) == DialogResult.OK)
            {
                target = new ClubMember(comboBox4.Text);
                update_trans();

                this.Update(); //this
            }

            dt.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this transaction?", "My Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                == DialogResult.Yes)
            {

                target.removeTransaction((int)dataGridView1.SelectedCells[0].Value);
                dataGridView1.ClearSelection();

                target = new ClubMember(comboBox4.Text);
                update_trans();
                this.Update();
                
                    
            }
            
            
            
        }

        private void deleteuser_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User",
               MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
               == DialogResult.Yes)
            {
                target.Delete();
                update_MainCombo();

                comboBox4.SelectedIndex = 1;          
            }
            
        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            depositForum dF = new depositForum(this);
            dF.ShowDialog();
            
        }


        
    }
}
