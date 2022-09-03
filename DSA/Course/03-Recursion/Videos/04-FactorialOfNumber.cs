using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _04_FactorialOfNumber
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int factorial = Way01Factorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}.");
        }

        private static int Way01Factorial(int number)
        {
            if (number == 0)    // Need to check with 0, instead of 1. As 0! = 1
                return 1;

            return number * Way01Factorial(number - 1);
        }
    }
}
