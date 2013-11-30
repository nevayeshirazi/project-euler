using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem7
    {

        private static const int PRIME_NO = 10001;

        /// <summary>
        /// Brute force approach that checks every odd number.
        /// By dividing the number to every prime number before that, we can check whether the number is prome or not.
        /// </summary>
        /// <returns>Returns the 10001th primen number</returns>
        public static int Solition1()
        {
            int counter = 0, number = 2;

            var primes = new List<int>();

            while (counter != PRIME_NO)
            {
                bool isPrime = true;

                // If remainder is 0, it is not a prime
                foreach (var p in primes)
                {
                    if (number % p == 0)
                        isPrime = false;
                }

                if (isPrime)
                {
                    primes.Add(number);
                    counter++;
                }

                // For any number different than 2, increment by 2, since other primes are all odd
                if (number == 2)
                    number += 1;
                else
                    number += 2;
            }

            return primes.LastOrDefault();
        }
    }
}
