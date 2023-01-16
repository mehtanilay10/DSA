using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _08_SquareRootOfNumber
    {
        // Time complexity - O(√n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            long number = ConsoleHelper.ReadLong();

            long sqrt = Way01FindSqrt(number);
            Console.WriteLine($"Square root of {number} is {sqrt}.");
        }

        private static long Way01FindSqrt(long number)
        {
            long i = 1;
            while (i * i <= number)
                i++;
            return i - 1;
        }

        // Time complexity - O(Log(n))
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            long number = ConsoleHelper.ReadLong();
            long sqrt = Way02FindSqrt(number);
            Console.WriteLine($"Square root of {number} is {sqrt}.");
        }

        private static long Way02FindSqrt(long number)
        {
            long low = 1;
            long high = number;
            long neartestSqrt = -1;

            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                long midSquare = mid * mid;

                if (midSquare == number)
                    return mid;
                else if (midSquare > number)
                    high = mid - 1;
                else
                {
                    low = mid + 1;
                    neartestSqrt = mid;
                }
            }

            return neartestSqrt;
        }
    }
}
