using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double numberI=0;
            double sum = 0;
            double max = -9999999.99;
            double min = 9999999.99;
            Console.WriteLine("Vnesete kolku broevi sakate da vnesite:");
            N = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Now give me the {0} number:",i+1);
                numberI = Convert.ToDouble(Console.ReadLine());
                sum += numberI;
                if (numberI > max)
                {
                    max = numberI;
                }
                if (numberI < min)
                {
                    min = numberI;
                }
            }
            Console.WriteLine("You gave me {0} numbers. And from those numbers. ", N);
            Console.WriteLine("The max number is: {0}",max);
            Console.WriteLine("The min number is: {0}", min);
            Console.WriteLine("The sum of all the numbers you gave me is: {0} ", sum);
            Console.WriteLine("The average of all the numbers you gave me is: {0} ", sum /N);
            Console.ReadKey();
        }
    }
}
