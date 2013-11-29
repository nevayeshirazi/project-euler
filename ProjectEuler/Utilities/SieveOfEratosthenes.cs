using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Utilities
{
    class SieveOfEratosthenes
    {
        /// <summary>
        /// Generates and return an array of booleans in which false values in final array are prime numbers.
        /// </summary>
        /// <param name="limit">
        /// Size of the array
        /// </param>
        /// <returns></returns>
        public static bool[] FindPrimeNumbers(int limit)
        {
            var numbers = new bool[limit];
            numbers[0] = true;
            numbers[1] = true;

            for (int k = 2; k <= Math.Sqrt(limit); k++)
            {
                if (!numbers[k])
                {
                    for (int z = k * k; z < limit; z += k)
                        numbers[z] = true;
                }
            }

            return numbers;
        }
    }
}
