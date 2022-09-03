using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Binary To Gray Code equivalent
    //Basic Accuracy: 66.25%    Submissions: 14242  Points: 1
    //You are given a decimal number N.You need to find the gray code of the number N and convert it into decimal.

    //Example 1:
    //--------------------------
    //Input: N = 7
    //Output: 4
    //Explanation: 7 is represented as 111 in binary form.The gray code of 111 is 100, in the binary form whose decimal equivalent is 4.

    //Example 2:
    //--------------------------
    //Input: N = 10
    //Output: 15
    //Explanation: 10 is represented as 1010 in binary form. The gray code of 1010 is 1111, in the binary form whose decimal equivalent is 15.

    //Example 3:
    //--------------------------
    //Input: N = 0
    //Output: 0
    //Explanation: Zero is represented as zero in binary, gray, and decimal.

    //Your Task: The task is to complete the function greyConverter() which takes n as a parameter and returns it's equivalent gray code.

    //Expected Time Complexity: O(1).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //0 <= N <= 109
    internal static class _07_BinaryToGrayCode
    {
        // GrayCode Example
        // Input value - 10, It's binary - 1010
        // Left-most bit will be remain same, and for rest xor will be perform with previous number
        // So first bit is 1, so that will be copied on first place.
        // Next bit is 0, that will xor with previous bit that is 1. And so on...
        // Time Complexity: O(1)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            if (number == 0)
                Console.WriteLine("Number is Zero");
            else
            {
                int grayCode = number ^ (number >> 1);
                Console.WriteLine($"GrayCode - {grayCode}");
            }
        }
    }
}
