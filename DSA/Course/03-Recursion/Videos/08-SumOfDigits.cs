using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _08_SumOfDigits
    {
        // Time complexity - O(digits in number)
        // Auxiliary Space - O(digits in number)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int sum = Way01Sum(number);
            Console.WriteLine($"Sum - {sum}");
        }

        private static int Way01Sum(int number)
        {
            if (number == 0)
                return 0;

            int lastDigit = number % 10;
            return lastDigit + Way01Sum(number / 10);
        }
    }
}
