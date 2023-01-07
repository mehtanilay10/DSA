namespace DSA.Course._04_Array.Problems
{
    //Check if array is sorted and rotated
    //Medium        Accuracy: 26.04%        Submissions: 34K+       Points: 4

    //Given an array arr[] of N distinct integers, check if this array is Sorted (non-increasing or non-decreasing) and Rotated counter-clockwise. Note that input array may be sorted in either increasing or decreasing order, then rotated.
    //A sorted array is not considered as sorted and rotated, i.e., there should be at least one rotation.

    //Example 1:
    //--------------------
    //Input:
    // N = 4
    // arr[] = {3,4,1,2}
    //Output: Yes
    //Explanation: The array is sorted (1, 2, 3, 4) and rotated twice (3, 4, 1, 2).

    //Example 2:
    //--------------------
    //Input:
    // N = 3
    // arr[] = {1,2,3}
    //Output: No
    //Explanation: The array is sorted (1, 2, 3) is not rotated.

    //Your Task:
    //The task is to complete the function checkRotatedAndSorted() which returns true if an array is sorted and rotated clockwise otherwise false.

    //Expected Time Complexity: O(N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 <= N <= 10^6
    //1 <= A[i] <= 10^6
    internal static class _20_CheckArrayIsSortedAndRotated
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 4, 2, 1, 3 };
            bool isSorted = Way01IsSorted(array, array.Length);
            Console.WriteLine($"IsSorted: {isSorted}");
        }

        private static bool Way01IsSorted(int[] array, int arrayLength)
        {
            int increasingValueCount = 0;
            int decreasingValueCount = 0;

            if (array[arrayLength - 1] > array[0])
            {
                for (int i = 1; i < arrayLength; i++)
                {
                    if (array[i] > array[i - 1])
                        increasingValueCount++;
                }

                return increasingValueCount == 1;
            }
            else
            {
                for (int i = 1; i < arrayLength; i++)
                {
                    if (array[i] < array[i - 1])
                        decreasingValueCount++;
                }

                return decreasingValueCount == 1;
            }
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 3, 4, 1, 2 };
            bool isSorted = Way02IsSorted(array, array.Length);
            Console.WriteLine($"IsSorted: {isSorted}");
        }

        private static bool Way02IsSorted(int[] array, int arrayLength)
        {
            int increasingValueCount = 0;
            int decreasingValueCount = 0;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] > array[i + 1] && array[0] > array[arrayLength - 1])
                    increasingValueCount++;

                if (array[i] < array[i + 1] && array[0] < array[arrayLength - 1])
                    decreasingValueCount++;
            }

            return (increasingValueCount == 1 || decreasingValueCount == 1);
        }
    }
}
