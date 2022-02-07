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
        private double miles;
        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
          InputMiles();
          CalculateFeet();
          OutputFeet();
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
            
        }

        private void OutputFeet()
        {
            
        }
    }
}
