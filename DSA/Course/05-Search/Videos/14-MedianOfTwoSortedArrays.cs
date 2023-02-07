
namespace DSA.Course._05_Search.Videos
{
    internal static class _14_MedianOfTwoSortedArrays
    {
        // Time complexity - O(n1+n2)
        // Auxiliary Space - O(n1+n2)
        internal static void Way01()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 10, 11, 12, 13, 14 };

            var median = Way01FindMedian(arr1, arr2);
            Console.WriteLine($"Median: {median}");
        }

        private static double Way01FindMedian(int[] arr1, int[] arr2)
        {
            int[] sortedArray = Way01DoMergeSort(arr1, arr2);
            bool hasSingleMedian = (sortedArray.Length % 2) != 0;
            int middleIndex = (sortedArray.Length / 2);

            if (hasSingleMedian)
                return sortedArray[middleIndex];
            else
                return (sortedArray[middleIndex - 1] + sortedArray[middleIndex]) / 2.0;
        }

        private static int[] Way01DoMergeSort(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];

            int x = 0, y = 0, z = 0;
            while (x < arr1.Length || y < arr2.Length)
            {
                if (x < arr1.Length && arr1[x] < arr2[y])
                    mergedArray[z++] = arr1[x++];
                else if (y < arr2.Length)
                    mergedArray[z++] = arr2[y++];
            }

            return mergedArray;
        }
    }
}
