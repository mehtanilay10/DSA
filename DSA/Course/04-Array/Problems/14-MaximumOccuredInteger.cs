namespace DSA.Course._04_Array.Problems
{
    //Maximum occured integer
    //Easy      Accuracy: 32.93%        Submissions: 42K+       Points: 2

    //Given n integer ranges, the task is to find the maximum occurring integer in these ranges.If more than one such integer exists, find the smallest one. The ranges are given as two arrays L[] and R[].  L[i] consists of starting point of range and R[i] consists of corresponding end point of the range.

    //For example consider the following ranges.
    //L[] = { 2, 1, 3}, R[] = {5, 3, 9)
    //Ranges represented by above arrays are.
    //[2, 5] = { 2, 3, 4, 5}
    //        [1, 3] = {1, 2, 3}
    //[3, 9] = {3, 4, 5, 6, 7, 8, 9}
    //The maximum occurred integer in these ranges is 3.

    //Example 1:
    //--------------------
    //Input:
    // n = 4
    // L[] = {1,4,3,1}
    // R[] = {15,8,5,4}
    //Output: 4
    //Explanation: The given ranges are[1, 15][4, 8][3, 5][1, 4]. The number that is most common or appears most times in the ranges is 4.

    //Example 2:
    //--------------------
    //Input:
    // n = 5
    // L[] = {1,5,9,13,21}
    // R[] = {15,8,12,20,30}
    //Output: 5
    //Explanation: The given ranges are [1, 15] [5, 8] [9, 12] [13, 20] [21, 30]. The number that is most common or appears most times in the ranges is 5.

    //Your Task:
    //The task is to complete the function maxOccured() which returns the maximum occured integer in all ranges.

    //Expected Time Complexity: O(n+maxx).
    //Expected Auxiliary Space: O(maxx).
    //-maxx is maximum element in R[]

    //Constraints:
    //1 ≤ n ≤ 10^6
    //0 ≤ L[i], R[i] ≤ 10^6
    internal static class _14_MaximumOccuredInteger
    {
        // Time Complexity: O(n+max)
        // Auxiliary Space: O(max)
        internal static void Way01()
        {
            int[] leftArray = new int[] { 1, 4, 3, 1 };
            int[] rightArray = new int[] { 15, 8, 5, 4 };

            int maxValue = Math.Max(leftArray.Max(), rightArray.Max());
            int maxOccurance = Way01FindMaxOccurance(leftArray, rightArray, leftArray.Length, maxValue);
            Console.WriteLine($"Max Occurance Value: {maxOccurance}");
        }

        private static int Way01FindMaxOccurance(int[] leftArray, int[] rightArray, int arraySize, int maximumNumber)
        {
            // Need to create array with 2 more size than max size
            maximumNumber += 2;

            int[] valueRange = new int[maximumNumber];

            for (int i = 0; i < arraySize; i++)
            {
                valueRange[leftArray[i]]++;
                valueRange[rightArray[i] + 1]--;
            }

            int[] prefixSumArray = new int[maximumNumber];
            prefixSumArray[0] = valueRange[0];
            for (int i = 1; i < maximumNumber; i++)
                prefixSumArray[i] = valueRange[i] + prefixSumArray[i - 1];

            int maxValueIndex = 0;
            for (int i = 0; i < maximumNumber; i++)
            {
                if (prefixSumArray[i] > prefixSumArray[maxValueIndex])
                    maxValueIndex = i;
            }

            return maxValueIndex;
        }
    }
}
