namespace DSA.Course._05_Search.Videos
{
    internal static class _01_LinearSearch
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 8, 3, 4, 2, 7, 1 };
            int number = 3;

            int index = Way01Search(array, number);
            Console.WriteLine($"FoundOnIndex: {index}");
        }

        private static int Way01Search(int[] array, int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }
    }
}
