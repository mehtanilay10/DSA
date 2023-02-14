
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
    
        // Time complexity - O(log(n1))
        // Auxiliary Space - O(1)
        // Based on Binary operation, here first array must be smaller/equal size than second array
        internal static void Way02()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 10, 11, 12, 13, 14 };

            var median = Way02FindMedian(arr1, arr2);
            Console.WriteLine($"Median: {median}");
        }

        private static double Way02FindMedian(int[] array1, int[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;
            int start = 0;
            int end = array1.Length;

            while (start <= end)
            {
                int i1 = (start + end) / 2;
                int i2 = ((n1 + n2 + 1) / 2) - i1;

                int min1 = (i1 == n1) ? int.MaxValue : array1[i1];
                int max1 = (i1 == 0) ? int.MinValue : array1[i1 - 1];
                int min2 = (i2 == n2) ? int.MaxValue : array2[i2];
                int max2 = (i2 == 0) ? int.MinValue : array2[i2 - 1];

                if (max1 <= min2 && max2 <= min1)
                {
                    if ((n1 + n2) % 2 == 0)
                        return (double)(Math.Min(min1, min2) + Math.Max(max1, max2)) / 2;
                    else
                        return Math.Max(max1, max2);
                }
                else if (max1 > min2)
                    end = i1 - 1;
                else
                    start = i1 + 1;
            }

            return -1;
        }
    }
}
