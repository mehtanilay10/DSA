namespace DSA.Course._04_Array.Problems
{
    //Kadane's Algorithm
    //Medium    Accuracy: 36.28%    Submissions: 625K+      Points: 4

    //Given an array Arr[] of N integers. Find the contiguous sub-array(containing at least one number) which has the maximum sum and return its sum.

    //Example 1:
    //--------------------

    //Input:
    // N = 5
    // Arr[] = {1,2,3,-2,5}
    //Output: 9
    //Explanation: Max subarray sum is 9 of elements (1, 2, 3, -2, 5) which is a contiguous subarray.
    //Example 2:
    //--------------------
    //Input:
    // N = 4
    // Arr[] = {-1,-2,-3,-4}
    //Output: -1
    //Explanation: Max subarray sum is -1 of element (-1)

    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function maxSubarraySum() which takes Arr[] and N as input parameters and returns the sum of subarray with maximum sum.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 ≤ N ≤ 10^6
    //-10^7 ≤ A[i] ≤ 10^7
    internal static class _21_KadaneAlgorithm
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, -2, 5 };
            int longestMax = Way01FindLongestMax(array, array.Length);
            Console.WriteLine($"IsSorted: {longestMax}");
        }

        private static int Way01FindLongestMax(int[] array, int arrayLength)
        {
            int currentMax = 0;
            int overallMax = int.MinValue;

            for (int i = 0; i < arrayLength; i++)
            {
                currentMax = currentMax + array[i];
                overallMax = Math.Max(overallMax, currentMax);

                if (currentMax < 0)
                    currentMax = 0;
            }

            return overallMax;
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way02()
        {
            int[] array = new int[] { -1, -2, -3, -4 };
            int longestMax = Way02FindLongestMax(array, array.Length);
            Console.WriteLine($"LongestMax: {longestMax}");
        }

        private static int Way02FindLongestMax(int[] array, int arrayLength)
        {
            int currentMax = 0;
            int overallMax = int.MinValue;

            for (int i = 0; i < arrayLength; i++)
            {
                currentMax = Math.Max(currentMax + array[i], array[i]);
                overallMax = Math.Max(overallMax, currentMax);
            }

            return overallMax;
        }
    }
}
