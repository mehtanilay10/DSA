using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Swap all odd and even bits
    //Easy  Accuracy: 60.12%    Submissions: 23314  Points: 2
    //Given an unsigned integer N.The task is to swap all odd bits with even bits.For example, if the given number is 23 (00010111), it should be converted to 43(00101011). Here, every even position bit is swapped with an adjacent bit on the right side(even position bits are highlighted in the binary representation of 23), and every odd position bit is swapped with an adjacent on the left side.

    //Example 1:
    //-------------------
    //Input: N = 23
    //Output: 43
    //Explanation:
    //Binary representation of the given number is 00010111 after swapping 00101011 = 43 in decimal.

    //Example 2:
    //-------------------
    //Input: N = 2
    //Output: 1
    //Explanation:
    //Binary representation of the given number is 10 after swapping 01 = 1 in decimal.

    //Your Task: Your task is to complete the function swapBits() which takes an integer and returns an integer with all the odd and even bits swapped.

    //Expected Time Complexity: O(1).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 ≤ N ≤ 109
    internal static class _09_SwapOddAndEvenBits
    {
        internal static void Way01()
        {
            uint number = ConsoleHelper.ReadUInt();
            uint evenBits = number & 0xAAAAAAAA;
            uint oddBits = number & 0x55555555;
            evenBits = evenBits >> 1;
            oddBits = oddBits << 1;

            uint result = (evenBits | oddBits);
            Console.WriteLine($"Result - {result}");
        }
    }
}
