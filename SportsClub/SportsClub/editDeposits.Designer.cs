namespace SportsClub
{
    partial class editDeposits
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_radio = new System.Windows.Forms.RadioButton();
            this.remove_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deposit #";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 72);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(53, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(71, 72);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(58, 23);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Done";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_radio
            // 
            this.add_radio.AutoSize = true;
            this.add_radio.Location = new System.Drawing.Point(12, 12);
            this.add_radio.Name = "add_radio";
            this.add_radio.Size = new System.Drawing.Size(44, 17);
            this.add_radio.TabIndex = 5;
            this.add_radio.TabStop = true;
            this.add_radio.Text = "Add";
            this.add_radio.UseVisualStyleBackColor = true;
            this.add_radio.CheckedChanged += new System.EventHandler(this.add_radio_CheckedChanged);
            // 
            // remove_radio
            // 
            this.remove_radio.AutoSize = true;
            this.remove_radio.Location = new System.Drawing.Point(62, 12);
            this.remove_radio.Name = "remove_radio";
            this.remove_radio.Size = new System.Drawing.Size(65, 17);
            this.remove_radio.TabIndex = 6;
            this.remove_radio.TabStop = true;
            this.remove_radio.Text = "Remove";
            this.remove_radio.UseVisualStyleBackColor = true;
            this.remove_radio.CheckedChanged += new System.EventHandler(this.remove_radio_CheckedChanged);
            // 
            // editDeposits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 109);
            this.ControlBox = false;
            this.Controls.Add(this.remove_radio);
            this.Controls.Add(this.add_radio);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editDeposits";
            this.Text = "Add or Remove Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.RadioButton add_radio;
        private System.Windows.Forms.RadioButton remove_radio;
    }
}