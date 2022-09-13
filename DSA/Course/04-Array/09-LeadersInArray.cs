namespace DSA.Course._04_Array
{
    internal static class _09_LeadersInArray
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 5, 6, 3, 7, 4, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                bool isLeader = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        isLeader = false;
                        break;
                    }
                }

                if (isLeader)
                    Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way02()
        {
            int[] array = new int[] { 1, 5, 6, 3, 7, 4, 2 };

            int currentLeader = array[array.Length - 1];
            Console.WriteLine(currentLeader);

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] > currentLeader)
                {
                    currentLeader = array[i];
                    Console.WriteLine(currentLeader);
                }
            }
        }
    }
}
