namespace DSA.Course._04_Array
{
    internal static class _02_SecondLargestElementIndexInArray
    {
        // Time complexity - O(n)
        internal static void Way01()
        {
            int[] arr = new int[] { 25, 33, 18, 15, 12 };
            int firstMaxValueIndex = 0;
            int secondMaxValueIndex = -1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[firstMaxValueIndex])
                {
                    secondMaxValueIndex = firstMaxValueIndex;
                    firstMaxValueIndex = i;
                }
                if (arr[i] < arr[firstMaxValueIndex] && arr[i] > arr[secondMaxValueIndex])
                {
                    secondMaxValueIndex = i;
                }
            }

            Console.WriteLine($"Second max value index - {secondMaxValueIndex}");
        }

        // Time complexity - O(n²)
        internal static void Way02()
        {
            int[] arr = new int[] { 5, 18, 10, 3, 12 };
            int firstLargestNumberIndex = Way02FindLargestIndex(arr);
            int secondLargestNumberIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[firstLargestNumberIndex])
                {
                    if (secondLargestNumberIndex == -1)
                        secondLargestNumberIndex = i;
                    if (arr[i] > arr[secondLargestNumberIndex])
                        secondLargestNumberIndex = i;
                }
            }

            Console.WriteLine($"Second Largest Index is {secondLargestNumberIndex}");
        }

        // Time complexity - O(n)
        internal static int Way02FindLargestIndex(int[] arr)
        {
            int maxNumberIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxNumberIndex])
                    maxNumberIndex = i;
            }

            return maxNumberIndex;
        }
    }
}
