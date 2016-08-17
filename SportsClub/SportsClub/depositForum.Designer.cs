namespace SportsClub
{
    partial class depositForum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.depositComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.deposittotal_label = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.depositDataGrid = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.done_button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // depositComboBox
            // 
            this.depositComboBox.FormattingEnabled = true;
            this.depositComboBox.Location = new System.Drawing.Point(134, 22);
            this.depositComboBox.Name = "depositComboBox";
            this.depositComboBox.Size = new System.Drawing.Size(48, 21);
            this.depositComboBox.TabIndex = 8;
            this.depositComboBox.SelectedIndexChanged += new System.EventHandler(this.depositComboBox_SelectedIndexChanged_1);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.deposittotal_label);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.depositDataGrid);
            this.groupBox8.Controls.Add(this.shapeContainer1);
            this.groupBox8.Location = new System.Drawing.Point(6, 52);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(711, 222);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "All Deposits";
            // 
            // deposittotal_label
            // 
            this.deposittotal_label.AutoSize = true;
            this.deposittotal_label.Location = new System.Drawing.Point(62, 193);
            this.deposittotal_label.Name = "deposittotal_label";
            this.deposittotal_label.Size = new System.Drawing.Size(0, 13);
            this.deposittotal_label.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 194);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Balance:";
            // 
            // depositDataGrid
            // 
            this.depositDataGrid.AllowUserToAddRows = false;
            this.depositDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.depositDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.depositDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depositDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositDataGrid.Location = new System.Drawing.Point(9, 19);
            this.depositDataGrid.Name = "depositDataGrid";
            this.depositDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "X";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.depositDataGrid.RowHeadersWidth = 30;
            this.depositDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.depositDataGrid.Size = new System.Drawing.Size(692, 150);
            this.depositDataGrid.TabIndex = 4;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(705, 203);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 52;
            this.lineShape1.X2 = 128;
            this.lineShape1.Y1 = 190;
            this.lineShape1.Y2 = 190;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 52;
            this.lineShape2.X2 = 129;
            this.lineShape2.Y1 = 195;
            this.lineShape2.Y2 = 195;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(579, 310);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 9;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(12, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Select Deposit Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add / Remove Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 345);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.depositComboBox);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "depositForum";
            this.Text = "depositForum";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox depositComboBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView depositDataGrid;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label deposittotal_label;
        private System.Windows.Forms.Button button1;
    }
}