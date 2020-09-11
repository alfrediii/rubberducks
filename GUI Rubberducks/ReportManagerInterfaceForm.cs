using GUI_Registration;
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
using System.Data.SqlClient;

namespace GUI_Registration_p1
{
	public partial class ReportManagerInterfaceForm : Form
	{
		public string Username = EmployeeLoginForm.enteredUser;

		//user that is logged in
		public Employee employee;
		private Ticket ticket;

		public List<GUI_Registration.Ticket> tickets;
		public List<GUI_Registration.Ticket> openTickets;
		public List<GUI_Registration.Ticket> closedTickets;

		private DatabaseHandler objDBHandler;

		const string cn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =
            \\Mac\Home\Desktop\GUI Rubberducks\rubberDuckDatabase.mdf";
		public ReportManagerInterfaceForm(Employee emp)
		{
			InitializeComponent();
			employee = emp;
			objDBHandler = new DatabaseHandler(cn);
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//message box asks user if they are sure they want to logout
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout? If you click OK you will be logged out.", "Logout", MessageBoxButtons.OKCancel);
			if (dialogResult == DialogResult.OK)
			{
				this.Hide();

				System.Media.SoundPlayer player = new System.Media.SoundPlayer();
				player.SoundLocation = @"\\Mac\Home\Desktop\GUI Rubberducks\bye.wav";
				player.Load();
				player.Play();

				EmployeeLoginForm login = new EmployeeLoginForm();
				login.Show();
			}
			if (dialogResult == DialogResult.Cancel)
			{
				//nothing -- user doesn't logout
			}
		}

		private void btnRaise_Click(object sender, EventArgs e)
		{
			TicketCreationForm createTicket = new TicketCreationForm();
			createTicket.Show();
		}

		private void ReportManagerInterface_Load(object sender, EventArgs e)
		{
			tickets = objDBHandler.LoadDataFromDb();
			lsbTickets.Items.AddRange(tickets.ToArray());
		}

		private void btnOnlineHelp_Click(object sender, EventArgs e)
		{
			FAQForm faq = new FAQForm();
			faq.Show();
		}

		private void profileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProfileForm profile = new ProfileForm(Username);
			profile.Show();
		}

		private void reportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReportForm report = new ReportForm();
			report.Show();
		}

		private void ReportManagerInterface_FormClosed(object sender, FormClosedEventArgs e)
		{
			EmployeeLoginForm login = new EmployeeLoginForm();
			login.Show();
		}

		private void btnViewTicket_Click(object sender, EventArgs e)
		{
			try
			{
				TicketForm ticketForm = new TicketForm(ticket);
				ticketForm.Show();
			}
			catch
			{
				MessageBox.Show("Please select a ticket to view.", "Error");
			}
		}

		private void btnSolvedTicket_Click_1(object sender, EventArgs e)
		{
			tickets = objDBHandler.LoadDataFromDb();
			closedTickets = new List<GUI_Registration.Ticket>();

			foreach (var t in tickets)
			{
				if (t.TicketStatus == "Resolved")
				{
					closedTickets.Add(t);
				}
			}

			lsbTickets.Items.Clear();
			lsbTickets.Items.AddRange(closedTickets.ToArray());
		}

		private void btnOpenTicket_Click(object sender, EventArgs e)
		{
			tickets = objDBHandler.LoadDataFromDb();
			openTickets = new List<GUI_Registration.Ticket>();

			foreach (var t in tickets)
			{
				if (t.TicketStatus == "Open")
				{
					openTickets.Add(t);
				}
			}

			lsbTickets.Items.Clear();
			lsbTickets.Items.AddRange(openTickets.ToArray());
		}

		private void lsbTickets_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (lsbTickets.SelectedItem != null)
			{
				ticket = (Ticket)lsbTickets.SelectedItem;
			}
			if (lsbTickets.SelectedItem == null)
			{
				MessageBox.Show("You have not selected a ticket.", "Error!");
			}
		}
	}
}
