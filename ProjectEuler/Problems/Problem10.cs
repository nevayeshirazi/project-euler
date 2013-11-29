using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Utilities;

namespace ProjectEuler.Problems
{
    class Problem10
    {
        // Max natural number
        private static const int MAX  = 2000000;

        /// <summary>
        /// Finds the sum of prime numbers less than MAX
        /// </summary>
        /// <returns>
        /// Returns the calcualated the sum
        /// </returns>
        public static long SumOfPrimeNumbers()
        {
            bool[] numbers = SieveOfEratosthenes.FindPrimeNumbers(2000000);

            long sum = 0;
            for (int i = 2; i < MAX; i++)
            {
                if (!numbers[i])
                    sum += i;
            }

            return sum;
        }
    }
}
