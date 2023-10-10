using System;
using System.Numerics;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static BigInteger GetFactorial(int n) {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }

            return factorial;
        }

        public static string FormatSeparators(params string[] items) {
            int count = items.Length;

            if (count == 0) {
                return string.Empty;
            } else if (count == 1) {
                return items[0];
            } else if (count == 2) {
                return string.Join(" and ", items);
            } else {
                return string.Join(", ", items, 0, count - 1) + " and " + items[count - 1];
            }
        }
    }
}