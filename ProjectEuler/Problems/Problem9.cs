using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem9
    {
        private static const int SUM_OF_NUMBERS = 1000;

        /// <summary>
        /// Brute force approach that check every possible a and b
        /// From c > b > a, a < SUM / 3 and b < (SUM - A) / 2
        /// </summary>
        /// <returns> Returns the product of a, b and c </returns>
        public static int Solution1()
        {
            int a = 0, b = 0, c = 0;

            for(a = 0; a < SUM_OF_NUMBERS / 3; a++)
            {
                for(b = a; b < (SUM_OF_NUMBERS - a) / 2; b++)
                {
                    c = SUM_OF_NUMBERS - a - b;

                    if (c * c == (a * a) + (b * b))
                        return a * b * c; 
                }
            }

            return 0;
        }
    }
}
