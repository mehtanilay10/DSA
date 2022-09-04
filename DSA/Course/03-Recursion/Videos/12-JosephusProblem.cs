using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _12_JosephusProblem
    {
        // T(n) = T(n-1) + C
        // Time complexity - O(n)
        // Auxiliary Space - O( n)
        // When Index start with 0
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int k = ConsoleHelper.ReadInteger("k");
            int safePosition = Way01Kill(number, k);
            Console.WriteLine($"Safe position - {safePosition}");
        }

        private static int Way01Kill(int number, int k)
        {
            if (number == 1)
                return 0;

            return ((Way01Kill(number - 1, k) + k) % number);
        }

        // when index start with 1
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int k = ConsoleHelper.ReadInteger("k");

            // we need to perform operation as it is, just have to
            // add 1 in the result at the end of operation
            int safePosition = Way01Kill(number, k) + 1;

            Console.WriteLine($"Safe position - {safePosition}");
        }
    }
}
