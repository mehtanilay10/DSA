using Helper;

namespace DSA.Course._03_Recursion.Problems
{
    //Count Total Digits in a Number
    //Easy  Accuracy: 50.0% Submissions: 56270  Points: 2
    //You are given a number n.You need to find the count of digits in n.

    //Example 1:
    //--------------------
    //Input:
    //n = 1
    //Output: 1
    //Explanation: Number of digit in 1 is 1.

    //Example 2:
    //--------------------
    //Input:
    //n  = 99999
    //Output: 5
    //Explanation:Number of digit in 99999 is 5
    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function countDigits() that takes n as parameter and returns the count of digits in n.

    //Expected Time Complexity: O(Logn).
    //Expected Auxiliary Space: O(Logn).

    //Constraints:
    //0 <= n <= 107
    internal static class _01_CountDigitsInNumber
    {
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = Way01Count(number);
            Console.WriteLine($"Counts: {counts}");
        }

        private static int Way01Count(int number)
        {
            if (number < 10)
                return 1;

            return Way01Count(number / 10) + 1;
        }
    }
}
