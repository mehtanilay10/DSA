using Helper;

namespace DSA.Course._03_Recursion.Problems
{
    //Print Pattern
    //Easy  Accuracy: 56.39%    Submissions: 34K+   Points: 2

    //Print a sequence of numbers starting with N where A[0] = N, without using loop, in which  A[i+1] = A[i] - 5,  until A[i] > 0. After that A[i+1] = A[i] + 5  repeat it until A[i] = N.

    //Example 1:
    //--------------------
    //Input: N = 16
    //Output: 16 11 6 1 -4 1 6 11 16
    //Explaination: The value decreases until it is greater than 0. After that it increases and stops when it becomes 16 again.

    //Example 2:
    //--------------------
    //Input: N = 10
    //Output: 10 5 0 5 10
    //Explaination: It follows the same logic as per the above example.

    //Your Task:
    //You do not need to read input or print anything. Your task is to complete the function pattern() which takes N as input parameters and returns a list containing the pattern.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)

    //Constraints:
    //1 ≤ N ≤ 104 
    internal static class _08_PrintPattern
    {
        // T(n) = T(n-1) + C
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            List<int> list = Way01GeneratePattern(number);
            ConsoleHelper.PrintArray(list.ToArray());
        }

        private static List<int> Way01GeneratePattern(int number)
        {
            List<int> list = new List<int>();
            int lastValue = Way01AddDescendingValues(list, number);
            Way01AddAscendingValues(list, lastValue, number);
            return list;
        }

        private static int Way01AddDescendingValues(List<int> list, int number)
        {
            if (number <= 0)
                return number;

            list.Add(number);
            return Way01AddDescendingValues(list, number - 5);
        }

        private static void Way01AddAscendingValues(List<int> list, int lastValue, int number)
        {
            if (lastValue > number)
                return;

            list.Add(lastValue);
            Way01AddAscendingValues(list, lastValue + 5, number);
        }
    }
}
