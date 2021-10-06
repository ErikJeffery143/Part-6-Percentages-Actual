using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Percentages_Actual
{
    class Program
    {
        static void Main(string[] args)
        {
             int above;
            int done;
         
            int user;
            int total;
            double result;

            done = 000;
            above = 0;
            total = 0;

            Console.WriteLine("Hello, welcome to the percent passing program, please enter all your grades. If you are done please enter '000'.");
            user = Convert.ToInt32(Console.ReadLine());

            while (user != done) 
            {

                if (user >= 70) 
                {

                    above = above + 1;
                    total = total + 1;
                        Console.WriteLine("Thank you, youve entered " + total + " please enter all your grades. If you are done please enter '000'.");
                    user = Convert.ToInt32(Console.ReadLine());
                }
                else if (user < 70) 
                {
                   
                    total = total + 1;
                    Console.WriteLine("Thank you, youve entered " + total + " please enter all your grades. If you are done please enter '000'.");
                    user = Convert.ToInt32(Console.ReadLine());
                }
            }

            result = (((double)above / total) * 100);
            Console.WriteLine("Thank you, the percentage grade in your class is " + result + "% ");

            Console.ReadLine();


        }
    }
}
