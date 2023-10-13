namespace ORGANIZATION_PROFILE
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbLastName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            tbStudentNo = new TextBox();
            tbAge = new TextBox();
            tbFirstName = new TextBox();
            tbMiddleInitial = new TextBox();
            tbbLastName = new TextBox();
            btnRegister = new Button();
            tbContactNo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // tbLastName
            // 
            tbLastName.AutoSize = true;
            tbLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(39, 112);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(79, 20);
            tbLastName.TabIndex = 1;
            tbLastName.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 176);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 239);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(340, 50);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(340, 176);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(340, 112);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(373, 239);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 7;
            label8.Text = "Contact No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(582, 112);
            label9.Name = "label9";
            label9.Size = new Size(32, 20);
            label9.TabIndex = 8;
            label9.Text = "M.I.";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Information System", "BS in Accountancy", "BS in Hospitality Management", "BS in Tourism Management " });
            cbProgram.Location = new Point(423, 47);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(121, 23);
            cbProgram.TabIndex = 9;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(423, 177);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 10;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(129, 237);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 11;
            // 
            // tbStudentNo
            // 
            tbStudentNo.Location = new Point(142, 47);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(100, 23);
            tbStudentNo.TabIndex = 12;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(142, 173);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 14;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(426, 112);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(100, 23);
            tbFirstName.TabIndex = 15;
            // 
            // tbMiddleInitial
            // 
            tbMiddleInitial.Location = new Point(611, 109);
            tbMiddleInitial.Name = "tbMiddleInitial";
            tbMiddleInitial.Size = new Size(100, 23);
            tbMiddleInitial.TabIndex = 16;
            // 
            // tbbLastName
            // 
            tbbLastName.Location = new Point(142, 109);
            tbbLastName.Name = "tbbLastName";
            tbbLastName.Size = new Size(100, 23);
            tbbLastName.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = SystemColors.ControlText;
            btnRegister.Location = new Point(332, 333);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 39);
            btnRegister.TabIndex = 18;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(463, 236);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(139, 23);
            tbContactNo.TabIndex = 19;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(tbContactNo);
            Controls.Add(btnRegister);
            Controls.Add(tbbLastName);
            Controls.Add(tbMiddleInitial);
            Controls.Add(tbFirstName);
            Controls.Add(tbAge);
            Controls.Add(tbStudentNo);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbLastName);
            Controls.Add(label1);
            ForeColor = SystemColors.Info;
            Name = "frmRegistration";
            Text = "Organization Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tbLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private TextBox tbStudentNo;
        private TextBox tbAge;
        private TextBox tbFirstName;
        private TextBox tbMiddleInitial;
        private TextBox tbbLastName;
        private Button btnRegister;
        private TextBox tbContactNo;
    }
}