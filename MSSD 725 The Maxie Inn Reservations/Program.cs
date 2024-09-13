using MSSD_725_The_Maxie_Inn_Reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MSSD_725_The_Maxie_Inn_Reservations
{
    class Program
    {
        static void Main(string[] args)
        {            
            DogInformation myDogInformation = new DogInformation(
                new DateTime(2017, 5, 19),
                "7 years old",
                "Jack Russell Terrier",
                "Male",
                "18 lbs",
                true,
                "Karen Barajas",
                "Max",
                new DateTime(2024, 9, 15),
                new DateTime(2024, 9, 25),
                "708-366-2490",
                "barakare@my.dom.edu"
                );

            myDogInformation.Confirmation();

            myDogInformation.CalculateTotalCost();
            Console.WriteLine($"\nThe total cost of your reservation of {myDogInformation.Duration()} days is ${myDogInformation.CalculateTotalCost()}.");

            //System Reflection
            Type myDogInformationType = myDogInformation.GetType();

            Console.WriteLine("\nDog Reservation Summary:");

            foreach (PropertyInfo prop in myDogInformationType.GetProperties())

                if (prop.PropertyType == typeof(DateTime))
                {
                    DateTime dateValue = (DateTime)prop.GetValue(myDogInformation);
                    string formattedData = dateValue.ToString("MM/dd/yyyy");

                    Console.WriteLine($"\n{prop.Name}: {formattedData}");
                }
            else { 
                   
                Console.WriteLine($"\n{prop.Name}: {prop.GetValue(myDogInformation)}");
                
            }

            Console.ReadLine();
        }
    }
}