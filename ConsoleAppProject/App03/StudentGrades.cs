using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class tests the
    /// Grades enumeration names and descriptions to ensure correction
    /// </summary>
    public class StudentGrades
    {
        // Here are the constants that will be used for this project
        public const int LowestMark = 0;
        public const int LowestGradeF = 39;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;
        public const string AllowedChars = @"^[0-9]*$";

        // Here are the properties and how they will also be used
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public int AddMark { get; set; }

        private int studentIndex;
        
        public StudentGrades(int addMark)
        {
            AddMark = addMark;
            Students = new[]
            {
                "Mercy", "Eve", "Jacob",
                "Tomi", "Naomi", "Kyron",
                "Milan", "Manny", "Jessica",
                "Megan"
            };

            GradeProfile = new int[(int) Grades.A + 1];

            Marks = new int[Students.Length];
        }

        /// <summary>
        /// This method will help initiate the program
        /// and will call to other methods to show the options available, 
        /// select an option and output the heading
        /// </summary>
        public void Run()
        {
            OutputHeading();
            ShowOptions();
            SelectOption();
        }
        private void OutputHeading()
        {
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("        Student Marks           ");
            Console.WriteLine("        by Mercy Sholola        ");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine();
        }

        /// <summary>
        /// This method will display a list of options for the user to select from the menu given
        /// </summary>
        private void ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine(" 1. Input Marks | 2. Output Marks | 3. Output Stats");
            Console.WriteLine(" 4. Output Grade Profile | 5. Quit");

            //studentIndex = 0;
            SelectOption();
        }

        /// <summary>
        /// This method should prompt the user to select an option,
        /// in which the user will be prompted again only if an input from the user does
        /// not match an option from the list given
        /// </summary>
        private void SelectOption()
        {
            Console.Write("\n Please enter your choice > ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StudentMarks();
                    break;

                case "2":
                    OutputMarks();
                    break;

                case "3":
                    OutputStats();
                    break;

                case "4":
                    OutputGradeProfile();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine(" Invalid option.\n");
                    SelectOption();
                    break;
            }
        }

        /// <summary>
        /// This method calls other methods for the users to input student marks,
        /// calculate stats, calculate grade profile and show options again
        /// </summary>
        public void StudentMarks()
        {
            InputMarks();

            CalculateStats();

            CalculateGradeProfile();

            ShowOptions();
        }

        /// <summary>
        /// This method should input a mark between 0 - 100 for each
        /// student and store the value in the Marks array
        /// </summary>
        private void InputMarks()
        {
            Console.WriteLine("\n Please enter a mark for each student:\n");

            while (studentIndex < Students.Length)
            {
                Console.Write($" Mark for {Students[studentIndex]} > ");

                Console.ReadLine();

                ValidateInput();

                Marks[studentIndex] = AddMark;

                studentIndex++;
            }

            studentIndex = 0;
        }

        private void ValidateInput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will list all the students and display their
        /// name and current mark
        /// </summary>
        public void OutputMarks()
        {
            Console.WriteLine("\n Student marks:");

            int i = 0;
            while (i < Students.Length)
            {
                Console.Write($"\n Mark for {Students[i]} > {Marks[i]}");

                i++;
            }

            Console.WriteLine("\n");

            ShowOptions();
        }

        /// <summary>
        /// This method will be used to convert the students mark to a grade,
        /// from F (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }

            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }

            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }

            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }

            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }

            return Grades.A;
        }

        /// <summary>
        /// This method should be used to calculate and display the minimum, maximum,
        /// and mean mark for all the students mentioned
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;

                if (mark < Minimum) Minimum = mark;

                total += mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// This method will display the maximum, minimum and mean marks for the grades
        /// </summary>
        private void OutputStats()
        {
            Console.WriteLine($"\n Maximum mark is {Maximum}");
            Console.WriteLine($" Minimum mark is {Minimum}");
            Console.WriteLine($" Mean mark is {Mean}\n");

            ShowOptions();
        }

        /// <summary>
        /// This method calculates the grade profile for the class of students
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                ConvertToGrade(mark);
            }
        }

        /// <summary>
        /// This method should display the grade profile for the class of students
        /// </summary>
        private void OutputGradeProfile()
        {
            Grade grade = Grade.F;

            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;

                Console.WriteLine($" Grade {grade} {percentage}% Count {count}");

            }

            Console.WriteLine();

            ShowOptions();
        }

    }

    internal class Grade
    {
        public static Grade F => null;
    }
}
