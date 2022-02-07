using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Mercy Sholola version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        
        private double miles;
        
        private double feet;
        /// <summary>
        /// This method shows that the program will input thr distance that is measured in miles,
        /// will calculate the same distance in feet, and finally output the distance also in
        /// feet.
        /// </summary>
        public void Run()
        { 
            OutputHeading();  
          InputMiles();
          CalculateFeet();
          OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("      Convert Miles to Feet               ");
            Console.WriteLine("         by Mercy Sholola                 ");
            Console.WriteLine("-------------------------------------------\n");
        }

        /// <summary>
        /// Prompt the user to enter distance in miles
        /// Input miles as a double digit
        /// </summary>
        private void InputMiles()
        {
            Console.Write("enter number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
           Console.WriteLine(miles + " miles is equal to " + feet + " feet!"); 
        }
    }
}
