using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Rearrange an array with O(1) extra space
    //Medium        Accuracy: 56.34%        Submissions: 73K+       Points: 4

    //Given an array arr[] of size N where every element is in the range from 0 to n-1. Rearrange the given array so that arr[i] becomes arr[arr[i]].

    //Example 1:
    //--------------------
    //Input:
    // N = 2
    // arr[] = {1,0}
    //Output: 0 1
    //Explanation: arr[arr[0]] = arr[1] = 0, arr[arr[1]] = arr[0] = 1.

    //Example 2:
    //--------------------
    //Input:
    // N = 5
    // arr[] = {4,0,2,1,3}
    //Output: 3 4 2 0 1
    //Explanation: arr[arr[0]] = arr[4] = 3, arr[arr[1]] = arr[0] = 4 and so on.

    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function arrange() which takes arr and N as input parameters and rearranges the elements in the array in-place. 

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 <= N <= 10^7
    //0 <= Arr[i] < N
    internal static class _19_RearrangeArrayWithExtraSpace
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(N)
        internal static void Way01()
        {
            int[] array = new int[] { 4, 0, 2, 1, 3 };
            Way01Rearrange(array, array.Length);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01Rearrange(int[] arr, int n)
        {
            int[] newArray = new int[n];
            for (int i = 0; i < n; i++)
                newArray[i] = arr[arr[i]];

            for (int i = 0; i < n; i++)
                arr[i] = newArray[i];
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 4, 0, 2, 1, 3 };
            Way02Rearrange(array, array.Length);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way02Rearrange(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                arr[i] = arr[i] + (arr[arr[i]] % n) * n;
                
            for (int i = 0; i < n; i++)
                arr[i] = arr[i] / n;
        }
    }
}
