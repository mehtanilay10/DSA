namespace DSA.Course._04_Array.Problems
{
    //Maximum Index
    //Medium    Accuracy: 24.5%     Submissions: 115K+      Points: 4

    //Given an array A[] of N positive integers.The task is to find the maximum of j - i subjected to the constraint of A[i] < A[j] and i<j.

    //Example 1:
    //--------------------
    //Input:
    // N = 2
    // A[] = { 1, 10}
    //Output:
    // 1
    //Explanation:
    //A[0]<A[1] so(j-i) is 1-0 = 1.

    //Example 2:
    //--------------------
    //Input:
    // N = 9
    // A[] = {34, 8, 10, 3, 2, 80, 30, 33, 1}
    //Output:
    // 6
    //Explanation:
    //In the given array A[1] < A[7] satisfying the required condition(A[i] < A[j]) thus giving the maximum difference of j - i which is 6(7-1).

    //Your Task:
    //The task is to complete the function maxIndexDiff() which finds and returns maximum index difference. Printing the output will be handled by driver code. Return 0 in case no such index is found.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)

    //Constraints:
    //1 ≤ N ≤ 107
    //0 ≤ A[i] ≤ 109
    internal static class _03_MaximumIndex
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int maxDiff = Way01FindMaximumIndex(array, array.Length);
            Console.WriteLine($"Maximum index difference: {maxDiff}");
        }

        private static int Way01FindMaximumIndex(int[] array, int size)
        {
            int maxDiff = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (array[i] <= array[j])
                        maxDiff = Math.Max(maxDiff, j - i);
                }
            }

            return maxDiff;
        }

        // Time complexity - O(n*Log(n))
        // Auxiliary Space - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int maxDiff = Way02FindMaximumIndex(array, array.Length);
            Console.WriteLine($"Maximum index difference: {maxDiff}");
        }

        private static int Way02FindMaximumIndex(int[] array, int size)
        {
            // Prepare sufix array of max value
            int[] maxRightSideValue = new int[size + 1];
            for (int i = 0; i < maxRightSideValue.Length; i++)
                maxRightSideValue[i] = int.MinValue;

            for (int i = array.Length - 1; i >= 0; i--)
                maxRightSideValue[i] = Math.Max(maxRightSideValue[i + 1], array[i]);

            // Do binary search to find value
            int maxDiff = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int low = i + 1, high = array.Length - 1, ans = i;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (array[i] <= maxRightSideValue[mid])
                    {
                        ans = Math.Max(ans, mid);
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }

                maxDiff = Math.Max(maxDiff, ans - i);
            }

            return maxDiff;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way03()
        {
            int[] array = new int[] { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int maxDiff = Way03FindMaximumIndex(array, array.Length);
            Console.WriteLine($"Maximum index difference: {maxDiff}");
        }

        private static int Way03FindMaximumIndex(int[] array, int size)
        {
            int[] rightMaxArray = new int[size];
            rightMaxArray[size - 1] = array[size - 1];
            for (int index = size - 2; index >= 0; index--)
                rightMaxArray[index] = Math.Max(rightMaxArray[index + 1], array[index]);

            int[] leftMinArray = new int[size];
            leftMinArray[0] = array[0];
            for (int index = 1; index < size; index++)
                leftMinArray[index] = Math.Min(leftMinArray[index - 1], array[index]);

            int i = 0, j = 0, maxDiff = -1;
            while (i < size && j < size)
            {
                if (leftMinArray[i] <= rightMaxArray[j])
                {
                    maxDiff = Math.Max(maxDiff, j - i);
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return maxDiff;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way04()
        {
            int[] array = new int[] { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int maxDiff = Way04FindMaximumIndex(array, array.Length);
            Console.WriteLine($"Maximum index difference: {maxDiff}");
        }

        private static int Way04FindMaximumIndex(int[] array, int size)
        {
            int[] leftMinArray = new int[size];
            leftMinArray[0] = array[0];
            for (int index = 1; index < leftMinArray.Length; index++)
                leftMinArray[index] = Math.Min(leftMinArray[index - 1], array[index]);

            int maxDiff = int.MinValue;
            int i = size - 1;
            int j = size - 1;
            while (i >= 0 && j >= 0)
            {
                if (array[j] >= leftMinArray[i])
                {
                    maxDiff = Math.Max(maxDiff, j - i);
                    i--;
                }
                else
                {
                    j--;
                }
            }

            return maxDiff;
        }
    }
}
