using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string input = "";
            int counter=0;

            //ask for size of array
            Console.WriteLine("How many grades would you like to enter?");
            int.TryParse(Console.ReadLine(), out int gradeNum);
            double[] studentScores = new double[gradeNum];

            //
            Console.WriteLine("Enter homework scores one at a time, hitting ENTER in between.+" +
                " Press enter an extra time at end to see results.");
            input = Console.ReadLine();
            while (counter < gradeNum)
            {
                //check if input is a number
                if (double.TryParse(input, out double score))
                {
                    if (score >= 0 && score <= 10)
                    {
                        studentScores[counter] = score;
                        counter++;
                        
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                else
                {
                    while (score < 0 || score > 10)
                    {

                        Console.WriteLine("Try again");
                    }
                }
                input = Console.ReadLine();
            }
            //output
            Console.WriteLine("Max score: " +studentScores.Max());
            Console.WriteLine("Min score: " + studentScores.Min());
            //create list from array to be able to remove values
            var ss = new List<double>(studentScores);
            ss.Remove(studentScores.Max());
            ss.Remove(studentScores.Min());
            Console.WriteLine("Average: " + ss.Average());
            
            Console.ReadKey();
        }
    }
}
