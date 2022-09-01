using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Rightmost different bit
    //Easy  Accuracy: 56.24%    Submissions: 40964  Points: 2
    //Given two numbers M and N.The task is to find the position of the rightmost different bit in the binary representation of numbers.

    //Example 1:
    //------------------------
    //Input: M = 11, N = 9
    //Output: 2
    //Explanation: Binary representation of the given numbers are: 1011 and 1001, 2nd bit from right is different.

    //Example 2:
    //------------------------
    //Input: M = 52, N = 4
    //Output: 5
    //Explanation: Binary representation of the given numbers are: 110100 and 0100, 5th-bit from right is different.

    //User Task:
    //The task is to complete the function posOfRightMostDiffBit() which takes two arguments m and n and returns the position of first different bits in m and n.If both m and n are the same then return -1 in this case.

    //Expected Time Complexity: O(max(log m, log n)).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //0 <= M <= 109
    //0 <= N <= 109
    internal static class _02_FindRightMostDifferentBit
    {
        // Based on bitwise xor
        // Time Complexity: O(max(log m, log n))
        internal static void Way01()
        {
            int n1 = ConsoleHelper.ReadInteger("n1");
            int n2 = ConsoleHelper.ReadInteger("n2");
            int xorValue = n1 ^ n2;   // First all all find diff between those 2 numbers

            if (xorValue == 0)
                Console.WriteLine("Both numbers are same.");

            int counts = 0;
            while (xorValue > 0)
            {
                counts++;
                if ((xorValue & 1) != 0)
                {
                    Console.WriteLine($"Right most different bit index - {counts}");
                    break;
                }

                xorValue = xorValue >> 1;
            }
        }

        // Not based on bitwise operators
        internal static void Way02()
        {
            int n1 = ConsoleHelper.ReadInteger("n1");
            int n2 = ConsoleHelper.ReadInteger("n2");

            if (n1 == n2)
                Console.WriteLine("Both numbers are same.");

            int counts = 0;
            while (n1 > 0 || n2 > 0)
            {
                counts++;
                if ((n1 % 2) != (n2 % 2))
                    Console.WriteLine($"Right most different bit index - {counts}");

                n1 = n1 / 2;
                n2 = n2 / 2;
            }
        }

        // Based on bitwise xor operator and log
        internal static void Way03()
        {
            int n1 = ConsoleHelper.ReadInteger("n1");
            int n2 = ConsoleHelper.ReadInteger("n2");

            if (n1 == n2)
                Console.WriteLine("Both numbers are same.");

            int xorValue = n1 ^ n2;
            double firstSettedBitIndex = Math.Log2(xorValue & -xorValue) + 1;
            Console.WriteLine($"Right most different bit index - {firstSettedBitIndex}");
        }
    }
}
