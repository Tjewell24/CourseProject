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
            int numberToGrade = 0;
            Console.Write("Please enter number of scores to be graded: ");
            numberToGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your scores to be graded: ");
            for (i = 1; i <= numberToGrade; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;

            }
            avg = sum / numberToGrade;
            PrintAverage(avg);
            Console.Write($"The sum of {numberToGrade} numbers is : {sum}\nThe Average is : {avg}\n");
        }

        private static void PrintAverage(double avg)
        {
            if (avg >= 90)
            {
                Console.WriteLine("Average of the grades is: A");

            }
            else if (avg >= 80)
            {
                Console.WriteLine("Average of the grades is: B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Average of the grades is: C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Average of the grades is: D");
            }
            else
            {
                Console.WriteLine("Average of the grades is: F");
            }
        }
    }
}
