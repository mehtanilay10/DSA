using Helper;

namespace DSA.Course._02_Bitwise.Problems
{
    //Gray to Binary equivalent
    //Basic Accuracy: 62.92%    Submissions: 15519  Points: 1
    //Given N in Gray Code, find its binary equivalent.Return the decimal representation of the binary equivalent.

    //Example 1:
    //------------------------
    //Input: N = 4
    //Output: 7
    //Explanation:
    //Given 4 representing gray code 110. Binary equivalent of gray code 110 is 100. Return 7 representing gray code 100.

    //Example 2:
    //------------------------
    //Input: N = 15
    //Output: 10
    //Explanation:
    //Given 15 representing gray code 1000. Binary equivalent of gray code 1000 is 1111. Return 10 representing gray code 1111 ie binary 1010.

    //Example 3:
    //------------------------
    //Input: N = 0
    //Output: 0
    //Explanation:
    //Zero remains the same in all systems.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function grayToBinary() which accepts an integer n as an input parameter and returns decimal of the binary equivalent of the given gray code.

    //Expected Time Complexity: O(log N)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //0 <= N <= 108
    internal static class _08_GrayCodeToBinary
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int result = number;

            while (number > 0)
            {
                result = (result ^ (number >> 1));
                number = number >> 1;
            }

            Console.WriteLine($"Result - {result}");
        }
    }
}
