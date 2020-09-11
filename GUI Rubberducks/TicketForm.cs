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
using System.Data.SqlClient;
using RubberDucksLoginForm;

namespace GUI_Registration_p1
{
    public partial class TicketForm : Form
    {
        //ticket instance
        private Ticket ticket;
        public static string Username;
        private string userType;

        public string description, problemType, assignedTo, status;

        public TicketForm(Ticket ticket)
        {
            InitializeComponent();
            Username = EmployeeLoginForm.enteredUser;
            userType = getUserType(Username);

            this.ticket = ticket;

            SetLayout();

            lblTicketID.Text = ticket.TicketID.ToString();
            lblRaisedBy.Text = ticket.Username;
            lblDate.Text = ticket.TicketDate.ToShortDateString();
            cmbProblemType.Text = ticket.ProblemType;
            cmbAssignedTo.Text = ticket.TicketAssignedTo;
            rtbDescription.Text = ticket.TicketDescription;
            lblStatus.Text = ticket.TicketStatus;

            lblAssignedTo.Text = ticket.TicketAssignedTo;
            lblProblemType.Text = ticket.ProblemType;

            //to keep track of
            problemType = ticket.ProblemType;
            description = ticket.TicketDescription;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rDTables.userinfoTable' table. You can move, or remove it, as needed.
            this.userinfoTableTableAdapter.Fill(this.rDTables.userinfoTable);
        }

        private void SetLayout()
        {
            //if user logged in is an Admin or IT Support team member and the ticket is open, they can edit it or resolve it
            if (userType == "Admin" || userType == "IT Support Team")
            {
                if (ticket.TicketStatus == "Open")
                {
                    btnEdit.Visible = true;
                    btnResolve.Visible = true;
                }

            }
            //if user logged in is a report manager and the ticket is open, they can assign ticket to an IT Support Team member
            if (userType == "Report Manager")
            {
                if (ticket.TicketStatus == "Open")
                {
                    lblAssignedTo.Visible = false;
                    cmbAssignedTo.Visible = true;
                }
            }
            if (userType == "Project Member")
            {
                if (ticket.TicketStatus == "Resolved")
                {
                    btnReopen.Visible = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //IT Support Team and Admin nwill have access to this button
            if (btnEdit.Text == "Edit")
            {
                //when clicked form will switch into editing mode
                //btnEdit will say "Save", Issue type and description will be avaialable to change 
                btnEdit.Text = "Save";
                btnCancel.Visible = true;
                btnResolve.Visible = false;
                cmbProblemType.Visible = true;
                lblProblemType.Visible = false;
                rtbDescription.ReadOnly = false;
            }
            else
            {
                //clicked to save changes
                //message box asks user if they are sure they want to Save Changes
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your changes? Ticket will be updated.", "Save Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //will change form back to normal view mode w/ new changes
                    btnEdit.Text = "Edit";
                    btnCancel.Visible = false;
                    btnResolve.Visible = true;
                    description = rtbDescription.Text;
                    problemType = cmbProblemType.Text;

                    cmbProblemType.Visible = false;
                    lblProblemType.Text = problemType;
                    lblProblemType.Visible = true;

                    //save ticket changes to database
                    loadSavedChanges();

                }
                if (dialogResult == DialogResult.No)
                {
                    //nothing 
                }
            }
        }

        private static String getUserType(string Username)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if Adminn or IT Support team cancels their changes
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel? Your changes will not be saved.", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //revert issue
                cmbProblemType.Text = problemType;
                lblProblemType.Text = problemType;
                lblProblemType.Visible = true;
                cmbProblemType.Visible = false;
                //revert description
                rtbDescription.Text = description;
                rtbDescription.ReadOnly = true;
                //change visibility of buttons
                btnEdit.Text = "Edit";
                btnResolve.Visible = true;
                btnCancel.Visible = false;

            }
            if (dialogResult == DialogResult.No)
            {
                //nothing 
            }

        }

        private void cmbAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //report manager can change which IT Support Team member is assigned to the ticket
            assignedTo = cmbAssignedTo.Text;
            //will update in database automatically
            loadAssignedTo();

        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            //Admin or IT Support Team member can Resolve button to close/solve ticket
            //prompts user if they are sure
            DialogResult dialogResult = MessageBox.Show("Ticked will no longer be open. Remember to add the solution in the description for future reference!", "Solve Ticket", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                status = "Resolved";
                lblStatus.Text = status;
                btnResolve.Visible = false;
                btnEdit.Visible = false; 
                //change status of ticket in database
                loadStatus();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                //nothing 
            }

        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            //Project member can click button to reopen a closed ticket
            //prompts user if they are sure
            DialogResult dialogResult = MessageBox.Show("Ticked will no longer be open. Remember to add the solution in the description for future reference!", "Solve Ticket", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                status = "Open";
                lblStatus.Text = status;
                btnReopen.Visible = false;
                //change status of ticket in database
                loadStatus();
            }
            if (dialogResult == DialogResult.Cancel)
            {
                //nothing 
            }
        }

        private void loadSavedChanges() //saves edits made by Admin or IT Support Team
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

                cmd.CommandText = "UPDATE ticketTable SET problemType = @probtype, ticketDescription = @description WHERE ticketID = @ticketid";

                cmd.Parameters.AddWithValue("@ticketid", ticket.TicketID);
                cmd.Parameters.AddWithValue("@probtype", problemType);
                cmd.Parameters.AddWithValue("@description", description);
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
        private void loadAssignedTo() //saves who is now assigned to the ticket in database
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

                cmd.CommandText = "UPDATE ticketTable SET ticketAssignedTo = @assigned WHERE ticketID = @ticketid";

                cmd.Parameters.AddWithValue("@ticketid", ticket.TicketID);
                cmd.Parameters.AddWithValue("@assigned", assignedTo);
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
        private void loadStatus()//channges the status of the ticket inn the database to "Open" or "Resolved"
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

                cmd.CommandText = "UPDATE ticketTable SET ticketStatus = @status WHERE ticketID = @ticketid";

                cmd.Parameters.AddWithValue("@ticketid", ticket.TicketID);
                cmd.Parameters.AddWithValue("@status", status);
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
    }
}

          
