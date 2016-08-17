namespace SportsClub
{
    partial class addTransForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.checkNumb_textBox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.depositeNum_textbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.semester_comboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.typeTrans_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(71, 193);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(100, 20);
            this.amount_textbox.TabIndex = 12;
            // 
            // checkNumb_textBox
            // 
            this.checkNumb_textBox.Location = new System.Drawing.Point(237, 97);
            this.checkNumb_textBox.Name = "checkNumb_textBox";
            this.checkNumb_textBox.Size = new System.Drawing.Size(48, 20);
            this.checkNumb_textBox.TabIndex = 11;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(71, 132);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(173, 39);
            this.description_textbox.TabIndex = 10;
            // 
            // depositeNum_textbox
            // 
            this.depositeNum_textbox.Location = new System.Drawing.Point(99, 97);
            this.depositeNum_textbox.Name = "depositeNum_textbox";
            this.depositeNum_textbox.Size = new System.Drawing.Size(48, 20);
            this.depositeNum_textbox.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 196);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Amount    $";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Description";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(153, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Check Number";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Deposit Number";
            // 
            // semester_comboBox
            // 
            this.semester_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semester_comboBox.FormattingEnabled = true;
            this.semester_comboBox.Items.AddRange(new object[] {
            "Fall 2011",
            "Spring 2012"});
            this.semester_comboBox.Location = new System.Drawing.Point(71, 59);
            this.semester_comboBox.Name = "semester_comboBox";
            this.semester_comboBox.Size = new System.Drawing.Size(121, 21);
            this.semester_comboBox.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Semester";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Type";
            // 
            // typeTrans_comboBox
            // 
            this.typeTrans_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeTrans_comboBox.FormattingEnabled = true;
            this.typeTrans_comboBox.Items.AddRange(new object[] {
            "Charge",
            "Payment",
            "Credit"});
            this.typeTrans_comboBox.Location = new System.Drawing.Point(71, 21);
            this.typeTrans_comboBox.Name = "typeTrans_comboBox";
            this.typeTrans_comboBox.Size = new System.Drawing.Size(121, 21);
            this.typeTrans_comboBox.TabIndex = 0;
            // 
            // addTransForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 276);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.typeTrans_comboBox);
            this.Controls.Add(this.checkNumb_textBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.depositeNum_textbox);
            this.Controls.Add(this.semester_comboBox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addTransForum";
            this.Text = "Add Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.TextBox checkNumb_textBox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox depositeNum_textbox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox semester_comboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox typeTrans_comboBox;
    }
}