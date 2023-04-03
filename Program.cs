using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1


            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int aCount = 0;
            int oCount = 0;
            int iCount = 0;
            int eCount = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        aCount++;
                        break;
                    case 'o':
                    case 'O':
                        oCount++;
                        break;
                    case 'i':
                    case 'I':
                        iCount++;
                        break;
                    case 'e':
                    case 'E':
                        eCount++;
                        break;
                }
            }

            Console.WriteLine($"a: {aCount}");
            Console.WriteLine($"o: {oCount}");
            Console.WriteLine($"i: {iCount}");
            Console.WriteLine($"e: {eCount}");

            Console.ReadLine();



            //TASK 2



            Console.Write("Enter a month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = 0;

            switch (month)
            {
                case 1:
                    daysInMonth = 31;
                    break;
                case 2:
                    Console.Write("Enter the year: ");
                    int year = int.Parse(Console.ReadLine());
                    if (DateTime.IsLeapYear(year))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;
                case 3:
                    daysInMonth = 31;
                    break;
                case 4:
                    daysInMonth = 30;
                    break;
                case 5:
                    daysInMonth = 31;
                    break;
                case 6:
                    daysInMonth = 30;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 31;
                    break;
                case 9:
                    daysInMonth = 30;
                    break;
                case 10:
                    daysInMonth = 31;
                    break;
                case 11:
                    daysInMonth = 30;
                    break;
                case 12:
                    daysInMonth = 31;
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }

            if (daysInMonth > 0)
            {
                Console.WriteLine($"Number of days in month {month}: {daysInMonth}");
            }

            Console.ReadLine();



            //TASK 3



            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sumOfFirst5 = 0;
            bool allPositive = true;

            for (int i = 0; i < 5; i++)
            {
                sumOfFirst5 += numbers[i];

                if (numbers[i] < 0)
                {
                    allPositive = false;
                    break;
                }
            }

            if (allPositive)
            {
                Console.WriteLine($"The sum of the first 5 positive numbers is: {sumOfFirst5}");
            }
            else
            {
                int productOfLast5 = 1;

                for (int i = 5; i < 10; i++)
                {
                    productOfLast5 *= numbers[i];
                }

                Console.WriteLine($"The product of the last 5 numbers is: {productOfLast5}");
            }

            Console.ReadLine();
        }
    }
}
