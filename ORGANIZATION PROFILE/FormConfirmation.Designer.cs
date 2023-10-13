namespace ORGANIZATION_PROFILE
{
    partial class FormConfirmation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSubmit = new Button();
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblBirthday = new Label();
            lblContactNo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 55);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 146);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 196);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 250);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 295);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 345);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact No:";
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(115, 403);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(85, 35);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(103, 55);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(73, 15);
            lblStudentNo.TabIndex = 8;
            lblStudentNo.Text = "Output Here";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(103, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Output Here";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(103, 146);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(73, 15);
            lblProgram.TabIndex = 10;
            lblProgram.Text = "Output Here";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(103, 196);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(73, 15);
            lblAge.TabIndex = 11;
            lblAge.Text = "Output Here";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(103, 295);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 15);
            lblGender.TabIndex = 12;
            lblGender.Text = "Output Here";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(103, 250);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(73, 15);
            lblBirthday.TabIndex = 13;
            lblBirthday.Text = "Output Here";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(103, 345);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(73, 15);
            lblContactNo.TabIndex = 14;
            lblContactNo.Text = "Output Here";
            // 
            // FormConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(312, 450);
            Controls.Add(lblContactNo);
            Controls.Add(lblBirthday);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(lblStudentNo);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Info;
            Name = "FormConfirmation";
            Text = "FormConfirmation";
            Load += FormConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSubmit;
        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblGender;
        private Label lblBirthday;
        private Label lblContactNo;
    }
}