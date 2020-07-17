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
            int currentScore = 0;
            bool stillGrading = true;
            Console.WriteLine("Please enter the scores to be graded. When finished, enter a negative Number: ");
            while (stillGrading == true)
            {
                currentScore = Convert.ToInt32(Console.ReadLine());
                if (currentScore < 0)
                {
                    stillGrading = false;
                }
                else
                {
                    sum += currentScore;
                    numberToGrade++;
                }

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
