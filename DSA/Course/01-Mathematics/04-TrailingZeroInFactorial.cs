using Helper;

namespace DSA.Course._01_Mathematics
{
    internal static class _04_TrailingZeroInFactorial
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();

            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of: {number} is {factorial}");

            int numberOfTralingZeros = 0;
            while (factorial % 10 == 0)
            {
                numberOfTralingZeros++;
                factorial /= 10;
            }

            Console.WriteLine($"Number of Trainilg Zeros: {numberOfTralingZeros}");
        }

        // There is formula for calculating traling zeros in Factorial of any number.
        // Usually it recommanded when larger value was used and not able to handle that via built-in data types
        // Total number of traling zero(s) in any number = number/5 + number/25 + number/125 + number / 625 + ...
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int numberOfTrailingZeros = 0;

            for (int i = 5; i <= number; i *= 5)
            {
                numberOfTrailingZeros += number / i;
            }

            Console.WriteLine($"Total Trailing Zero(s): {numberOfTrailingZeros}");
        }
    }
}
