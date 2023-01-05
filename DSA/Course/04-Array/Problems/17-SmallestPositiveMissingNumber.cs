namespace DSA.Course._04_Array.Problems
{
    //Smallest Positive missing number
    //Medium        Accuracy: 25.13%        Submissions: 202K+      Points: 4

    //You are given an array arr[] of N integers including 0. The task is to find the smallest positive number missing from the array.

    //Example 1:
    //--------------------
    //Input:
    // N = 5
    // arr[] = { 1,2,3,4,5}
    //Output: 6
    //Explanation: Smallest positive missing number is 6.

    //Example 2:
    //--------------------
    //Input:
    // N = 5
    // arr[] = {0,-10,1,3,-20}
    //Output: 2
    //Explanation: Smallest positive missing number is 2.

    //Your Task:
    //The task is to complete the function missingNumber() which returns the smallest positive missing number in the array.

    //Expected Time Complexity: O(N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 <= N <= 10^6
    //- 106 <= arr[i] <= 10^6
    internal static class _17_SmallestPositiveMissingNumber
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 0, -10, 1, 3, -20 };
            int missingNumber = Way01FindMissingNumber(array, array.Length);
            Console.WriteLine($"Smallest Positive missing number: {missingNumber}");
        }

        private static int Way01FindMissingNumber(int[] array, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                int correctIndex = array[i] - 1;
                while (correctIndex >= 0 && correctIndex <= arrayLength - 1 && array[i] != array[correctIndex])
                {
                    int temp = array[i];
                    array[i] = array[correctIndex];
                    array[correctIndex] = temp;
                    correctIndex = array[i] - 1;
                }
            }

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] != (i + 1))
                    return (i + 1);
            }

            return arrayLength + 1;
        }
    }
}
