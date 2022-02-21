using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Mercy Sholola version 0.1
    /// </author>
    public class BMI
    {
    }

    internal class Console
    {
        public static void WriteLine(string pleaseEnterYourWeightInKilograms)
        {
            throw new System.NotImplementedException();
        }

        public static bool ReadLine()
        {
            throw new NotImplementedException();
        }
    }

    internal class Private
    {
    }

    
        class Program
        {
            void Main(string[] args)
            {
                Console.WriteLine("Please enter your weight in kilograms: ");
                double weight = System.Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your height in meters: ");
                double height = 0;
                System.Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);

                try
                {
                    if (bmi <= 18.4)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Under Weight.");
                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Normal Weight.");
                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: Over Weight.");
                    }
                    else if (bmi >= 30 && bmi <= 34.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 1.");
                    }
                    else if (bmi >= 35 && bmi <= 39.9)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 2.");
                    }
                    else if (bmi >= 40)
                    {
                        Console.WriteLine($"Your body mass index is {bmi,0:F}. You are: in Obesity Class 3.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter reasonable values.");
                    }

                }
                catch (SystemException errors)
                {
                    Console.WriteLine("There was an error: " + errors.Message);
                }

                Console.ReadLine();

            }
        }
    }


