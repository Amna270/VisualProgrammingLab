using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
namespace RideShare
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phoneNumber {  get; set; }
        public User() 
        {

        }
        public void register( string n, string pn)
        {
            name = n;
            phoneNumber = pn;
        }
        public void login(int i, string n)
        {
            if(id==i && name==n)
            {
                Console.WriteLine("Login Successfull!!");
            }
            else
            {
                Console.WriteLine("Login Unsuccessfull!!");
            }
        }
        public void displayProfile()
        {
            Console.WriteLine("User Profile");
            Console.WriteLine($"UserID : {id}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Phone Number : {phoneNumber}");
        }
    }
    public class Rider: User
    {
        public List<Trip> trips {  get; set; }
        public Rider()
        {
            trips= new List<Trip>();
        }
        public Rider(string n, string  pn)
        {
            name = n;
            phoneNumber = pn;
        }
        public void requestRide(string sl, string d)
        {
            Trip new_ride = new Trip(sl, d);
            trips.Add(new_ride);
        }
        public void viewRideHistory()
        {
            foreach(Trip trip in trips)
            {
                trip.rideHistory();
            }
        }
    }
    public class Driver: User
    {
        public string driverID {  get; set; }
        public string vehicleDetail {  get; set; }
        public bool isAvailable { get; set; } = true;
        public List<Trip> tripHistory { get; set; }
        public Driver()
        {
            tripHistory= new List<Trip>();
        }
        public Driver(string dID, string VH)
        {
            driverID = dID;
            vehicleDetail = VH;
        }
        public void acceptRide(string sl, string d)
        {
            Trip new_ride = new Trip(sl, d);
            tripHistory.Add(new_ride);
            
        }
        public void viewTripHistory()
        {
            foreach(Trip trip in tripHistory)
            {
                trip.displayTripDetails();
            }
        }
        public bool toggelAvailability()
        {
            if(isAvailable==true)
            {
                isAvailable = false;
            }
            return false;
        }
    }
    public class Trip
    {
        public int tripID {  get; set; }
        public string riderName {  get; set; }
        public string driverName { get; set; }
        public string startLocation { get; set; }
        public string destination {  get; set; }
        public double fare {  get; set; }
        public bool status {  get; set; }
        public Trip()
        {
            
        }
        public Trip(string sl, string d)
        {
            startLocation = sl;
            destination = d;
            status = true;
        }
        public double calculateFare()
        {
            fare = 25;
            Console.WriteLine($"Fare: {fare}");
            return fare;
        }
        public void startTrip(string sl)
        {
            startLocation = sl;
        }
        public void endTrip(string d)
        {
            destination = d;
        }
        public void displayTripDetails()
        {
            Console.WriteLine("All Trips:");
            Console.WriteLine($"TripID: {tripID++}, Rider: {riderName}, Driver: {driverName},Fron: {startLocation}, To: {destination}, Fare: 25");
        }
        public void rideHistory()
        {
            Console.WriteLine("Your Ride History:");
            Console.WriteLine($"TripID: {tripID++}, Fron: {startLocation}, To: {destination}, Fare: 25");
        }
        public void completeTrip()
        {
            Console.WriteLine($"Trip from {startLocation} to {destination} has been completed.Fare 25");
        }
        public void accepetride()
        {
            if (status == true)
            {
                Console.WriteLine("Request accepted.");
            }
            else
            {
                Console.WriteLine("Request not accepted.");
            }
        }
    }
    public class RideSharingSystem
    {
        public List<Rider> registeredRiders { get; set; }
        public List<Driver> registeredDrivers { get; set; }
        public List<Trip> availaableTrips { get; set; }
        public RideSharingSystem()
        {
            registeredRiders = new List<Rider>();
            registeredDrivers = new List<Driver>();
            availaableTrips = new List<Trip>();
        }
        public void registerUser(string n, string pn)
        {
            registeredRiders.Add(new Rider(n, pn));
        }
        public void registerDriver(string n, string vh)
        {
            registeredDrivers.Add(new Driver(n, vh));
        }
        public void requestRide(string sloc, string des)
        {
            Trip new_ride = new Trip(sloc, des);
            availaableTrips.Add(new_ride);
        }
    }
    class Program
    {
        static void Main()
        {
            RideSharingSystem rideSharingSystem = new RideSharingSystem();
            Trip trip=new Trip();
            string ridname, phone,dirname, v;
            bool start=false;
            int choice = 0;
            while (!start)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Ride-Sharing System");
                Console.WriteLine("1.Register Rider.");
                Console.WriteLine("2.Register Driver.");
                Console.WriteLine("3.Request a Ride.");
                Console.WriteLine("4.Accept a Ride.");
                Console.WriteLine("5.Complete a Trip.");
                Console.WriteLine("6.View Ride History.");
                Console.WriteLine("7.View Trip History.");
                Console.WriteLine("8.Display All Trip.");
                Console.WriteLine("9.Exit.");
                Console.WriteLine();
                Console.Write("Please choice an option: ");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter your name: ");
                        ridname = Console.ReadLine();
                        Console.Write("Enter your phone number: ");
                        phone = Console.ReadLine();
                        rideSharingSystem.registerUser(ridname, phone);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter Driver name: ");
                        dirname = Console.ReadLine();
                        Console.Write("Enter Vehicle detail: ");
                        v = Console.ReadLine();
                        rideSharingSystem.registerUser(dirname, v);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter your current location: ");
                        string current = Console.ReadLine();
                        Console.Write("Enter your destination: ");
                        string destination = Console.ReadLine();
                        trip=new Trip(current, destination);
                        Console.WriteLine();
                        break;
                    case 4:
                        trip.accepetride();
                        break;
                    case 5:
                        trip.completeTrip();
                        break;
                    case 6:
                        trip.rideHistory();
                        break;
                    case 7:
                        trip.completeTrip();
                        break;
                    case 8:
                        trip.displayTripDetails();
                        break;
                    case 9:
                        start = true;
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using our Application.");
                        break;
                    default:
                        Console.WriteLine("Entered an invalid choice");
                        break;
                }
            }
            
        }
    }
}