using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Count total set bits
    //Medium    Accuracy: 45.48%    Submissions: 79302  Points: 4
    //You are given a number N.Find the total count of set bits for all numbers from 1 to N(both inclusive).

    //Example 1:
    //-------------------------
    //Input: N = 4
    //Output: 5
    //Explanation:
    //For numbers from 1 to 4.
    //For 1: 0 0 1 = 1 set bits
    //For 2: 0 1 0 = 1 set bits
    //For 3: 0 1 1 = 2 set bits
    //For 4: 1 0 0 = 1 set bits
    //Therefore, the total set bits is 5.

    //Example 2:
    //-------------------------
    //Input: N = 17
    //Output: 35
    //Explanation: From numbers 1 to 17(both inclusive), the total number of set bits is 35.

    //Your Task: The task is to complete the function countSetBits() that takes n as a parameter and returns the count of all bits.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 ≤ N ≤ 108
    internal static class _03_CountTotalSetBits
    {
        // Time Complexity: O(log n)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int powerOf2 = 2;
            number += 1;

            // add count of set least significant bits in the integers
            int counts = number / 2;

            // Loop for every bit required to represent number
            while (powerOf2 <= number)
            {
                // Total count of pairs of 0s and 1s
                int totalPairs = number / powerOf2;

                // add count of 1s in the current bit
                counts += (totalPairs / 2) * powerOf2;

                // If the count of pairs was odd then add the remaining 1s
                if (totalPairs % 2 == 1)
                    counts += (number % powerOf2);

                // Next power of 2
                powerOf2 = powerOf2 << 1;
            }

            // Return the result
            Console.WriteLine($"Total setted bit counts - {counts}");
        }

        // Time Complexity: O(nLogn)
        // without bitwise operator
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;
            for (int i = 1; i <= number; i++)
                counts += Way02CountSettedBits(i);

            Console.WriteLine($"Total setted bit counts - {counts}");
        }

        private static int Way02CountSettedBits(int n)
        {
            if (n <= 0)
                return 0;

            return (n % 2) + Way02CountSettedBits(n / 2);
        }
    }
}
