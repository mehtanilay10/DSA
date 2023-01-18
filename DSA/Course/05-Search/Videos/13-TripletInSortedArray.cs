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
    }
}
