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
using GUI_Registration_p1;

namespace GUI_Registration_p1
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void MockReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rDTables.userinfoTable' table. You can move, or remove it, as needed.
            this.userinfoTableTableAdapter.Fill(this.rDTables.userinfoTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsbUsername.Text.Trim() == (getUsername(lsbUsername.Text).Trim()))
            {

                MessageBox.Show("Report sent to " + getEmail(lsbUsername.Text).Trim() + ".", "Report Sent!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
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
    }
}
