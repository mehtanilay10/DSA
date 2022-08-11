using Helper;

namespace DSA.Course._01_Mathematics.Videos
{
    internal static class _03_FactorialOfNumber
    {
        // Time complexity - O(n), Auxilary Space complexity - O(1)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}.");
        }

        // Tome complexity - O(n), Auxilary Space complexity - O(n)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int factorial = Way02Factorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}.");
        }

        private static int Way02Factorial(int number)
        {
            if (number == 1)
                return 1;

            return number * Way02Factorial(number - 1);
        }
    }
}
