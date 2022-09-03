using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _09_RopeCuttingProblem
    {
        // Time complexity - O(3^n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int a = ConsoleHelper.ReadInteger("a");
            int b = ConsoleHelper.ReadInteger("b");
            int c = ConsoleHelper.ReadInteger("c");

            int result = Way01Cut(number, a, b, c);
            Console.WriteLine($"Result: {result}");
        }

        private static int Way01Cut(int number, int a, int b, int c)
        {
            if (number == 0)
                return 0;

            if (number < 0)
                return -1;

            int result1 = Way01Cut(number - a, a, b, c);
            int result2 = Way01Cut(number - b, a, b, c);
            int result3 = Way01Cut(number - c, a, b, c);

            int maxValue = Math.Max(Math.Max(result1, result2), Math.Max(result2, result3));
            if (maxValue == -1)
                return -1;

            return maxValue + 1;
        }
    }
}
