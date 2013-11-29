using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem1
    {
        private static const int MAX  = 1000;

        /// <summary>
        /// Brute force approach that checks every number
        /// </summary>
        /// <returns> Returns the sum of divisors </returns>
        public static int Solution1()
        {
            int sum = 0;
            for(int i = 1000; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }


        /// <summary>
        /// Faster solution that utilizes SumOfDiviors function.
        /// </summary>
        /// <returns>Returns the sum of diviSors which are multiples of either 3 or 5 which are less than MAX </returns>
        public static int Solution2()
        {
            return SumOfDivisors(3) + SumOfDivisors(5) - SumOfDivisors(15);
        }

        /// <summary>
        /// Utilizes the n * (n + 1 ) / 2 Arithmetic rule to find the sum of divisors which are multiples of baseNumber
        /// </summary>
        /// <param name="baseNumber"> Base divisor </param>
        /// <returns> Returns the sum of diviors </returns>
        private static int SumOfDivisors(int baseNumber)
        {
            int newMax = MAX / baseNumber;

            return baseNumber * newMax * (newMax + 1) / 2;
        }

    }
}
