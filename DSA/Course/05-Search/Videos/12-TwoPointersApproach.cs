using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _12_TwoPointersApproach
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 3, 5, 8, 10, 12, 15, 18, 20, 25 };
            int number = ConsoleHelper.ReadInteger();
            bool isPairExists = Way01IsPairExists(array, number);
            Console.WriteLine($"IsPairExists: {isPairExists}");
        }

        private static bool Way01IsPairExists(int[] array, int number)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (number == array[i] + array[j])
                        return true;
                }
            }

            return false;
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 3, 5, 8, 10, 12, 15, 18, 20, 25 };
            int number = ConsoleHelper.ReadInteger();
            bool isPairExists = Way02IsPairExists(array, number);
            Console.WriteLine($"IsPairExists: {isPairExists}");
        }

        private static bool Way02IsPairExists(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low < high)
            {
                int sum = array[low] + array[high];
                if (sum == number)
                    return true;

                if (sum > number)
                    high--;
                else
                    low++;
            }

            return false;
        }
    }
}
