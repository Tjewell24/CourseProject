using System;
using System.Reflection;

namespace ConsoleApp7
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("'Enter a car type: ");
            string carType = Console.ReadLine();
            Console.Write("Enter a car make");
            int yearMake = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Passes 0 parameters. Return default values:");
            carInfo();

            Console.WriteLine("Passes 1 parameter, car type. Returns default value of car make");
            carInfo(carType);

            Console.WriteLine("passes 2 parameters, returns both");
            carInfo(carType, yearMake);



            //Problem 2

            Console.WriteLine("overloaded function 'car' can take a string or an int.Parse");
            Car(carType);
            Car(yearMake);
        }

        private static void carInfo(string cartype = "no car type entered", int yearMake = 0)
        {
            Console.WriteLine($"Car Type: {cartype} \r\n Year Make: {yearMake} \r\n");
        }

        private static void Car(string cartype)

        {
            Console.WriteLine(cartype);
        }


        private static void Car(int yearMake)
        {
            Console.WriteLine(yearMake);
        }
    }


}