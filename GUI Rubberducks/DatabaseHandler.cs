using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GUI_Registration;

namespace GUI_Registration_p1
{
    class DatabaseHandler
    {
        // Declare a SQLConnection automatic property
        public SqlConnection cn { get; set; }
        public DatabaseHandler(string connection) // Constructor
        {
            // Error handling
            try
            {
                cn = new SqlConnection(); // Create an instance of a new SqlConnection

                cn.ConnectionString = connection;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection.");
            }
            finally
            {
                cn.Close();
            }
        }

        // Method takes a list of Car objects and saves them to a SqlServer Database table
        public void InsertDataToDb(List<GUI_Registration.Ticket> tickets)
        {
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO ticketTable (ticketID, username, ticketPriority, ticketAssignedTo, problemType, ticketDate, ticketDescription, ticketStatus) VALUES " +
                    "(@ticketID, @username, @ticketPriority, @ticketAssignedTo, @problemType, @ticketDate, @ticketDescription, @ticketStatus)");

                cmd.Connection = cn;

                // Traverse the list of cars
                foreach (var t in tickets)
                {
                    cmd.Parameters.Clear(); // Clear the previous parameter values

                    // Populate the query parameters with actual values take from each Car object
                    cmd.Parameters.AddWithValue("@ticketID", t.TicketID);
                    cmd.Parameters.AddWithValue("@ticketPriority", t.TicketPriority);
                    cmd.Parameters.AddWithValue("@username", t.Username);
                    cmd.Parameters.AddWithValue("@ticketAssignedTo", t.TicketAssignedTo);
                    cmd.Parameters.AddWithValue("@problemType", t.ProblemType);
                    cmd.Parameters.AddWithValue("@ticketDate", t.TicketDate);
                    cmd.Parameters.AddWithValue("@ticketDescription", t.TicketDescription);
                    cmd.Parameters.AddWithValue("@ticketStatus", t.TicketStatus);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with inserting data to the database!");
            }
            finally
            {
                cn.Close();
            }
        }

        // Method to load data from a database table into a list of Employee objects
        public List<GUI_Registration.Ticket> LoadDataFromDb()
        {
            // Declare a list of Car objects
            List<GUI_Registration.Ticket> tickets;

            tickets = new List<GUI_Registration.Ticket>(); // Instantiate the cars list

            try
            {
                GUI_Registration.Ticket tempTicket;

                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ticketTable ORDER BY CASE ticketPriority WHEN 'High' THEN 1 WHEN 'Medium' THEN 2 WHEN 'Low' THEN 3 END, ticketDate, ticketID", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int ticketID = (int)reader["ticketID"];
                    string ticketPriority = (string)reader["ticketPriority"];
                    string username = (string)reader["username"];
                    string ticketAssignedTo = (string)reader["ticketAssignedTo"];
                    string problemType = (string)reader["problemType"];
                    DateTime ticketDate = (DateTime)reader["ticketDate"];
                    string ticketDescription = (string)reader["ticketDescription"];
                    string ticketStatus = (string)reader["ticketStatus"];

                    tempTicket = new GUI_Registration.Ticket(ticketID, ticketPriority, ticketDate, username, problemType, ticketAssignedTo, ticketDescription, ticketStatus);

                    tickets.Add(tempTicket);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with loading data from the database!");
            }
            finally
            {
                cn.Close();
            }

            return tickets;
        }


    }
}