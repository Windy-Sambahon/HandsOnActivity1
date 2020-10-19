using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrganizationProfile.frmRegistration;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        private object txtFirstName;
        private object txtLastName;
        private object datePickerBirthday;
        private object txtAge;
        private object txtMiddleInitial;
        private object txtStudentNo;
        private object cbPrograms;
        private object cbGender;
        private object txtContactNo;

        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName, txtFirstName, txtMiddleInitial);
            StudentInformationClass.SetStudentNo = StudentNo(txtStudentNo);
            StudentInformationClass.SetProgram = (string)cbPrograms;
            StudentInformationClass.SetGender = (string)cbGender;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo);
            StudentInformationClass.SetAge = Age(txtAge);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-mm-dd");


            frmConfirmation frm = new frmConfirmation();
        }

        private int ContactNo(object text)
        {
            throw new NotImplementedException();
        }

        private int StudentNo(object text)
        {
            throw new NotImplementedException();
        }

        private int Age(object text)
        {
            throw new NotImplementedException();
        }

        private string FullName(object text1, object text2, object text3)
        {
            throw new NotImplementedException();
        }
    }
}
                
    
