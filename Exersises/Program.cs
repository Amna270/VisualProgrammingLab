using System;

namespace lab4Exercise
{
    //This is the task no 1
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {
            name = null;
        }

        public Person(string n)
        {
            name = n;
        }
    }
    public class Student : Person
    {
        private string regNo;
        private int age;
        private string department;

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Student()
        {
            regNo = null;
            age = 0;
            department = null;
        }

        public Student(string name, string regNo, int age, string department) : base(name)
        {
            this.regNo = regNo;
            this.age = age;
            this.department = department;
        }
    }
    class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            Console.WriteLine($"Student1: Name={student1.Name}, RegNo={student1.RegNo}, Age={student1.Age}, Program={student1.Department}");

            Student student2 = new Student("Alice", "CS123", 20, "Computer Science");
            Console.WriteLine($"Student2: Name={student2.Name}, RegNo={student2.RegNo}, Age={student2.Age}, Program={student2.Department}");
        }
    }

    //this is the 2 task
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class RetailCustomer : Customer
    {
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public int FrequentFlyerPts { get; set; }
        public string BillingAccountNo { get; set; }
    }
    public class Reservation
    {
        public int ReservationNo { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
    public class Seat
    {
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int SeatingCapacity { get; set; }

    }
}
