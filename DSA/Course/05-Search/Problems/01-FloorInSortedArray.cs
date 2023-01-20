using Helper;

namespace DSA.Course._05_Search.Problems
{
    //Floor in a Sorted Array
    //Easy      Accuracy: 33.75%     Submissions: 123K+     Points: 2

    //Given a sorted array arr[] of size N without duplicates, and given a value x. Floor of x is defined as the largest element K in arr[] such that K is smaller than or equal to x. Find the index of K(0-based indexing).

    //Example 1:
    //--------------------
    //Input:
    //  N = 7
    //  x = 0 
    //  arr[] = {1,2,8,10,11,12,19}
    //Output: -1
    //Explanation: No element less than 0 is found. So output is "-1".

    //Example 2:
    //--------------------
    //Input:
    //  N = 7
    //  x = 5 
    //  arr[] = {1,2,8,10,11,12,19}
    //Output: 1
    //Explanation: Largest Number less than 5 is 2 (i.e K = 2), whose index is 1(0-based indexing).

    //Your Task:
    //The task is to complete the function findFloor() which returns an integer denoting the index value of K or return -1 if there isn't any such number.

    //Expected Time Complexity: O(log N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 ≤ N ≤ 10^7
    //1 ≤ arr[i] ≤ 10^18
    //0 ≤ X ≤ arr[n-1]
    internal static class _01_FloorInSortedArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            long[] array = new long[] { 1, 2, 8, 10, 11, 12, 19 };
            long number = ConsoleHelper.ReadLong();

            int floorIndex = Way01FloorIndex(array, (long)array.Length, number);
            Console.WriteLine($"FloorIndex: {floorIndex}.");
        }

        private static int Way01FloorIndex(long[] array, long length, long number)
        {
            for (int i = 0; i < length; i++)
            {
                if(array[i] > number)
                    return i - 1;
            }
            
            return (int)length - 1;
        }
    }
}
