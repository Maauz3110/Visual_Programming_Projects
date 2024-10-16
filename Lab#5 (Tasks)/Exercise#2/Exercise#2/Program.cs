using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Constructor
    public Customer(int customerID, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password)
    {
        CustomerID = customerID;
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
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }

    // Constructor
    public RetailCustomer(int customerID, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password, string creditCardType, string creditCardNo)
        : base(customerID, lastName, firstName, street, city, state, zipCode, phone, email, password)
    {
        CreditCardType = creditCardType;
        CreditCardNo = creditCardNo;
    }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public string FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }

    // Constructor
    public CorporateCustomer(int customerID, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password, string companyName, string frequentFlyerPts, string billingAccountNo)
        : base(customerID, lastName, firstName, street, city, state, zipCode, phone, email, password)
    {
        CompanyName = companyName;
        FrequentFlyerPts = frequentFlyerPts;
        BillingAccountNo = billingAccountNo;
    }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public Flight Flight { get; set; }

    // Constructor
    public Reservation(int reservationNo, DateTime date, Flight flight)
    {
        ReservationNo = reservationNo;
        Date = date;
        Flight = flight;
    }
}

public class Flight
{
    public int FlightID { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }
    public List<Seat> Seats { get; set; }

    // Constructor
    public Flight(int flightID, DateTime date, string origin, string destination, DateTime departureTime, DateTime arrivalTime, int seatingCapacity)
    {
        FlightID = flightID;
        Date = date;
        Origin = origin;
        Destination = destination;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        SeatingCapacity = seatingCapacity;
        Seats = new List<Seat>();
    }
}

public class Seat
{
    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; } // Available or Reserved

    // Constructor
    public Seat(int rowNo, int seatNo, decimal price, string status)
    {
        RowNo = rowNo;
        SeatNo = seatNo;
        Price = price;
        Status = status;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a flight
        Flight flight = new Flight(101, DateTime.Now, "New York", "Los Angeles", DateTime.Now.AddHours(5), DateTime.Now.AddHours(10), 200);

        // Add seats to the flight
        flight.Seats.Add(new Seat(1, 1, 500, "Available"));
        flight.Seats.Add(new Seat(1, 2, 500, "Reserved"));

        // Create a reservation
        Reservation reservation = new Reservation(1, DateTime.Now, flight);

        // Create a customer
        RetailCustomer customer = new RetailCustomer(1, "Smith", "John", "123 Main St", "New York", "NY", "10001", "123-456-7890", "john.smith@example.com", "password123", "Visa", "1234-5678-9012-3456");

        Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} has made a reservation for flight {flight.FlightID} on {reservation.Date}");
    }
}
