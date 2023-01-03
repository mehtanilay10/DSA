namespace DSA.Course._04_Array.Problems
{
    //Minimum adjacent difference in a circular array
    //Easy      Accuracy: 68.68%    Submissions: 24K+   Points: 2

    //Given an array Arr of n integers arranged in a circular fashion.Your task is to find the minimum absolute difference between adjacent elements.

    //Example 1:
    //--------------------
    //Input:
    // n = 7
    // Arr[] = {8,-8,9,-9,10,-11,12}
    //Output: 4
    //Explanation: The absolute difference between adjacent elements in the given array are as such: 16 17 18  19 21 23 4 (first and last).Among the calculated absolute difference the minimum is 4.

    //Example 2:
    //--------------------
    //Input:
    //n = 8
    //Arr[] = { 10,-3,-4,7,6,5,-4,-1}
    //Output: 1
    //Explanation: The absolute difference between adjacent elements in the given array are as such: 13 1 11 1 1 9 3 11 (first and last).Among the calculated absolute difference, the minimum is 1.

    //Your Task:
    //The task is to complete the function minAdjDiff() which returns the minimum difference between adjacent elements in circular array.

    //Expected Time Complexity: O(n).
    //Expected Auxiliary Space: O(1).

    //Constraint:
    //2 <= n <= 10^6
    //- 10^6 <= Arr[i] <= 10^6
    internal static class _13_MinimumAdjacentDifferenceInCircularArray
    {
        // Time Complexity: O(n)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 8, -8, 9, -9, 10, -11, 12 };
            int minDiff = Way01FindMinDiff(array, array.Length);
            Console.WriteLine($"MinDiff: {minDiff}");
        }

        private static int Way01FindMinDiff(int[] array, int arrayLength)
        {
            int minDiff = Math.Abs(array[arrayLength - 1] - array[0]);
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int currentDiff = Math.Abs(array[i] - array[i + 1]);
                minDiff = Math.Min(minDiff, currentDiff);
            }

            return minDiff;
        }
    }
}
