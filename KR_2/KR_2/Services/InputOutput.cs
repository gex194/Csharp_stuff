using KR_2.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2.Services
{
    public class InputOutput : IInputOutput
    {
        public ISolve _solve;

        public InputOutput (ISolve solve)
        {
            _solve = solve;
        }

        public void PrintTriangleNumbers()
        {
            long lower, upper;
            long number;

            Console.Write("Entry the lower bound of numbers: ");
            bool lower_success = long.TryParse(Console.ReadLine(), out long lower_result);
            if (lower_success)
            {
                lower = lower_result;
            }
            else
            {
                Console.WriteLine("Incorrect Lower bound number");
                return;
            }

            Console.Write("Entry the upper bound of numbers: ");
            bool upper_success = long.TryParse(Console.ReadLine(), out long upper_result);
            if (upper_success)
            {
                upper = upper_result;
            }
            else
            {
                Console.WriteLine("Incorrect upper bound number");
                return;
            }

            if (lower > upper)
            {
                number = lower;
                lower = upper;
                upper = number;
            }

            Console.Write("List of Numbers: ");

            for (number = lower; number <= upper; number++)
            {
                if (_solve.IsTriangleNumber(number) == true)
                {
                    Console.WriteLine(number);
                }
            }
        }

        public void PrintNumbers()
        {
            int diff;
            long lower, upper;
            long number;

            Console.Write("Entry the lower bound of numbers: ");
            bool lower_success = long.TryParse(Console.ReadLine(), out long lower_result);
            if (lower_success)
            {
                lower = lower_result;
            }
            else
            {
                Console.WriteLine("Incorrect Lower bound number");
                return;
            }

            Console.Write("Entry the upper bound of numbers: ");
            bool upper_success = long.TryParse(Console.ReadLine(), out long upper_result);
            if (upper_success)
            {
                upper = upper_result;
            }
            else
            {
                Console.WriteLine("Incorrect upper bound number");
                return;
            }

            Console.Write("Entry the digit difference in range [1...8]: ");
            bool diff_success = int.TryParse(Console.ReadLine(), out int diff_result);
            if (diff_success && diff_result >= 1 && diff_result <= 8)
            {
                diff = diff_result;
            }
            else
            {
                Console.WriteLine("Incorrect diff number");
                return;
            }

            if (lower > upper)
            {
                number = lower;
                lower = upper;
                upper = number;
            }

            Console.Write("List of Numbers: ");

            for (number = lower; number <= upper; number++)
            {
                if (_solve.CheckNumber(number, diff) == true)
                {
                    Console.WriteLine(number);
                }
            }

        }

        public void InputNumbers()
        {
            bool zero = false;
            int n = 0, m = 0;
            int diff;
            long number;

            Console.Write("Entry the digit difference in range [1...8]: ");
            bool diff_success = int.TryParse(Console.ReadLine(), out int diff_result);
            if(diff_success && diff_result >= 1 && diff_result <= 8)
            {
                diff = diff_result;
            }
            else
            {
                Console.WriteLine("Incorrect digit difference value");
                return;
            }

            do
            {
                Console.WriteLine("Enter numbers. Enter zero to stop");
                bool number_success = long.TryParse(Console.ReadLine(), out long number_result);
                if (number_success)
                {
                    number = number_result;
                    if (number == 0)
                    {
                        if (zero == false) number = -1;
                        zero = true;
                    }
                    else
                    {
                        zero = false;
                        if (_solve.CheckNumber(number, diff) == true)
                        {
                            n++;
                            Console.Write("(" + number + ")\t is (" + n + ")" + "\tsum=" + _solve.SumDigits(number) + "\n");
                        }
                        else m++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number value");
                }
            }
            while (!zero);
        }
    }
}
