using System;

namespace DeveloperSample.Algorithms
{
    /// <summary>
    /// This class contains a collection of algorithms that are useful for developers
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Returns the sum of all numbers between 0 and n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetFactorial(int n) 
        {
            if (n < 0) throw new ArgumentException("n must be greater than or equal to 0");
            if (n == 0) return 1;

            return n * GetFactorial(n - 1);
        }

        /// <summary>
        /// Returns a string with the items separated by commas and the last item separated by "and"
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string FormatSeparators(params string[] items)
        {
            if (items.Length == 0) return string.Empty;
            if (items.Length == 1) return items[0];

            var result = string.Empty;
            for (var i = 0; i < items.Length; i++)
            {
                if (i == items.Length - 1)
                {
                    result += $" and {items[i]}";
                }
                else if (i == items.Length - 2)
                {
                    result += $"{items[i]}";
                }
                else
                {
                    result += $"{items[i]}, ";
                }
            }

            return result;       
        }
    }
}