namespace DSA.Course._04_Array
{
    internal static class _01_LargestElementInArray
    {
        // Time complexity - O(n²)
        internal static void Way01()
        {
            int[] arr = new int[] { 5, 18, 10, 3, 12 };

            for (int i = 0; i < arr.Length; i++)
            {
                bool isMaxNumber = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        isMaxNumber = false;
                        break;
                    }
                }
                if (isMaxNumber)
                {
                    Console.WriteLine($"Max number is {arr[i]}");
                    break;
                }
            }
        }

        // Time complexity - O(n)
        internal static void Way02()
        {
            int[] arr = new int[] { 5, 18, 10, 3, 12 };
            int maxNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                    maxNumber = arr[i];
            }

            Console.WriteLine($"Max number is {maxNumber}");
        }
    }
}
