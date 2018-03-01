using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //gives user overview of program
            Console.WriteLine("Enter your letter grades as a capital letter A-D. Enter credit hours numerically");
            Console.WriteLine("To exit, enter anything for letter grade and 0 for credit hours\n");

            //declare variables
            string strLetterGrade;
            double gradeScale = 0;
            char exit = 'F';
            int counter = 0;
            double creditHours;
            double gradeWeight = 0;
            double totalCreditHours = 0;
            do
            {
                counter++;
                //prompts user to enter input
                Console.WriteLine("Enter grade of class " + counter);
                strLetterGrade = Console.ReadLine();
                Console.WriteLine("Enter credit hours of class " + counter);
                string strCreditHours = Console.ReadLine();
                creditHours = Convert.ToDouble(strCreditHours);

                //convert letter grades to equivalent weight
                if (strLetterGrade.Equals("A"))
                    gradeScale = 4.0;
                else if (strLetterGrade.Equals("B"))
                    gradeScale = 3.0;
                else if (strLetterGrade.Equals("C"))
                    gradeScale = 2.0;
                else if (strLetterGrade.Equals("D"))
                    gradeScale = 1.0;
                else
                    //exits program if the user enters something other than A-D
                    exit = 'T';
                //calculates weight of the grade
                gradeWeight += (gradeScale * creditHours);
                totalCreditHours += creditHours;
            } while (exit == 'F');

            //prints output
            Console.WriteLine("Number of hours earned: " + totalCreditHours);
            double gpa = (gradeWeight / totalCreditHours);
            Console.WriteLine("Calculated GPA: " + gpa);
            Console.ReadKey();
        }
    }
}
