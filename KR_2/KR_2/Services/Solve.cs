using KR_2.ServiceInterfaces;
using System;

namespace KR_2.Services
{
    public class Solve : ISolve
    {

        public bool CheckNumber(long number, int k)
        {
            var solve = new Solve();
            return (solve.IsDifference(number, k) == true && solve.IsTriangleNumber(SumDigits(number)) == true);
        }

       
        public bool IsDifference(long number,int k)
        {
            int digit, delta;
            if (number < 0) number = -number;
            digit = (int)(number % 10);
            number /= 10;

            while (number != 0)
            {
                delta = (int)(number % 10 - digit);
                if (delta < 0) delta = -delta;
                if (delta != k) return false;

                digit = (int)(number % 10);
                number /= 10;
            }
            return true;
        }

       
        public long SumDigits(long number)
        {
            long SumDigits = 0;
            if (number < 0) number = -number;
            while(number != 0)
            {
                SumDigits += number % 10;
                number /= 10;
            }
            return SumDigits;
        }

        public bool IsTriangleNumber(long number)
        {
            var result = (Math.Sqrt(1 + 8 * number) - 1) / 2;
            if (result == Math.Truncate(result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
