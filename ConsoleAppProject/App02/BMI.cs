using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The main features of this app is to calculate a users BMI (weight and height)
    /// and also give the user options as to whether they would like the results in either
    /// imperial or metric measurements.
    /// </summary>
    /// <author>
    /// Mercy Sholola version 0.1
    /// </author>
    public class BMI
    {
        private double weight, height, bmi;
        private string measurement;
        private string weightUnit, heightUnit;
        
        public void Run()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("          BMI Calculator                  ");
            Console.WriteLine("         by Mercy Sholola                 ");
            Console.WriteLine("-------------------------------------------\n");
            int choice = InputChoice();
            ExecuteChoice();
        }

        private void ExecuteChoice()
        {
            throw new NotImplementedException();
        }

        private int InputChoice()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will ask the user if they would like to use imperial or metric
        /// measurements for their results
        /// </summary>
        public void GetMeasurementType()
        {
            Console.WriteLine("Would you like to use imperial measurements " + 
                              "(pounds and inches) or metric Measurements (kg and metres)" +
                              "\n Please Type M for Metric or I for imperial: ");
            measurement = Console.ReadLine();
            measurement = measurement.ToUpper();
        }

        /// <summary>
        /// This method will ask the user to enter their height and weight, and will also
        /// display the imperial or metric  measurements, depending on what they chose
        /// previously
        /// </summary>
        public void GetDetails()
        {
            string input;
            if (measurement == "I")
            {
                weightUnit = "lbs";
                heightUnit = "in";
            }

            if (measurement == "M")
            {
                weightUnit = "kg";
                heightUnit = "m";
            }

            Console.Write("Please enter your Weight(" + weightUnit + "): ");
            input = Console.ReadLine();
            weight = Convert.ToDouble(input);
            Console.Write("Please enter your Height(" + heightUnit + "):  ");
            input = Console.ReadLine();
            height = Convert.ToDouble(input);
        }

        /// <summary>
        /// This method will calculate the BMI in metric or imperial units using the height
        /// and weight entered in GetDetails above
        /// </summary>
        public void Calculate()
        {
            if (measurement == "M")
            {
                bmi = weight / (height * height);
            }
            else if (measurement == "I")
            {
                bmi = weight * 703 / (height * height);
            }

            Console.WriteLine(bmi);
        }

        /// <summary>
        /// This Method will display the users BMI showing them what category they fall into
        /// depending on their weight.
        /// </summary>
        public void Display()
        {
            if (bmi < 18.5)
            {
                Console.WriteLine("Bmi less than 18.5 … Under Weight");
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("Bmi 18.5 up to 25 … Average Weight");
            }
            else if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("Bmi 25 up to 30 … Over Weight");
            }
            else if (bmi > 30 && bmi <= 40)
            {
                Console.WriteLine("Bmi 30 up to 40 … Obese");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("Bmi 40 or over … Very Obese");
            }
            else
            {
                Console.WriteLine("There seems to be an error. Please try again");
            }
            
            /// <summary>
            /// This method will display a message that applies to the BAME groups
            /// </summary>
        }
    }
    public class message
    {
        public string BameWarning()
        {
            StringBuilder message = new StringBuilder("\n");

            Console.WriteLine("\n If you are Black, Asian or other minority " +
                              "ethnic groups, you have a higher risk." +
                              "\n Adults 23.0 or more are at increased risk" +
                              " Adults 27.5 or more are at high risk");

            return message.ToString();
        }
    }
}
    
    

 


