using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Course._04_Array.Problems
{
    //Rotate Array
    //Easy      Accuracy: 37.06%    Submissions: 195K+      Points: 2

    //Given an unsorted array arr[] of size N.Rotate the array to the left (counter-clockwise direction) by D steps, where D is a positive integer.

    //Example 1:
    //--------------------
    //Input:
    // N = 5, D = 2
    // arr[] = {1,2,3,4,5}
    //Output: 3 4 5 1 2
    //Explanation: 1 2 3 4 5  when rotated by 2 elements, it becomes 3 4 5 1 2.

    //Example 2:
    //--------------------
    //Input:
    // N = 10, D = 3
    // arr[] = { 2,4,6,8,10,12,14,16,18,20}
    //Output: 8 10 12 14 16 18 20 2 4 6
    //Explanation: 2 4 6 8 10 12 14 16 18 20 when rotated by 3 elements, it becomes 8 10 12 14 16 18 20 2 4 6.

    //Your Task:
    //Complete the function rotateArr() which takes the array, D and N as input parameters and rotates the array by D elements. The array must be modified in-place without using extra space.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 <= N <= 10^6
    //1 <= D <= 10^6
    //0 <= arr[i] <= 10^5
    internal static class _06_RotateArray
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int steps = 15;
            int arraySize = array.Length;

            steps = steps % arraySize; // Kind of validation
            Way01ReverseArray(array, 0, steps - 1);
            Way01ReverseArray(array, steps, arraySize - 1);
            Way01ReverseArray(array, 0, arraySize - 1);

            ConsoleHelper.PrintArray(array);
        }

        private static void Way01ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
