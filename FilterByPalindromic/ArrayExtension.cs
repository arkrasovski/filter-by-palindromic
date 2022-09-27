using System;

namespace FilterByPalindromicTask
{
    /// <summary>
    /// Provides static method for working with integers array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns new array that contains only palindromic numbers from source array.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of elements that are palindromic numbers.</returns>
        /// <exception cref="ArgumentNullException">Throw when array is null.</exception>
        /// <exception cref="ArgumentException">Throw when array is empty.</exception>
        /// <example>
        /// {12345, 1111111112, 987654, 56, 1111111, -1111, 1, 1233321, 70, 15, 123454321}  => { 1111111, 123321, 123454321 }
        /// {56, -1111111112, 987654, 56, 890, -1111, 543, 1233}  => {  }.
        /// </example>
        public static int[] FilterByPalindromic(int[]? source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("Array can not be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array can not be empty.");
            }

            int[] result = Array.Empty<int>();

            foreach (int s in source)
            {
                if (IsPalindrom(s))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = s;
                }
            }

            return result;
        }

        private static bool IsPalindrom(int number)
        {
            if (number < 0)
            {
                return false;
            }

            int copy_number = number;
            int result = 0;
            while (number != 0)
            {
                result = (result * 10) + (number % 10);
                number = number / 10;
            }

            if (result == copy_number)
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
