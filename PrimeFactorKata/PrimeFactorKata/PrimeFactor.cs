using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorKata
{
    public static class PrimeFactor
    {
        public static List<int> Generate(int n)
        {
            List<int> primes = new List<int>();
            for (int candidate = 2; n > 1; candidate++)
                for (; n % candidate == 0; n /= candidate)
                {
                    primes.Add(candidate);

                }
            return primes;
        }
    }
}
