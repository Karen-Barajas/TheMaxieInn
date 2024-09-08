using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSD_725_The_Maxie_Inn_Reservations.Models
{
    //Base class
    public class DogReservation : IDogReservation
    {
        //List 5 properties
        public string OwnerName { get; set; }
        public string DogName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Constructor
        public DogReservation(string ownerName, string dogName, DateTime checkInDate, DateTime checkOutDate, string email, string phoneNumber)
        {
            OwnerName = ownerName;
            DogName = dogName;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //Methods

        //Calculate how long stay is
        public int Duration()
        {
            return (CheckOutDate - CheckInDate).Days;
        }
         
        private const int PricePerNight = 30;       
        
        public int CalculateTotalCost()
        {
            int duration = Duration();
            int totalCost = duration * PricePerNight;
            return totalCost;
        }        

        //Print properties method
        public virtual void PrintProperties() 
        {
            Console.WriteLine("Reservation Details:");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Dog Name: {DogName}");
            Console.WriteLine($"Check In Date: {CheckInDate.ToShortDateString()}");
            Console.WriteLine($"Check Out Date: {CheckOutDate.ToShortDateString()}");
            Console.WriteLine($"Owner's Email: {Email}");
            Console.WriteLine($"Owner's Phone Number: {PhoneNumber}");
        }

        //Display confirmation of reservation
        public virtual void Confirmation()
        {
            Console.WriteLine($"\nThank you, {OwnerName} for your reservation for {DogName} at The Maxie Inn. You have booked a stay at The Maxie Inn from {CheckInDate.ToShortDateString()} to {CheckOutDate.ToShortDateString()}. A confirmation email will be sent to {Email} soon. We are looking forward to {DogName}'s stay with us!");
        }
    }

    //Extended base class through inheritance
    public class DogInformation : DogReservation
    {        
        public DateTime DateOfBirth { get; set; }
        public string Age {  get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public bool SpayedOrNeutred { get; set; }        
        public DogInformation(DateTime dateOfBirth, string age, string breed, string sex, string weight, bool spayedOrNeutred, string ownerName, string dogName, DateTime checkInDate, DateTime checkOutDate, string phoneNumber, string email) : base(ownerName, dogName, checkInDate, checkOutDate, email, phoneNumber)
        {
            DateOfBirth = dateOfBirth;
            Age = age;
            Breed = breed;
            Sex = sex;
            Weight = weight;  
            SpayedOrNeutred = spayedOrNeutred;
        }

        //Print properties method
        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.WriteLine("\nAdditional Dog Information Provided:");            
            Console.WriteLine($"Dog's Name: {DogName}");
            Console.WriteLine($"Dog's Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Dog's Age: {Age}");
            Console.WriteLine($"Dog's Breed: {Breed}");
            Console.WriteLine($"Dog's Sex: {Sex}");
            Console.WriteLine($"Dog's Weight: {Weight}");
            Console.WriteLine($"Is Dog Spayed or Neutred? {SpayedOrNeutred}");
        }
    }   
}