using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Registration
{
	public partial class RegistrationPart2Form : Form
	{
		//filled out first registration form in memory
		private Form prevForm;
		private string userID, userType, firstName, lastName, jobTitle, department, username, email, phone, address, password, approved;

		//Employee object variable
		private Employee objEmployee;
		
		private void btnRegister_Click(object sender, EventArgs e)
		{
			//creates an employee instance with all inputted info
			objEmployee = new Employee(userID, userType, firstName, lastName, jobTitle, department,
			username, email, phone, address, password, approved);

			SqlConnection cn = new SqlConnection();
			SqlCommand cmd = new SqlCommand();

			try
			{

				//right click on the .mdf file under the Solution Explorer and select Properties
				//then find its Full Path directory and copy and paste it below
				cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";

				cmd.Connection = cn;
				// open a connection to DB
				cn.Open();

				cmd.CommandText = ("INSERT INTO userinfoTable (EmployeeID, EmployeeType, Approved, FirstName, LastName, Phone, Email, Address, Department, JobTitle, Username, Password) " +
					" VALUES (@empID, @empType, @empApproved, @empFirstName, @empLastName, @empPhone, @empEmail, @empAddress, @empDepartment, @empJobTitle, @empUsername, @empPassword)");
				cmd.Parameters.AddWithValue("empID", int.Parse(userID));
				cmd.Parameters.AddWithValue("empType", userType.Trim());
				cmd.Parameters.AddWithValue("empApproved", "False");
				cmd.Parameters.AddWithValue("empFirstName", firstName.Trim());
				cmd.Parameters.AddWithValue("empLastName", lastName.Trim());
				cmd.Parameters.AddWithValue("empPhone", phone.Trim());
				cmd.Parameters.AddWithValue("empEmail", email.Trim());
				cmd.Parameters.AddWithValue("empAddress", address.Trim());
				cmd.Parameters.AddWithValue("empDepartment", department.Trim());
				cmd.Parameters.AddWithValue("empJobTitle", jobTitle.Trim());
				cmd.Parameters.AddWithValue("empUsername", username.Trim());
				cmd.Parameters.AddWithValue("empPassword", password.Trim());


				//now execute the sqlCommand
				cmd.ExecuteNonQuery();

				MessageBox.Show("Registration successful! Please wait for approval from a system administrator.");
			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				cn.Close(); //Close connection regardless of any errors or not
				this.Close();
			}
		}


		public RegistrationPart2Form(Form form)
		{
			InitializeComponent();

			//the first registration form incase back button is pressed
			prevForm = form;
		}

		private void RegistrationPart2Form_Load(object sender, EventArgs e)
		{
			//grab user input from first form and assign to necessary variables
			userID = GenerateEmployeeID();
			userType = RegistrationPart1Form.userType;
			firstName = RegistrationPart1Form.firstName;
			lastName = RegistrationPart1Form.lastName;
			jobTitle = RegistrationPart1Form.jobTitle;
			department = RegistrationPart1Form.department;
			email = RegistrationPart1Form.email;
			if (RegistrationPart1Form.lastName.Length > 6) 
			{
				username = RegistrationPart1Form.firstName[0]+ RegistrationPart1Form.lastName.Substring(0, 6);
				username = username.ToLower();
				username = username.Replace(" ",null);
			}
			else
			{
				username = RegistrationPart1Form.firstName[0] + RegistrationPart1Form.lastName;
				username = username.ToLower();
				username = username.Replace(" ", null);
			}
			phone = RegistrationPart1Form.phone;
			address = RegistrationPart1Form.address;
			password = GeneratePassword();
			approved = "False";

			//puts the user input from the first form onto this from
			lblRandUserID.Text = userID;
			lblUsertypeBox.Text = userType;
			lblUserFName.Text = firstName;
			lblUserLName.Text = lastName;
			lblUserJobTitle.Text = jobTitle;
			lblUserDepartment.Text = department;
			lblUserEmail.Text = email;
			lblUserUsername.Text = username;
			lblUserPhone.Text = phone;
			lblUserAddress.Text = address;
			lblRandPassword.Text = password;

		}

		private string GeneratePassword()
		{
			string password = "";
			Random random = new Random();
			for (int i = 0; i<8; i++)
			{
				int a = random.Next(0, 26);
				char ch = (char)('A' + a);
				password += ch;
			}
			return password;
		}

		private string GenerateEmployeeID()
		{
			Random random = new Random();
			int userid = random.Next(10000000, 99999999);
			return userid.ToString();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			prevForm.Show();
			this.Close();
		}

	}
}
