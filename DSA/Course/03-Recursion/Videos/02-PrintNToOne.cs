using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _02_PrintNToOne
    {
        // T(n) = T(n-1) + θ(1)
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            Way01Print(number);
        }

        private static void Way01Print(int number)
        {
            if (number == 0)
                return;

            Console.WriteLine(number);
            Way01Print(number - 1);
        }
    }
}
