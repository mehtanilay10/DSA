using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Reverse array in groups
    //Basic     Accuracy: 37.48%    Submissions: 229K+  Points: 1

    //Given an array arr[] of positive integers of size N.Reverse every sub-array group of size K.
    //Note: If at any instance, there are no more subarrays of size greater than or equal to K, then reverse the last subarray (irrespective of its size). You shouldn't return any array, modify the given array in-place.

    //Example 1:
    //--------------------
    //Input:
    // N = 5, K = 3
    // arr[] = {1,2,3,4,5}
    //Output: 3 2 1 5 4
    //Explanation: First group consists of elements 1, 2, 3. Second group consists of 4,5.

    //Example 2:
    //--------------------
    //Input:
    // N = 4, K = 3
    // arr[] = { 5,6,8,9}
    //Output: 8 6 5 9

    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function reverseInGroups() which takes the array, N and K as input parameters and modifies the array in-place.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)

    //Constraints:
    //1 ≤ N, K ≤ 10^7
    //1 ≤ A[i] ≤ 10^18
    internal static class _05_ReverseInGroup
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Way01ReveseInGroup(array, array.Length, 3);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01ReveseInGroup(int[] A, int N, int K)
        {
            for (int i = 0; i < N; i += K)
            {
                int leftIndex = i;
                int rightIndex = Math.Min(leftIndex + K - 1, N - 1);

                while (leftIndex < rightIndex)
                {
                    int temp = A[rightIndex];
                    A[rightIndex] = A[leftIndex];
                    A[leftIndex] = temp;
                    leftIndex++;
                    rightIndex--;
                }
            }
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Way02ReveseInGroup(array, array.Length, 3);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way02ReveseInGroup(int[] array, int arraySize, int groupSize)
        {
            int leftIndex = 0;
            int rightIndex = leftIndex + groupSize - 1;

            while (rightIndex < arraySize)
            {
                Way02Reverse(array, leftIndex, rightIndex);
                leftIndex = rightIndex + 1;
                rightIndex += groupSize;
            }

            Way02Reverse(array, leftIndex, arraySize - 1);
        }

        private static void Way02Reverse(int[] array, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                int temp = array[rightIndex];
                array[rightIndex] = array[leftIndex];
                array[leftIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way03()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Way03ReveseInGroup(array, array.Length, 3);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way03ReveseInGroup(int[] array, int arraySize, int groupSize)
        {
            for (int i = 0; i < arraySize; i += groupSize)
            {
                if (i + groupSize < arraySize)
                    Way03Reverse(array, i, i + groupSize - 1);
                else
                    Way03Reverse(array, i, arraySize - 1);
            }
        }

        private static void Way03Reverse(int[] array, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                int temp = array[rightIndex];
                array[rightIndex] = array[leftIndex];
                array[leftIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }
    }
}