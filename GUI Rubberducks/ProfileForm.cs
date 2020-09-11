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
using RubberDucksLoginForm;
using GUI_Registration;

namespace GUI_Registration_p1
{
    public partial class ProfileForm : Form
    {

        public string Username = EmployeeLoginForm.enteredUser;

        public static string userType, firstName, lastName, jobTitle, department, username, email, phone, address, userID, password;
        public ProfileForm(string Username)
        {
            InitializeComponent();
            txtUserType.Text = getUserType(Username);
            txtFirstName.Text = getFirstName(Username);
            txtLastName.Text = getLastName(Username);
            txtEmail.Text = getEmail(Username);
            txtPhone.Text = getPhone(Username);
            txtAddress.Text = getAddress(Username);
            txtUserID.Text = getID(Username);
            txtJobTitle.Text = getJT(Username);
            txtDepartment.Text = getDept(Username);
            txtUsername.Text = getUsername(Username);
            txtPassword.Text = getPassword(Username);

            userType = txtUserType.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            email = txtEmail.Text;
            phone = txtPhone.Text;
            address = txtAddress.Text;
            userID = txtUserID.Text;
            jobTitle = txtJobTitle.Text;
            department = txtDepartment.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
            }
            else
            {
                //message box asks user if they are sure they want to Cancel
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel? Your changes will not be saved.", "Cancel", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtFirstName.Text = firstName;
                    txtLastName.Text = lastName;
                    txtEmail.Text = email;
                    txtPhone.Text = phone;
                    txtAddress.Text = address;
                    txtPassword.Text = password;

                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPassword.ReadOnly = true;

                    btnClose.Text = "Close";
                    btnEdit.Text = "Edit";


                }
                if (dialogResult == DialogResult.No)
                {
                    //nothing 
                }
            }
        }



        // We want to condense this
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Save";
                btnClose.Text = "Cancel";

                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtPassword.ReadOnly = false;
            }
            else
            {
                //message box asks user if they are sure they want to Save Changes
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your changes? Your info will be updated in the system.", "Save changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btnEdit.Text = "Edit";
                    btnClose.Text = "Close";

                    firstName = txtFirstName.Text;
                    lastName = txtLastName.Text;
                    email = txtEmail.Text;
                    phone = txtPhone.Text;
                    address = txtAddress.Text;
                    password = txtPassword.Text;

                    loadSavedChanges();

                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPassword.ReadOnly = true;



                }
                if (dialogResult == DialogResult.No)
                {
                    //nothing 
                }
            }

        }
        //saves users changes
        private void loadSavedChanges()
        {
            //declare all necessary variables reading data from a sqlServer table
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

                cmd.CommandText = "UPDATE userinfoTable SET FirstName = @empfirstname, LastName = @emplastname, Email = @empemail, Phone = @empphone, Address = @empaddress, Password = @emppassword WHERE Username = @Username";

                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@empfirstname", firstName);
                cmd.Parameters.AddWithValue("@emplastname", lastName);
                cmd.Parameters.AddWithValue("@empemail", email);
                cmd.Parameters.AddWithValue("@empphone", phone);
                cmd.Parameters.AddWithValue("@empaddress", address);
                cmd.Parameters.AddWithValue("@emppassword", password);
                cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Error Saving!");
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
        private String getLastName(string Username)
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
                cmd.CommandText = "SELECT LastName FROM userinfoTable WHERE Username = @Username";
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
        private String getEmail(string Username)
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
                cmd.CommandText = "SELECT Email FROM userinfoTable WHERE Username = @Username";
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
        private String getPhone(string Username)
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
                cmd.CommandText = "SELECT Phone FROM userinfoTable WHERE Username = @Username";
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
        private String getAddress(string Username)
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
                cmd.CommandText = "SELECT Address FROM userinfoTable WHERE Username = @Username";
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
        private String getID(string Username)
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
                cmd.CommandText = "SELECT EmployeeID FROM userinfoTable WHERE Username = @Username";
                cmd.Parameters.AddWithValue("@Username", Username);
                // open a connection to DB
                cn.Open();
                //read the table
                dr = cmd.ExecuteReader();
                //read a record from the data reader
                dr.Read();
                return "" + dr.GetInt32(0) + "";
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
        private String getJT(string Username)
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
                cmd.CommandText = "SELECT JobTitle FROM userinfoTable WHERE Username = @Username";
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
        private String getDept(string Username)
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
                cmd.CommandText = "SELECT Department FROM userinfoTable WHERE Username = @Username";
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
        private String getUsername(string Username)
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
                cmd.CommandText = "SELECT Username FROM userinfoTable WHERE Username = @Username";
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
        private String getPassword(string Username)
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

    }
}
