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

namespace GUI_Registration
{
    public partial class TicketCreationForm : Form
    {

		//verifies user is the actual creator of the ticket
		public string Username = EmployeeLoginForm.enteredUser;
		private DateTime ticketFileDate;

		private void TicketCreationForm_Load(object sender, EventArgs e)
		{
			txtUsername.Text = getUsername(Username);
		}


		public TicketCreationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

				cmd.CommandText = ("INSERT INTO ticketTable (ticketID, username, ticketPriority, ticketAssignedTo, problemType, ticketDate, ticketDescription, ticketStatus) " +
					" VALUES (@ticketID, @username, @ticketPriority, @ticketAssignedTo, @problemType, @ticketDate, @ticketDescription, @ticketStatus)");
				cmd.Parameters.AddWithValue("ticketID", GenerateTicketID());
				cmd.Parameters.AddWithValue("username", txtUsername.Text.Trim());
				cmd.Parameters.AddWithValue("ticketPriority", TicketClassification());
				cmd.Parameters.AddWithValue("ticketAssignedTo", "Unassigned");
				cmd.Parameters.AddWithValue("problemType", cmboxProblemType.Text);
				cmd.Parameters.AddWithValue("ticketDate", dtpCompletionDate.Value);
				cmd.Parameters.AddWithValue("ticketDescription", richTextBox1.Text);
				cmd.Parameters.AddWithValue("ticketStatus", "Open");

				//now execute the sqlCommand
				cmd.ExecuteNonQuery();

				MessageBox.Show("Your ticket was successfully submitted.");
			}
			catch (Exception err)
			{
				//it handles any other errors
				MessageBox.Show(err.Message, "Warning!");
			}
			finally
			{
				cn.Close(); //Close connection regardless of any errors or not
				this.Hide();
			}
		}

		private String TicketClassification()
		{
			ticketFileDate = dtpCompletionDate.Value;

			if (ticketFileDate > (DateTime.Now.AddDays(-7)))
			{
				return "Low";
			}
			else if (ticketFileDate <= (DateTime.Now.AddDays(-7)) && ticketFileDate > (DateTime.Now.AddDays(-14)))

			{
				return "Medium";
			}
			else if (ticketFileDate <= (DateTime.Now.AddDays(-14)))
			{
				return "High";
			}
			else
			{
				return "High";
			}
		}

		private string GenerateTicketID()
		{
			Random random = new Random();
			int ticketid = random.Next(1000, 9999);
			return ticketid.ToString();
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
	}
}
