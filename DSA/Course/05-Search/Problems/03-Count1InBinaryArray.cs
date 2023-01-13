namespace DSA.Course._05_Search.Problems
{
    //Count 1's in binary array
    //Easy      Accuracy: 49.3%     Submissions: 39K+       Points: 2

    //Given a binary sorted non-increasing array of 1s and 0s. You need to print the count of 1s in the binary array.

    //Example 1:
    //--------------------
    //Input:
    // N = 8
    // arr[] = {1,1,1,1,1,0,0,0}
    //Output: 5
    //Explanation: Number of 1's in given  binary array : 1 1 1 1 1 0 0 0 is 5.

    //Example 2:
    //--------------------
    //Input:
    //N = 8
    //arr[] = {1,1,0,0,0,0,0,0}
    //Output: 2
    //Explanation: Number of 1's in given binary array : 1 1 0 0 0 0 0 0 is 2.

    //Your Task:
    //The task is to complete the function countOne() which takes the array arr[] and its size N as inputs and returns the count of 1s in the input array.

    //Expected Time Complexity: O(LogN).
    //Expected Auxiliary Space: O(1).

    //Constraint:
    //1 <= N <= 5*10^6
    //arr[i] = 0,1
    internal static class _03_Count1InBinaryArray
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 1, 1, 1, 0 };

            int counts = Way01FindCounts(array, array.Length);
            Console.WriteLine($"1 Founds {counts} times.");
        }

        private static int Way01FindCounts(int[] array, int length)
        {
            int low = 0;
            int high = length - 1;

            if (array[0] == 0)
                return 0;
            else if (array[length - 1] == 1)
                return length;
            else
            {
                while (low <= high)
                {
                    int mid = low + ((high - low) / 2);
                    if (array[mid] == 0)
                    {
                        if (array[mid - 1] != 0)
                            return mid;
                        else
                            high = mid - 1;
                    }
                    else
                        low = mid + 1;
                }

                return 0;
            }
        }
    }
}
