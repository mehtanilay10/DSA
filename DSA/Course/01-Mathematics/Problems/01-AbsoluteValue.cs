using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //1. Absolute Value
    //Basic Accuracy: 71.87% Submissions: 43370 Points: 1
    //You are given an interger I, find the absolute value of the interger I.

    //Example 1:
    //--------------------------
    //Input:
    //I = -32
    //Output: 32
    //Explanation:
    //The absolute value of -32 is 32.

    //Example 2:
    //--------------------------
    //Input:
    //I = 45
    //Output: 45
    //Explanation:
    //The absolute value of 45 is 45 itself.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function absolute() which takes an integer I as input parameter and return the absolute value of I.

    //Expected Time Complexity: O(1)
    //Expected Auxiliary Space : O(1)

    //Constraints:
    //-106 <= I <= 106

    internal static class _01_AbsoluteValue
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            if (number < 0)
                number = number * -1;

            Console.WriteLine(number);
        }
    }
}
