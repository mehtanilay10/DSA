using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Wave Array
    //Easy      Accuracy: 63.69%        Submissions: 168K+      Points: 2

    //Given a sorted array arr[] of distinct integers.Sort the array into a wave-like array(In Place). In other words, arrange the elements into a sequence such that arr[1] >= arr[2] <= arr[3] >= arr[4] <= arr[5]..... If there are multiple solutions, find the lexicographically smallest one.

    //Example 1:
    //--------------------
    //Input:
    // n = 5
    // arr[] = { 1,2,3,4,5}
    //Output: 2 1 4 3 5
    //Explanation: Array elements after sorting it in wave form are  2 1 4 3 5.

    //Example 2:
    //--------------------
    //Input:
    // n = 6
    // arr[] = {2,4,7,8,9,10}
    //Output: 4 2 8 7 10 9
    //Explanation: Array elements after sorting it in wave form are 4 2 8 7 10 9.

    //Your Task:
    //The task is to complete the function convertToWave(), which converts the given array to a wave array.
    //NOTE: The given array is sorted in ascending order, and you don't need to return anything to make changes in the original array itself.

    //Expected Time Complexity: O(n).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 ≤ n ≤ 10^6
    //0 ≤ arr[i] ≤10^7
    internal static class _15_WaveArray
    {
        // Time Complexity: O(n)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Way01CreateWaveArray(array, array.Length);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01CreateWaveArray(int[] array, int length)
        {
            for (int i = 1; i < length; i += 2)
            {
                int temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
            }
        }
    }
}
