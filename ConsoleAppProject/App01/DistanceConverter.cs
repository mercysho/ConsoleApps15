using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The main features of this app is to 
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
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("      Convert Miles to Feet               ");
            Console.WriteLine("         by Mercy Sholola                 ");
            Console.WriteLine("-------------------------------------------\n");
            int choice = InputChoice();
            ExcecuteChoice(choice);
        }
        
        /// <summary>
        /// This method will give the user the options to either convert the value they
        /// have chosen from miles to feet or feet to miles.
        /// </summary>
        private int InputChoice()
        {
            Console.WriteLine("Do you want to convert miles to feet or feet to miles?");
            Console.WriteLine("1.Miles to feet");
            Console.WriteLine("2.Feet to miles");
            
            int value = Console.Read();

            if (value == 1)
            {
                return value;
            }
            else if (value == 2)
            {
                return value;
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Please choose either 1 or 2" );
                return 0;
            }
        }

        private void ExcecuteChoice(int choice)
        {
            if (choice == 1)
            {
                InputMiles(); 
                CalculateFeet(); 
                OutputFeet();
            }
            else if (choice == 2)
            {
                InputMiles(); 
                CalculateFeet(); 
                OutputFeet();
            }
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
