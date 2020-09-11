using RubberDucksLoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Registration
{
	public partial class RegistrationPart1Form : Form
	{
		//to remember this form
		private Form page1Copy;

		//string variables for user input
		public static string userType, firstName, lastName, jobTitle, department, username, email, phone, address;


		private void btnCancel_Click(object sender, EventArgs e)
		{
			EmployeeLoginForm login = new EmployeeLoginForm();
			this.Close();
		}

		public RegistrationPart1Form()
		{
			InitializeComponent();
		}

		public void btnContinue_Click(object sender, EventArgs e)
		{
			//how to make continue button open registrtion form
			//do a try catch
			try
			{
				userType = cmboxUserType.Text;
				firstName = txtFirstName.Text;
				lastName = txtLastName.Text;
				jobTitle = txtJobTitle.Text;
				department = txtDepartment.Text;
				email = txtEmail.Text;
				phone = mtxPhone.Text;
				address = txtAddress.Text;

				//loads second registration form and keeps this form in memory
				page1Copy = this;
				RegistrationPart2Form Reg2 = new RegistrationPart2Form(page1Copy);
				this.Hide();
				Reg2.Show();

			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Please fill out all required fields.", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
			}
		}
	}
}
