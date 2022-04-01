using System;
using System.Collections.Generic;

namespace Ticket_system_2
{
    class Support:Ticket
    {
        public static void TeamResponse()
        {   //Method for submitting ticket
            List<Ticket>open=new List<Ticket>();
            List<Ticket>closed=new List<Ticket>();
            List<Ticket>reopen=new List<Ticket>();
            List<Ticket>tickets=new List<Ticket>();
            //Staff tickets
            Console.WriteLine("Enter 1 to submit a ticket.");
            string login1=Console.ReadLine();
            if (login1=="1")
            {   
                string run1="yes";
                while (run1=="yes"||run1=="Yes")
                {
                    Ticket staff;
                    Console.WriteLine("Enter your staff ID: ");
                    string staffID=Console.ReadLine();
                    Console.WriteLine("Enter your first name: ");
                    string first_name=Console.ReadLine();
                    Console.WriteLine("Enter your last name: ");
                    string last_name=Console.ReadLine();
                    Console.WriteLine("Enter your email: ");
                    string email=Console.ReadLine();
                    Console.WriteLine("Enter your issue: ");
                    string issue=Console.ReadLine();
                    string reply="";
                    Console.WriteLine("Ticket status: ");
                    string status=Console.ReadLine();
                    //Calls and generates a password when one is requested
                    if (first_name==""&&last_name==""&&email=="")
                    {
                        staff= new Ticket(staffID,issue,reply,status);
                        if(issue=="Password Change"||issue=="password change"&&status=="open"||status=="Open")
                        {
                            staff.set_response="Your new password is: "+PasswordGenerator.Conversion(staffID,staff.getTicketNumber());
                            staff.set_Status="Closed";
                            closed.Add(staff);
                        }
                        else if (issue!="Password Change"||issue!="password change")
                        {
                            closed.Add(staff);
                            int List4=closed.Count;
                            for(int i=0;List4<i;i++)
                            {
                                Console.WriteLine("Do you want to add a response to the ticket?\n(yes or no)");
                                string answer=Console.ReadLine();
                                if (answer=="yes"||answer=="Yes")
                                {
                                    Console.WriteLine("Type response here:");
                                    staff.set_response=Console.ReadLine();
                                    if (staff.set_response=="")
                                    {staff.set_response="Not yet provided";}
                                }
                                staff.set_Status="Closed";
                            }
                        }
                        else 
                        {
                            open.Add(staff);
                        }
                        tickets.Add(staff);
                    }
                    else if (first_name!=""&&last_name!=""&&email!="")
                    {
                        staff=new Ticket(staffID,first_name,last_name,email,issue,reply,status);
                        if(issue=="Password Change"||issue=="password change")
                        {
                            staff.set_response="Your new password is: "+PasswordGenerator.Conversion(staffID,staff.getTicketNumber());
                            staff.set_Status="Closed";
                            closed.Add(staff);
                        }
                        else 
                        {
                            open.Add(staff);
                        }
                        tickets.Add(staff);
                    }
                    int List=closed.Count;int List1=tickets.Count;int List2=open.Count;
                    for (int i=0;i<List1;i++)
                    {
                        tickets[i].ShowTicket_info();
                    }
                    Console.WriteLine("Do you want to submit another ticket?\n(Enter yes or no)");
                    run1=Console.ReadLine();
                }
            }
                    //Tickets can be changed here by IT team
                    Console.WriteLine("Hello IT team, here are the ticket details. Enter 2 to change a ticket status from open to closed.");
                    string login2=Console.ReadLine();
                    if (login2=="2")
                    {
                        int List=tickets.Count;
                        for (int i=0;i<List;i++)
                        {
                            Console.WriteLine("Ticket details:\n");
                            tickets[i].ShowTicket_info();
                        }
                            string run2="yes";
                            while(run2=="yes"||run2=="Yes")
                            {
                                Console.WriteLine("Enter the ticket number to change the status from open to closed");
                                int To_Change_Status=Convert.ToInt32(Console.ReadLine());
                                for (int i=0;i<List;i++)
                                {
                                    Ticket temp=tickets[i];
                                    if (temp.T_number==To_Change_Status)
                                    {
                                        temp.set_Status="Closed";
                                        closed.Add(temp);
                                        tickets.RemoveAt(i);
                                        List--;
                                        i--;
                                            Console.WriteLine("Do you want to add a response to the ticket?\n(yes or no)");
                                            string answer=Console.ReadLine();
                                            if (answer=="yes"||answer=="Yes")
                                            {
                                                Console.WriteLine("Type response here:");
                                                temp.set_response=Console.ReadLine();
                                                if (temp.set_response=="")
                                                {temp.set_response="Not yet provided";}
                                            }
                                            else if (answer == "no" || answer == "No")
                                            { temp.set_response = "Not yet provided"; }
                                    }
                                }
                                Console.WriteLine("Do you want to close another ticket?\n(enter yes or no)");
                                run2=Console.ReadLine();
                            }
                        Console.WriteLine("Updated tickets");
                        int List1=closed.Count;
                        for (int i=0;i<List1;i++)
                        {
                            closed[i].ShowTicket_info();
                        }
                    }
                    Console.WriteLine("Enter 3 to reopen a ticket.");
                    string login3=Console.ReadLine();
                    if (login3=="3")
                    {
                        int List=closed.Count;
                        for (int i=0;i<List;i++)
                        {
                            Console.WriteLine("Ticket details:\n");
                            closed[i].ShowTicket_info();
                        }
                        string run3="yes";
                        while(run3=="yes"||run3=="Yes")
                        {
                            Console.WriteLine("Enter the ticket number to reopen");
                            int To_Change_Status=Convert.ToInt32(Console.ReadLine());
                            for (int i=0;i<List;i++)
                            {
                                Ticket temp=closed[i];
                                if (temp.T_number==To_Change_Status)
                                {
                                    temp.set_Status="Reopened";
                                    reopen.Add(temp);
                                    closed.RemoveAt(i);
                                    List--;
                                    i--;
                                        Console.WriteLine("Do you want to add a response to the ticket?\n(yes or no)");
                                        string answer=Console.ReadLine();
                                        if (answer=="yes"||answer=="Yes")
                                        {
                                            Console.WriteLine("Type response here:");
                                            temp.set_response=Console.ReadLine();
                                            if (temp.set_response=="")
                                            {temp.set_response="Not yet provided";}
                                        }
                                        else if (answer == "no" || answer == "No")
                                        { temp.set_response = "Not yet provided"; }
                        }
                            }
                            Console.WriteLine("Do you want to reopen another ticket?\n(enter yes or no)");
                            run3=Console.ReadLine();
                        }
                        Console.WriteLine("Updated tickets");
                        int List1=reopen.Count;
                        for (int i=0;i<List1;i++)
                        {
                            reopen[i].ShowTicket_info();
                        }
                    }
                    //Returns the number of tickets to the Ticket_stats class
                int TotalTickets=tickets.Count;
                int openticket=open.Count;
                int closedticket=closed.Count;
                int reopenticket=reopen.Count;
                TicketStats.TicketStatistics(openticket,closedticket,reopenticket,TotalTickets);
        }
    }
}