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

namespace GUI_Registration_p1
{
    public partial class AdminUserControlForm : Form
    {
        private string selecteduser;
        private string status;
        private string apstatus;
        public AdminUserControlForm()
        {
            InitializeComponent();
        }

        private void AdminActivationandEditing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rDTables.ticketTable' table. You can move, or remove it, as needed.
            this.userinfoTableTableAdapter3.Populate(this.rDTables.userinfoTable);

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.userinfoTableTableAdapter3.Populate(this.rDTables.userinfoTable);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            this.userinfoTableTableAdapter3.Pending(this.rDTables.userinfoTable);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            selecteduser = lstUsers.Text;
            ProfileForm profile2 = new ProfileForm(selecteduser);
            profile2.Show();
        }

        private void AdminUserControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            selecteduser = lstUsers.Text;
            string approved = getUserApproval(selecteduser).Trim();
            if (approved == "True")
            {
                apstatus = "approved";
            }
            else 
            {
                apstatus = "not approved";
            }

            DialogResult dialogResult = MessageBox.Show("The user " + lstUsers.Text.Trim() + " is " + apstatus + ". Would you like this user to be/stay approved?", "Approval Status", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                status = "True";
                approveUser(selecteduser);
            }
            else if (dialogResult == DialogResult.No)
            {
                status = "False";
            }
        }

        private void approveUser(string Username)
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

                cmd.CommandText = "UPDATE userinfoTable SET Approved = @approved WHERE Username = @Username";

                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@approved", status);
                cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Error assigning ticket!");
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
    }

    // this form helps the admin manage user information
}
