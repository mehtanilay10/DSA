using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _06_NaturalNumberSum
    {
        // T(n) = T(n-1) + θ(1)
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
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

            return number + Way01Sum(number - 1);
        }

        // without recursion
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int sum = (number * (number + 1) / 2);
            Console.WriteLine($"Sum - {sum}");
        }
    }
}
