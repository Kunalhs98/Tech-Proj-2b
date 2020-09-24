using System;

namespace Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value of the grade you expect to get in ISM 4300: ");
             
            try
            {
                int grade;
                grade = int.Parse(Console.ReadLine());

                if ((grade >= 93) && (grade <= 100)) Console.WriteLine("Grade A");
                else if ((grade >= 90) && (grade <= 92)) Console.WriteLine("Grade A-");
                else if ((grade >= 87) && (grade <= 89)) Console.WriteLine("Grade B+");
                else if ((grade >= 83) && (grade <= 86)) Console.WriteLine("Grade B");
                else if ((grade >= 80) && (grade <= 82)) Console.WriteLine("Grade B-");
                else if ((grade >= 77) && (grade <= 79)) Console.WriteLine("Grade C+");
                else if ((grade >= 73) && (grade <= 76)) Console.WriteLine("Grade C");
                else if ((grade >= 70) && (grade <= 72)) Console.WriteLine("Grade C-");
                else if ((grade >= 67) && (grade <= 69)) Console.WriteLine("Grade D+");
                else if ((grade >= 63) && (grade <= 66)) Console.WriteLine("Grade D");
                else if ((grade >= 60) && (grade <= 62)) Console.WriteLine("Grade D-");
                else if ((grade >= 0) && (grade <= 59)) Console.WriteLine("Grade F");
                else Console.WriteLine("Invalid input");

                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Please enter an integer value for the grade you expect to get in ISM 4300. ");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);

            }
        }
    }
}
