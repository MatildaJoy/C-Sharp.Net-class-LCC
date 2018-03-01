using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double price = 0;
            double sum = 0;
            string strPrice;
            int counter = 0;
            double shippingCharge = 0;
            double salesTax;
            double grandTotal;

            do
            {
                //prompt user
                Console.WriteLine("Enter the price of an item, or '0' to end the program");
                //get input
                strPrice = Console.ReadLine();
                price = Convert.ToDouble(strPrice);
                counter++;
                sum += price;
                //set condition to end do while loop
            } while (price != 0);

            //calculate shipping charge based on number of items
            if (counter < 3)
                shippingCharge = 3.50;
            else if (counter >= 3 && counter <= 6)
                shippingCharge = 5.00;
            else if (counter >= 7 && counter <= 10)
                shippingCharge = 7.00;
            else if (counter >= 11 && counter <= 15)
                shippingCharge = 9.00;
            else shippingCharge = 10.00;

            //calculate sales tax based on total price
            salesTax = (sum * .0775);

            //calculate grand total
            grandTotal = (sum + salesTax + shippingCharge);

            //output
            Console.WriteLine("Total purchase charge: " + "{0:C2}", sum);
            Console.WriteLine("Number of items purchased: " + counter);
            Console.WriteLine("Sales tax amount: " + "{0:C2}", salesTax);
            Console.WriteLine("Shipping charge: " + "{0:C2}", shippingCharge);
            Console.WriteLine("Grand total: " + "{0:C2}", grandTotal);
            Console.ReadKey();

        }
    }
}
