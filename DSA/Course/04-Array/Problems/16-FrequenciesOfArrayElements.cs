using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Frequencies of Limited Range Array Elements
    //Easy      Accuracy: 27.64%        Submissions: 143K+      Points: 2

    //Given an array A[] of N positive integers which can contain integers from 1 to P where elements can be repeated or can be absent from the array.Your task is to count the frequency of all elements from 1 to N.
    //Note: The elements greater than N in the array can be ignored for counting and do modify the array in-place.

    //Example 1:
    //--------------------

    //Input:
    // N = 5
    // arr[] = { 2, 3, 2, 3, 5}
    // P = 5
    //Output:
    // 0 2 2 0 1
    //Explanation: Counting frequencies of each array element.
    //We have: 1 occurring 0 times. 2 occurring 2 times. 3 occurring 2 times. 4 occurring 0 times. 5 occurring 1 time.

    //Example 2:
    //--------------------
    //Input:
    // N = 4
    // arr[] = {3,3,3,3}
    // P = 3
    //Output:
    // 0 0 4 0
    //Explanation:
    //Counting frequencies of each array element
    //We have: 1 occurring 0 times. 2 occurring 0 times. 3 occurring 4 times. 4 occurring 0 times.

    //Your Task:
    //You don't need to read input or print anything. Complete the function frequencycount() that takes the array and n as input parameters and modify the array itself in place to denote the frequency count of each element from 1 to N. i,e element at index 0 should represent the frequency of 1, and so on.

    //Can you solve this problem without using extra space (O(1) Space)?

    //Constraints:
    //1 ≤ N ≤ 10^5
    //1 ≤ P ≤ 4 * 10^4
    //1 <= A[i] <= P
    internal static class _16_FrequenciesOfArrayElements
    {
        // Time Complexity: O(n)
        // Auxiliary Space: O(n)
        internal static void Way01()
        {
            int[] array = { 2, 3, 2, 3, 5 };
            int arrayLength = array.Length;
            int maxValue = array.Max();

            Way01GenerateFrequenciesOfArrayElements(array, arrayLength, maxValue);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01GenerateFrequenciesOfArrayElements(int[] array, int arrayLength, int maxValue)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arrayLength; i++)
            {
                if (dictionary.ContainsKey(array[i]))
                    dictionary[array[i]]++;
                else
                    dictionary.Add(array[i], 1);
            }

            for (int i = 0; i < arrayLength; i++)
            {
                if (dictionary.ContainsKey(i + 1))
                    array[i] = dictionary[i + 1];
                else
                    array[i] = 0;
            }
        }

        // Time Complexity: O(n)
        // Auxiliary Space: O(1)
        internal static void Way02()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 9, 8 };
            int arrayLength = array.Length;
            int maxValue = array.Max();

            Way02GenerateFrequenciesOfArrayElements(array, arrayLength, maxValue);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way02GenerateFrequenciesOfArrayElements(int[] array, int arrayLength, int maxValue)
        {
            // Traverse all array elements
            int i = 0;
            while (i < arrayLength)
            {
                // If this element is already processed, then nothing to do
                if (array[i] <= 0)
                {
                    i++;
                    continue;
                }

                // Find index corresponding to this element. For example, index for 5 is 4
                int elementIndex = array[i] - 1;

                // If the elementIndex has an element that is not processed yet,
                // then first store that element to arr[i] so that we don't loose anything.
                if (array[elementIndex] > 0)
                {
                    array[i] = array[elementIndex];

                    // After storing arr[elementIndex], change it to store initial count of 'arr[i]'
                    array[elementIndex] = -1;
                }
                else
                {
                    // If this is NOT first occurrence of arr[i], then decrement its count.
                    array[elementIndex]--;

                    // And initialize arr[i] as 0 means the element 'i+1' is not seen so far
                    array[i] = 0;
                    i++;
                }
            }

            for (int j = 0; j < arrayLength; j++)
                array[j] = Math.Abs(array[j]);
        }

        // Time Complexity: O(n)
        // Auxiliary Space: O(1)
        internal static void Way03()
        {
            int[] array = { 2, 3, 2, 3, 5 };
            //int[] array = { 1, 3, 4, 6, 8 };
            int arrayLength = array.Length;
            int maxValue = array.Max();

            Way03GenerateFrequenciesOfArrayElements(array, arrayLength, maxValue);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way03GenerateFrequenciesOfArrayElements(int[] array, int arrayLength, int maxValue)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if ((array[i] - 1) % (maxValue + 1) < arrayLength)
                    array[(array[i] - 1) % (maxValue + 1)] += (maxValue + 1);
            }

            for (int i = 0; i < arrayLength; i++)
                array[i] /= (maxValue + 1);
        }
    }
}
