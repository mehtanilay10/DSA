using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _03_PrintOneToN
    {
        // Time complexity - T(n) = T(n-1) + θ(1)
        // Space complexity - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            Way01Print(number);
        }

        private static void Way01Print(int number)
        {
            if (number == 0)
                return;

            Way01Print(number - 1);
            Console.WriteLine(number);
        }

        // Time complexity - T(n) = T(n-1) + θ(1)
        // Space complexity - O(n)
        // Based on Tail Recursion (Performs better than Way01 solution)
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int index = 1;
            Way02Print(number, index);
        }

        private static void Way02Print(int number, int index)
        {
            if (number == 0)
                return;

            Console.WriteLine(index);
            Way02Print(number - 1, index + 1);
        }
    }
}
