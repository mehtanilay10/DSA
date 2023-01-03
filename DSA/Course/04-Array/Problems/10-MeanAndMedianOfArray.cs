namespace DSA.Course._04_Array.Problems
{
    //Mean And Median of Array
    //Easy      Accuracy: 44.05%        Submissions: 55K+       Points: 2

    //Given an array a[] of size N.The task is to find the median and mean of the array elements.Mean is average of the numbers and median is the element which is smaller than half of the elements and greater than remaining half.If there are odd elements, the median is simply the middle element in the sorted array.If there are even elements, then the median is floor of average of two middle numbers in the sorted array.If mean is floating point number, then we need to print floor of it.
    //Note: To find the median, you might need to sort the array.Since sorting is covered in later tracks, we have already provided the sort function to you in the code.

    //Example 1:
    //--------------------
    //Input:
    // N = 5
    // a[] = { 1, 2, 19, 28, 5}
    //Output: 11 5
    //Explanation: For array of 5 elements, mean is (1 + 2 + 19  + 28  + 5)/5 = 11. Median is 5 (middle element after sorting)

    //Example 2:
    //--------------------
    //Input:
    // N = 4
    // a[] = {2, 8, 3, 4}
    //Output: 4 3
    //Explanation: For array of 4 elements, mean is floor((2 + 8 + 3 + 4) / 4) = 4. Median is floor((4 + 3) / 2) = 3

    //Your Task:
    //You don't need to read input or print anything.. You just need to complete the following two function:

    //mean(): It takes the array and its size N as parameters and returns the mean as an integer.
    //median(): It takes the array and its size N as parameters and returns the median as an integer.

    //Expected Time Complexity: O(N log(N)).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //1 <= N <= 10^6
    //1 <= a[i] <= 10^6
    internal static class _10_MeanAndMedianOfArray
    {
        // Time Complexity: O(N log(N))
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 2, 19, 28, 5 };
            int mean = Way01FindMean(array, array.Length);
            int median = Way01FindMedian(array, array.Length);

            Console.WriteLine($"Mean: {mean}, Median: {median}");
        }

        private static int Way01FindMean(int[] array, int arrayLength)
        {
            int sum = 0;
            for (int i = 0; i < arrayLength; i++)
                sum += array[i];

            return sum / arrayLength;
        }

        private static int Way01FindMedian(int[] array, int arrayLength)
        {
            Array.Sort(array);
            if (arrayLength % 2 == 0)
            {
                int middleIndexEnd = arrayLength / 2;
                int sumOfMiddleIndexes = array[middleIndexEnd - 1] + array[middleIndexEnd];
                return sumOfMiddleIndexes / 2;
            }
            else
            {
                int middleIndex = arrayLength / 2;
                return array[middleIndex];
            }
        }
    }
}
