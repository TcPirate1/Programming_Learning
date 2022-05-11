using System;

namespace Ticket_system_2
{
    class Ticket
    {
        //Attributes of the tickets
        public static int number=2000;
        private int Ticket_Number;
        public int T_number
        {get {return Ticket_Number;}}
        private string StaffID;
        private string FName;
        private string SName;
        private string email;
        private string description;
        private string response;
        public string set_response
        {get{return response;}set{response=value;}}
        private string status;
        public string set_Status
        {set{status=value;}}
        
        //The two constructors represents the two ways someone can submit a ticket.
        public Ticket (string B_StaffID, string B_FName, string B_SName, string B_email, string B_description, string B_response, string B_status)
        {
            number++;
            Ticket_Number=number;
            StaffID=B_StaffID;
            FName=B_FName;
            SName=B_SName;
            email=B_email;
            description=B_description;
            response=B_response;
            status=B_status;
        }
        public Ticket (string B_StaffID, string B_description,string B_response, string B_status)
        {
            number++;
            Ticket_Number=number;
            StaffID=B_StaffID;
            FName="Not specified";
            SName="Not specified";
            email="Not specified";
            description=B_description;
            response=B_response;
            status=B_status;
        }
        public Ticket() //Empty Constructor for Support class otherwise it cannot access the ticket class
        {}

        //This method wil be called when we want to show the ticket information
        public void ShowTicket_info()
        {
            if (FName=="Not specified"&&SName=="Not specified")
            {
                Console.WriteLine("\nTicket number: "+Ticket_Number+"\nStaff ID: "+StaffID+"\nFirst Name: "+FName+"\nSurname: "+SName+"\nEmail: "+email+"\nDescription of issue: "+description+"\nTeam Response: "+response+"\nTicket status: "+status+"\n");
            }
            else
            {
                Console.WriteLine("\nTicket number: "+Ticket_Number+"\nStaff ID: "+FName.Substring(0,1).ToUpper()+FName.Substring(1)+SName.Substring(0,1).ToUpper()+"\nFirst Name: "+FName+"\nSurname: "+SName+"\nEmail: "+email+"\nDescription of issue: "+description+"\nTeam Response: "+response+"\nTicket status: "+status+"\n");
            }
        }
    }

}