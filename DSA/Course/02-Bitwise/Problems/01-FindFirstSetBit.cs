using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Find first set bit
    //Easy  Accuracy: 52.49%    Submissions: 52854  Points: 2
    //Given an integer an N.The task is to return the position of first set bit found from the right side in the binary representation of the number.
    //Note: If there is no set bit in the integer N, then return 0 from the function.

    //Example 1:
    //--------------------------
    //Input: N = 18
    //Output: 2
    //Explanation: Binary representation of 18 is 010010, the first set bit from the right side is at position 2.

    //Example 2:
    //--------------------------
    //Input: N = 12
    //Output: 3
    //Explanation: Binary representation of 12 is 1100, the first set bit from the right side is at position 3.

    //Your Task:
    //The task is to complete the function getFirstSetBit() that takes an integer n as a parameter and returns the position of first set bit.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //0 <= N <= 108
    internal static class _01_FindFirstSetBit
    {
        // With bitwise operator
        // Time complexity - O(n), Space complexity O(1)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = 0;

            if (number <= 0)
                Console.WriteLine("Number is <= 0");
            else
            {
                while (number > 0)
                {
                    counts++;
                    if ((number & 1) != 0)
                    {
                        Console.WriteLine($"First bit is settled on {counts}.");
                        break;
                    }
                    number = number >> 1;
                }
            }
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();

            if (number <= 0)
                Console.WriteLine("Number is <= 0");
            else
            {
                int firstBitValue = number ^ (number & (number - 1));
                double firstBitIndex = (Math.Log(firstBitValue) / Math.Log(2)) + 1;
                Console.WriteLine($"First bit is settled on {firstBitIndex}.");
            }
        }
    }
}
