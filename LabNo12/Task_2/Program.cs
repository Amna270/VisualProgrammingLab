using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientAppointmentApp
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Appointment
    {
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>
            {
                new Patient { ID = 1, Name = "John Doe" },
                new Patient { ID = 2, Name = "Jane Smith" }
            };

            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor { ID = 1, Name = "Dr. Brown" },
                new Doctor { ID = 2, Name = "Dr. Green" }
            };

            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment { PatientID = 1, DoctorID = 1, AppointmentDate = DateTime.Now },
                new Appointment { PatientID = 2, DoctorID = 2, AppointmentDate = DateTime.Now.AddDays(1) }
            };

            var query = from appointment in appointments
                        join patient in patients on appointment.PatientID equals patient.ID
                        join doctor in doctors on appointment.DoctorID equals doctor.ID
                        select new
                        {
                            PatientName = patient.Name,
                            DoctorName = doctor.Name,
                            AppointmentDate = appointment.AppointmentDate
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Patient: {item.PatientName}, Doctor: {item.DoctorName}, Date: {item.AppointmentDate}");
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}