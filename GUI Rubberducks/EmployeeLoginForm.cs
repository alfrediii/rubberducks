using GUI_Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer
using GUI_Registration_p1;

namespace RubberDucksLoginForm
{
	public partial class EmployeeLoginForm : Form
	{
        internal static string enteredUser;

        //Employee employee;
        public EmployeeLoginForm()
		{
			InitializeComponent();
		}

        private void btnClear_Click(object sender, EventArgs e)
		{
			txtUsername.Text = String.Empty;
			txtPassword.Text = String.Empty;
		}

        private String getAuthorizedPassword(string Username)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";

                cmd.Connection = cn;
                cmd.CommandText = "SELECT Password FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception)
            {
                //it handles any other errors
                MessageBox.Show("Error. This username is not recognized in our system. Try again.", "ACCESS DENIED!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }

        private String getUserApproval(string Username)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";

                cmd.Connection = cn;
                cmd.CommandText = "SELECT Approved FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }

        private String getFirstName(string Username)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT FirstName FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);
                // open a connection to DB
                cn.Open();
                //read the table
                dr = cmd.ExecuteReader();
                //read a record from the data reader
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");
                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }

        private String getUserType(string Username)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";

                cmd.Connection = cn;
                cmd.CommandText = "SELECT EmployeeType FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            enteredUser = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            try
            {
                // find the valid password for a given user from the database and compare it with the one entered by the user
                if (enteredPassword == getAuthorizedPassword(txtUsername.Text).Trim() & getUserApproval(txtUsername.Text).Trim() == "True")
                // if password entered is correct AND user is authorized then they can enter the system
                {
                    MessageBox.Show("Welcome to the IT Support System, " + getFirstName(txtUsername.Text).Trim() + "!\nLogin successful.", "Successful Login!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    //create & fill employee instance of user
                    Employee employee = getUserInfoFromDB(enteredUser);

                    if (getUserType(txtUsername.Text).Trim() == "Admin")
                    //opens a new interface for the Admin
                    {
                        AdminInterfaceForm admin = new AdminInterfaceForm(employee);
                        //AdminInterface admin = new AdminInterface();
                        admin.Show();
                    }

                    if (getUserType(txtUsername.Text).Trim() == "IT Support Team")
                    //opens a new interface for the an IT Support member
                    {
                        ITSupportInterfaceForm ITSupport = new ITSupportInterfaceForm(employee);
                        ITSupport.Show();
                    }

                    if (getUserType(txtUsername.Text).Trim() == "Project Member")
                    //opens a new interface for a project member
                    {
                        ProjectMemberInterfaceForm projectMember = new ProjectMemberInterfaceForm(employee);
                        projectMember.Show();
                    }

                    if (getUserType(txtUsername.Text).Trim() == "Report Manager")
                    //opens a new interface for a report manager
                    {
                        ReportManagerInterfaceForm reportManager = new ReportManagerInterfaceForm(employee);
                        reportManager.Show();
                    }
                }

                if (enteredPassword == getAuthorizedPassword(txtUsername.Text).Trim() & getUserApproval(txtUsername.Text).Trim() == "False")
                // if password entered is correct BUT user is not authorized then the user will receive an error message and the system will close
                {
                    MessageBox.Show("Sorry " + getFirstName(txtUsername.Text).Trim() + ", you have not yet been approved. Please wait for admin approval.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                    System.Windows.Forms.Application.Exit();
                }

                if (enteredPassword != getAuthorizedPassword(txtUsername.Text).Trim())
                //denies user if password is incorrect
                {
                    MessageBox.Show("Error. Invalid password. Try again.", "ACCESS DENIED!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                }
            }
            catch (Exception)
            {
                //it handles any other errors
                //pushes back null values to the getAuthorizedPassword() error handler
            }
        }

		private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegistrationPart1Form Reg1 = new RegistrationPart1Form();
			Reg1.Show();
		}

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Check your email for a reset code.", "ACCESS DENIED!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //fill employee instance of approved user
        public Employee getUserInfoFromDB(string Username)
        {
            Employee employee = new Employee();
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";

                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                while(dr.Read())
                {
                    int empid = (int)dr["EmployeeID"];
                    string emptype = (string)dr["EmployeeType"];
                    string empapproved = (string)dr["Approved"];
                    string empfirstname = (string)dr["FirstName"];
                    string emplastname = (string)dr["LastName"];
                    string empphone = (string)dr["Phone"];
                    string empemail = (string)dr["Email"];
                    string empaddress = (string)dr["Address"];
                    string empdepartment = (string)dr["Department"];
                    string empjobtitle = (string)dr["JobTitle"];
                    string emppassword = (string)dr["Password"];

                    string empidSTR = empid.ToString();

                    employee = new Employee(empidSTR, emptype, empfirstname, emplastname, empjobtitle, empdepartment, Username, empemail, empphone, empaddress, emppassword, empapproved);
                }

            }
            catch (Exception)
            {
                //it handles any other errors
                MessageBox.Show("Error. Couldnt connect to user.", "ERROR!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
            return employee;

        }

        private void EmployeeLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
