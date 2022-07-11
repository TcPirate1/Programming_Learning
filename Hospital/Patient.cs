using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient
    {
        private string PatientId;
        private string PatientName;
        private string CheckInDate;
        private string PersonnelAssigned;

        public string ID
        {
            get { return PatientId; }
            set { PatientId = value; }
        }
        public string Name
        {
            get { return PatientName; }
            set { PatientName = value; }
        }
        public string Checkin
        {
            get { return CheckInDate; }
            set { CheckInDate = value; }
        }
        public string AssignedPersonnel
        {
            get { return PersonnelAssigned; }
            set { PersonnelAssigned = value; }
        }

        public Patient(string patientID, string name, string date, string personnel)
        {
            ID = patientID;
            Name = name;
            Checkin = date;
            AssignedPersonnel = personnel;
        }
        public Patient() { }

        public void NewToString()
        {
            Console.WriteLine($"Patient ID: {ID}\nName: {Name}\nCheck In Date: {Checkin}\nAssigned Medical Personnel: {AssignedPersonnel}");
        }
    }
}
