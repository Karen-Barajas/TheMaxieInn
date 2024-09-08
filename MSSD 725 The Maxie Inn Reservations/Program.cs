using MSSD_725_The_Maxie_Inn_Reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSD_725_The_Maxie_Inn_Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            DogInformation myDogInformation = new DogInformation(
                new DateTime(2017,5,19),
                "7 years old",
                "Jack Russell Terrier",
                "Male",
                "18 lbs",
                true,
                "Karen Barajas",
                "Max",
                new DateTime(2024,9,15),
                new DateTime(2024, 9, 25),
                "708-366-2490",
                "barakare@my.dom.edu"
                );

            myDogInformation.PrintProperties();           

            myDogInformation.Confirmation();

            myDogInformation.CalculateTotalCost();
            Console.WriteLine($"\nThe total cost of your reservation of {myDogInformation.Duration()} days is ${myDogInformation.CalculateTotalCost()}.");

            Console.ReadLine();
        }
    }
}