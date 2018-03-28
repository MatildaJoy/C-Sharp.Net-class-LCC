using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program counts the occurences of values of 0-10,\nvalues outside of that range,\nand non-numeric values\n");
            int[,] arrayValues = new int[2,11];
            
            int counterInt = 0;
            int counterNon = 0;
            int counterGoodInt = 0;

            //creating a way to exit the loop
            bool end = false;
            while (end == false)
            {
                //prompting user to enter input or exit
                Console.WriteLine("Enter a value. Enter XXX to see results.");
                string value = Console.ReadLine();
                arrayValues[0, 0] = 0;
                arrayValues[0, 1] = 1;
                arrayValues[0, 2] = 2;
                arrayValues[0, 3] = 3;
                arrayValues[0, 4] = 4;
                arrayValues[0, 5] = 5;
                arrayValues[0, 6] = 6;
                arrayValues[0, 7] = 7;
                arrayValues[0, 8] = 8;
                arrayValues[0, 9] = 9;
                arrayValues[0, 10] = 10;

                switch (value)
                {
                    case "0":
                        {
                            arrayValues[1, 0] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "1":
                        {
                            arrayValues[1, 1] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "2":
                        {
                            arrayValues[1, 2] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "3":
                        {
                            arrayValues[1, 3] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "4":
                        {
                            arrayValues[1, 4] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "5":
                        {
                            arrayValues[1, 5] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "6":
                        {
                            arrayValues[1, 6] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "7":
                        {
                            arrayValues[1, 7] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "8":
                        {
                            arrayValues[1, 8] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "9":
                        {
                            arrayValues[1, 9] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    case "10":
                        {
                            arrayValues[1, 10] += 1;
                            counterGoodInt += 1;
                            break;
                        }
                    //if they enter "XXX" it will end the program
                    case "XXX":
                        {
                            end = true;
                            break;
                        }
                    default:
                        {
                            double x;
                            if (double.TryParse(value, out x))
                            {
                                counterInt += 1;

                            }
                            else
                            {
                                counterNon += 1;
                            }
                            break;
                        }
                }
            }

           
            for (int i=0; i < 12; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write(String.Format("{0}\t", arrayValues[j,i]));
                    
                }
               
            }
            
            Console.WriteLine("You entered " + counterInt + " values outside of the range 0-10");
            Console.WriteLine("You entered " + counterNon + " non-numeric values");
            Console.ReadKey();
        }
    }
}
