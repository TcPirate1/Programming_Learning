using System;
using System.Collections.Generic;
using System.IO;

namespace Hospital
{
    public class Records : Patient
    {
        public static void Main()
        {   //Net 5.0
            
            /*Analysis of Data Structure: Yes, a Generic List was suitable for the task.
             * It is suitable because the List can be removed easily with one Remove method
             * and does not require a new array to be created and therefore is the most suitable structure for this task.
             * An Array List could of been used instead of an array, this also makes the data more easier to access but takes up
             * more memory than a Generic List as Array List takes extra space with each item added but Generic Lists
             * will change depending on the amount of items in the list without taking up any extra memory so a Generic List is prefered.
             */

            List<Patient> PatientRecords = new();

            ObtainRecords(PatientRecords);
            Console.WriteLine("\n**Patient records have been recorded successfully**");

            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("\nPress S for search, Press E for exit");
                string menu = Console.ReadLine().ToLower();
                switch (menu)
                {
                    case "s":
                        Console.WriteLine("Enter Patient ID:");
                        string pID = Console.ReadLine().ToUpper();
                        Search(PatientRecords, pID);
                        break;
                    case "e":
                        Console.WriteLine("\nBye...");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Bye...");
                        repeat=false;
                        break;
                }
            }
        }
        static List<Patient> ObtainRecords(List<Patient> Patients)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "ListOfPatients.txt");
            //Local file path

            string[] oneRecord = new string[4];

            Patient PR;

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    int counter = 0;

                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        

                        oneRecord = ln.Split(',');
                        PR = new Patient(oneRecord[0], oneRecord[1], oneRecord[2], oneRecord[3]);

                        Patients.Add(PR);
                        //Code to add Patient to the list
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"\nFile has {counter} lines.");
                }
            }
            return Patients;
        }
        static List<Patient> Search(List<Patient> records, string id)
        {
            //records and ID from main is passed
            Patient PR = records.Find(e => e.ID == id);

            if (PR == null)
            {
                Console.WriteLine("\nThe search found no result");
            }
            if (PR != null)
            {   //Need this to prevent NullReferenceException error
                if (PR.ID == id)
                {
                    PR.NewToString();
                    Console.WriteLine("\nWould you like to remove the Patient's record(s)?\nY or N?");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        records.Remove(PR);
                        Console.WriteLine("Record has been removed");
                    }
                }
            } return records;
        }
    }
}
