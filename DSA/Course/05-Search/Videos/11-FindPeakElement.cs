namespace DSA.Course._05_Search.Videos
{
    internal static class _11_FindPeakElement
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 8, 10, 12, 9, 7, 3 };
            int peakElement = Way01FindPeakElement(array);
            if(peakElement == -1)
                Console.WriteLine("Not found any peak element in the array");
            else
                Console.WriteLine($"Peak element: {peakElement}");
        }

        private static int Way01FindPeakElement(int[] array)
        {
            if (array.Length == 1)
                return array[0];
            if (array.Length > 2)
            {
                if (array[0] >= array[1])
                    return array[0];
                if (array[array.Length - 1] >= array[array.Length - 2])
                    return array[array.Length - 1];
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i - 1] && array[i] >= array[i + 1])
                    return array[i];
            }

            return -1;
        }

        // Time complexity - O(Log(n))
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 8, 10, 12, 9, 7, 3 };
            int peakElement = Way02FindPeakElement(array);
            if (peakElement == -1)
                Console.WriteLine("Not found any peak element in the array");
            else
                Console.WriteLine($"Peak element: {peakElement}");
        }

        private static int Way02FindPeakElement(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if ((mid == 0 || array[mid] >= array[mid - 1]) &&
                    (mid == array.Length - 1 || array[mid] >= array[mid + 1]))
                    return array[mid];

                if (mid > 0 && array[mid - 1] >= array[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }
}
