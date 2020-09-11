using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Registration
{
    public class Ticket
    {

        public int TicketID { get; set; }
        public string Username { get; set; }
        public string ProblemType { get; set; }
        public string TicketPriority { get; set; }
        public string TicketAssignedTo { get; set; }
        public DateTime TicketDate { get; set; }
        public string TicketDescription { get; set; }
        public string TicketStatus { get; set; }


        //public readonly int UserId;
        //gives the user a random password that they are able to change
        // needs to be in ever user interface



        public Ticket(int ticketID, string ticketPriority, DateTime ticketDate, string username, string problemType,
        string ticketAssignedTo, string ticketDescription, string ticketStatus)
        {
            TicketID = ticketID;
            TicketPriority = ticketPriority;
            Username = username;
            TicketAssignedTo = ticketAssignedTo;
            ProblemType = problemType;
            TicketDate = ticketDate;
            TicketDescription = ticketDescription;
            TicketStatus = ticketStatus;
        }

        public override string ToString()
        {
            return string.Format("TICKET ID: {0,-10} PRIORITY: {1, -15} ISSUE: {3, -40} RAISED BY: {4, -15} ASSIGNED TO: {5, -15} DATE: {2, -25} DESCRIPTION: {6}",
                TicketID, TicketPriority, TicketDate, ProblemType, Username, TicketAssignedTo, TicketDescription);
        }
    }
}
