using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORGANIZATION_PROFILE
{
    public partial class FormConfirmation : Form
    {
        public FormConfirmation()
        {
            InitializeComponent();
        }
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        private void FormConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName.ToString();
            lblProgram.Text= StudentInformationClass.SetProgram.ToString();
            lblBirthday.Text = StudentInformationClass.SetBirthday.ToString();
            lblGender.Text = StudentInformationClass.SetGender.ToString();
            lblContactNo.Text= StudentInformationClass.SetContactNo.ToString();
            lblAge.Text= StudentInformationClass.SetAge.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }
    }
}
