using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Helpers
    {
        public static List<ulong> FindPrimesUpTo(ulong upperBound)
        {
            var primes = new List<ulong>();

            for (ulong i=2; i < Math.Sqrt(upperBound); i++)
            {
                if (IsPrimeByTrialDivision(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static bool IsPrimeByTrialDivision(ulong prime)
        {
            bool isPrime = true;
            if (prime != 2) // number is the even prime
            {
                if (prime % 2 != 0) // number is odd
                {

                    var bound = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(prime)));
                    for (ulong i = 3; i <= bound; i += 2)
                    {
                        if (prime % i == 0) // number is composite
                        {
                            isPrime = false;
                            break;
                        }
                    }

                }
                else // number is even--no cigar
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        public static List<ulong> SieveOfEratosthenes(ulong num)
        {
            bool[] candidates = new bool[num];
            for (ulong i = 2; i < num; i++)
            {
                candidates[i] = true;
            }
            var sqrt = Convert.ToUInt64(Math.Sqrt(num));
            for (ulong i = 2; i < num; i++)
            {
                if (candidates[i])
                {
                    var j = 2U;
                    while (i * j < num)
                    {
                        candidates[j * i] = false;
                        j++;
                    }
                }
            }

            var primes = new List<ulong>();
            for (ulong i = 2; i < num; i++)
            {
                if (candidates[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
