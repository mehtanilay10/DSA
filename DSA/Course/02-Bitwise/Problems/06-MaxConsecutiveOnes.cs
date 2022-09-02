using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Longest Consecutive 1's
    //Easy  Accuracy: 57.61%    Submissions: 31976  Points: 2
    //Given a number N.Find the length of the longest consecutive 1s in its binary representation.

    //Example 1:
    //------------------------
    //Input: N = 14
    //Output: 3
    //Explanation:
    //Binary representation of 14 is 1110, in which 111 is the longest consecutive set bits of length is 3.

    //Example 2:
    //------------------------
    //Input: N = 222
    //Output: 4
    //Explanation:
    //Binary representation of 222 is 11011110, in which 1111 is the longest consecutive set bits of length 4.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function maxConsecutiveOnes() which returns the length of the longest consecutive 1s in the binary representation of given N.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 <= N <= 106
    internal static class _06_MaxConsecutiveOnes
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int currentCount = 0;
            int logestCount = 0;

            while (number > 0)
            {
                if ((number & 1) != 0)
                    currentCount = currentCount + 1;
                else
                {
                    logestCount = Math.Max(currentCount, logestCount);
                    currentCount = 0;
                }

                number = number >> 1;
            }

            // Check after entire processing
            logestCount = Math.Max(currentCount, logestCount);

            Console.WriteLine($"Maximum consecutive ones - {count}");
        }

        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int count = 0;

            while (number != 0)
            {
                number = (number & (number << 1));
                count++;
            }

            Console.WriteLine($"Maximum consecutive ones - {count}");
        }
    }
}
