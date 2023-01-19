using Helper;

namespace DSA.Course._05_Search.Videos
{
    internal static class _13_TripletInSortedArray
    {
        // Time complexity - O(n³)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 3, 5, 8, 10, 12, 15, 20, 24 };
            int sum = ConsoleHelper.ReadInteger("Sum");

            bool isTripletExist = Way01IsTripletExist(array, sum);
            Console.WriteLine($"IsTripletExist: {isTripletExist}");
        }

        private static bool Way01IsTripletExist(int[] array, int sum)
        {
            for(int i = 0; i < array.Length - 2; i++)
            {
                for(int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == sum)
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} + {array[k]} == {sum}");
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 3, 5, 8, 10, 12, 15, 20, 24 };
            int sum = ConsoleHelper.ReadInteger("Sum");

            bool isTripletExist = Way02IsTripletExist(array, sum);
            Console.WriteLine($"IsTripletExist: {isTripletExist}");
        }

        private static bool Way02IsTripletExist(int[] array, int sum)
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                int expectedPairSum = sum - array[i];
                bool isPairExist = Way02IsPairExist(array, expectedPairSum, i + 1);
                if (isPairExist)
                    return true;
            }

            return false;
        }

        private static bool Way02IsPairExist(int[] array, int expectedPairSum, int startIndex)
        {
            int low = startIndex;
            int high = array.Length - 1;

            while (low < high)
            {
                int pairSum = array[low] + array[high];

                if (pairSum == expectedPairSum)
                {
                    Console.WriteLine($"{array[startIndex]} + {array[low]} + {array[high]}");
                    return true;
                }

                if (pairSum > expectedPairSum)
                    high--;
                else
                    low++;
            }

            return false;
        }
    }
}
