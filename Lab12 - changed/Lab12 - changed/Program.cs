using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab12___changed
{
    class Program
    {

        static double averageValue(double sumOfAllValues,int numberOfValues )
        {
            return sumOfAllValues/numberOfValues;
        }

        static void findMin(double x, double y, out double min)
        {
            min= (x < y) ? x : y;
        }
        static void findMax(double x, double y, out double max)
        {
            max= (x > y) ? x : y;
        }
        static void Main(string[] args)
        {
            int N=0;
            double numberI=0;
            double sum = 0;
            double max = -9999999.99;
            double min = 9999999.99;
            double average;


            char keyPressed;
            Random random = new Random();
            double randomVal;
            Console.WriteLine("Welcome, I'm here to help you with generating numbers or manually entering them one by one.");
            Console.WriteLine("{0}Enter how many numbers you want to do this with:",Environment.NewLine);
            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("That's not a number, please type a number.");
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ef)
                {
                    Console.WriteLine("You have tried to enter a wrong value too many times, the application will close in 30 seconds.");
                    Thread.Sleep(3 * 1000);
                    Environment.Exit(1);
                }
            }
            Console.WriteLine("Enter 'g' if you want your numbers to be generated randomly or 'm' if you want to enter numbers manually.");

            keyPressed = Convert.ToChar(Console.ReadLine());
            if (keyPressed=='g')
            {
                for (int i = 0; i < N; i++)
                {
                    randomVal = random.Next(1, 1000);
                    Console.WriteLine("This is the {0} random number: {1} ", i + 1, randomVal);
                }
               
                Console.WriteLine("{0}Press any key to exit the aplication.", Environment.NewLine);
            }
            else if(keyPressed=='m')
            {

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Now give me the {0} number:", i + 1);
                    try
                    {
                        numberI = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("That's not a number, please type a number.");
                        try
                        {
                            numberI = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (FormatException ef)
                        {
                            Console.WriteLine("You have tried to enter a wrong value too many times, the application will close in 30 seconds.");
                            Thread.Sleep(3 * 1000);
                            Environment.Exit(1);
                        }
                    }
                    sum += numberI;
                    findMax(max,numberI, out max);
                    findMin(min, numberI,out min);
                }

                average = averageValue(sum, N);
                Console.WriteLine("You gave me {0} numbers. And from those numbers. ", N);
                Console.WriteLine("The max number is: {0}", max);
                Console.WriteLine("The min number is: {0}", min);
                Console.WriteLine("The sum of all the numbers you gave me is: {0} ", sum);
                Console.WriteLine("The average of all the numbers you gave me is: {0} {1}",average, Environment.NewLine);
                Console.WriteLine("Press any key to exit the aplication.");
            }
            else
            {
                Console.WriteLine("The key you pressed doesn't give me information what to do.");
                Console.WriteLine("{0}Press any key to exit the aplication.",Environment.NewLine);
            }
            Console.ReadKey();
        }        
        
    }
}
