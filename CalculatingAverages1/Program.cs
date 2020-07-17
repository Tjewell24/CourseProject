using System;

namespace Calculating_AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            string myGpa;
            Console.Write("Please Input 10 positive numbers: ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;

            }
            avg = sum / 10.0;
            if (avg >= 90)
            {
                Console.WriteLine("A");

            }
            else if (avg >= 80)
            {
                Console.WriteLine("B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }








               

                Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);

            }
        }
    }
