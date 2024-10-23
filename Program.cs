using System;

namespace FlightSystem
{
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
        public string Email{get; set; }
        public string Password { get; set; }

        public Customer(int customerId, string lastName, string firstName, string phone)
        {
            CustomerId = customerId;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }
        public Customer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password)
        {
            CustomerId = customerId;
            LastName = lastName;
            FirstName = firstName;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
            Email = email;
            Password = password;

        }
        public void Display()
        {
            Console.WriteLine($"Customer Information:");
            Console.WriteLine($"  Customer ID: {CustomerId}");
            Console.WriteLine($"  Name: {LastName}, {FirstName}");
            Console.WriteLine($"  Phone: {Phone}");
        }
    }

    public class RetailCustomer : Customer
    {
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }

        public RetailCustomer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password, string creditCardType, string creditCardNo)
            : base(customerId, lastName, firstName, street, city, state, zipCode, phone, email, password)
        {
            CreditCardType = creditCardType;
            CreditCardNo = creditCardNo;

        }
    }

    public class Reservation
    {
        public int ReservationNo { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }

        public Reservation(int reservationNo, DateTime date, Customer customer)
        {
            ReservationNo = reservationNo;
            Date = date;
            Customer = customer;
        }
        public void Display()
        {
            Console.WriteLine($"Reservation Information:");
            Console.WriteLine($"  Reservation Number: {ReservationNo}");
            Console.WriteLine($"  Date: {Date.ToString("yyyy-MM-dd HH:mm:ss")}"); // Format the date as needed
            Console.WriteLine($"  Customer Name: {Customer.FirstName} {Customer.LastName}");
        }
    }

    public class Seat
    {
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        public Seat(int rowNo, int seatNo, decimal price, string status)
        {
            RowNo = rowNo;
            SeatNo = seatNo;
            Price = price;
            Status = status;
        }
        public void Display()
        {
            Console.WriteLine($"Seat Information:");
            Console.WriteLine($"  Row: {RowNo}");
            Console.WriteLine($"  Seat Number: {SeatNo}");
            Console.WriteLine($"  Price: {Price}");
            Console.WriteLine($"  Status: {Status}");
        }
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

        public Flight(int flightId, DateTime date, string origin, string destination, DateTime departureTime, DateTime arrivalTime, int seatingCapacity)
        {
            FlightId = flightId;
            Date = date;
            Origin = origin;
            Destination = destination;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            SeatingCapacity = seatingCapacity;

        }
        public void Display()
        {
            Console.WriteLine("Flight Information:");
            Console.WriteLine($"  Flight ID: {FlightId}");
            Console.WriteLine($"  Date: {Date.ToString("yyyy-MM-dd HH:mm:ss")}"); // Format the date as needed
            Console.WriteLine($"  Origin: {Origin}");
            Console.WriteLine($"  Destination: {Destination}");
            Console.WriteLine($"  Departure Time: {DepartureTime.ToString("yyyy-MM-dd HH:mm:ss")}"); // Format the departure time as needed
            Console.WriteLine($"  Arrival Time: {ArrivalTime.ToString("yyyy-MM-dd HH:mm:ss")}"); // Format the arrival time as needed
            Console.WriteLine($"  Seating Capacity: {SeatingCapacity}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create instances of different classes
            Console.WriteLine("\t\tFLIGHT SYSTEM");
            Console.WriteLine();
            Console.WriteLine("\tCUSTOMER INFORMATION");
            Console.WriteLine();
            Console.Write("Enter your First name: ");
            String Lname=Console.ReadLine();
            Console.Write("Enter your Last name: ");
            String Fname = Console.ReadLine();
            Console.Write("Enter your Phone number: ");
            String phone = Console.ReadLine();
            Customer customer= new Customer(1,Lname,Fname,phone);

            Console.Write("\n\n" + "\t\tRESERVATION");
            Console.WriteLine();
            Console.Write("\n" + "There are two flights avaiable which one do you want to reseve.");
            Console.Write("\n" + "Flight 1 or 2.");
            Console.Write("\n" + "Enter the Flight you want to reserve: ");
            int f1= Convert.ToInt32(Console.ReadLine());
            if (f1 == 1)
            {
                Flight flight1 = new Flight(1, DateTime.Now, "New York", "Los Angeles", DateTime.Now, DateTime.Now.AddHours(5), 100);
                Console.WriteLine();
                flight1.Display();
                Reservation reservation1 = new Reservation(1, DateTime.Now, customer);
                Seat seat1 = new Seat(1, 24, 110.00m, "Available");
                Console.WriteLine();
                seat1.Display();

            }
            else
            {
                Flight fligh2 = new Flight(2, DateTime.Now, "London", "New York", DateTime.Now, DateTime.Now.AddHours(6), 50);
                Console.WriteLine();
                fligh2.Display();
                Reservation reservation2 = new Reservation(1, DateTime.Now, customer);
                Seat seat2 = new Seat(1, 1, 100.00m, "Available");
                Console.WriteLine();
                seat2.Display();
            }
        }
    }
}