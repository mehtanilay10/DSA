﻿namespace DSA.Course._04_Array.Problems
{
    //Strongest Neighbour
    //Basic     Accuracy: 57.04%     Submissions: 34K+      Points: 1

    //Given an array arr[] of n positive integers.The task is to find the maximum for every adjacent pairs in the array.

    //Example 1:
    //--------------------
    //Input:
    // n = 6
    // arr[] = { 1,2,2,3,4,5}
    //Output: 2 2 3 4 5
    //Explanation: Maximum of arr[0] and arr[1] is 2, that of arr[1] and arr[2] is 2, ... and so on.For last two elements, maximum is 5.

    //Example 2:
    //--------------------
    //Input:
    // n = 2
    // arr[] = {5, 5}
    //Output: 5
    //Explanation: We only have two elements so max of 5 and 5 is 5 only.

    //Your Task:
    //The task is to complete the function maximumAdjacent(), which takes sizeOfArray (n) and array(arr) as parameters and prints the maximum of all adjacent pairs (space separated).

    //Expected Time Complexity: O(n).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //2 <= n <= 10^6
    //1 <= arr[i] <= 10^6
    internal static class _12_StrongestNeighbour
    {
        // Time Complexity: O(n)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 2, 3, 4, 5 };
            Way01PrintStorngestNeighbour(array, array.Length);
            Console.WriteLine();
        }

        private static void Way01PrintStorngestNeighbour(int[] array, int arrayLength)
        {
            for (int i = 1; i < arrayLength; i++)
                Console.Write($"{Math.Max(array[i], array[i - 1])} ");
        }
    }
}
