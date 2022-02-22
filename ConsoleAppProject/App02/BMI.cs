using System;

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

        /// <summary>
        /// This method will ask the user if they would like to use imperial or metric
        /// measurements for their results
        /// </summary>
        public void GetMeasurementType()
        {
            Console.WriteLine("Would you like to use imperial measurements (pounds and inches) or metric Measurements (kg and metres)\n Please Type M for Metric or I for imperial: ");
            measurement = Console.ReadLine();
            measurement = measurement.ToUpper();
        }

        /// <summary>
        /// This method will ask the user to enter their height and weight, and will also display the metric or imperial measurements, depending on what they chose previously.
        /// </summary>
        public void GetDetails()
        {
            string input;
            if (measurement == "I")
            {
                weightUnit = "Pound";
                heightUnit = "Inches";
            }

            if (measurement == "M")
            {
                weightUnit = "kg";
                heightUnit = "Metres";
            }

            Console.Write("Please enter your Weight(" + weightUnit + "): ");
            input = Console.ReadLine();
            weight = Convert.ToDouble(input);
            Console.Write("Please enter your Height(" + heightUnit + "):  ");
            input = Console.ReadLine();
            height = Convert.ToDouble(input);
        }

        /// <summary>
        /// This method will calculate the BMI in metric or imperial using the height and weigth entered in GetDetails
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
        /// This Method will display the BMI of the user letting them know what range there are in
        /// </summary>
        public void Display()
        {
            if (bmi < 18.5)
            {
                Console.WriteLine("Bmi less than 18.5 … UnderWeigth");
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("Bmi 18.5 up to 25 … Desirable Weigth for size");
            }
            else if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("Bmi 25 up to 30 … OverWeigth");
            }
            else if (bmi > 30 && bmi <= 40)
            {
                Console.WriteLine("Bmi 30 up to 40 … Obese");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("Bmi 40 or over … Severely Obese");
            }
            else
            {
                Console.WriteLine("Please try again, there seems to be an error");
            }
        }
    }
}
    
    

 


