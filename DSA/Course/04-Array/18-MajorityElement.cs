namespace DSA.Course._04_Array
{
    internal static class _18_MajorityElement
    {
        // Time complexity - O(n²)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 8, 3, 4, 8, 8, 3, 3, 3 };
            int majorityElementCount = array.Length / 2;
            int majorityElementIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElementCount = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                        currentElementCount++;
                }

                if (currentElementCount > majorityElementCount)
                {
                    majorityElementIndex = i;
                    break;
                }
            }

            Console.WriteLine($"Majority Element Index: {majorityElementIndex}");
        }

        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        // Moore's Voting Algorithm
        internal static void Way02()
        {
            int[] array = new int[] { 8, 3, 4, 8, 8, 3, 8 };
            int majorityElementCount = array.Length / 2;
            int majorityElementIndex = -1;

            int candidateMajorityElementIndex = 0;
            int currentCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[candidateMajorityElementIndex])
                    currentCount++;
                else
                    currentCount--;

                if (currentCount == 0)
                {
                    candidateMajorityElementIndex = i;
                    currentCount = 1;
                }
            }

            int candidateMajorityElementCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[candidateMajorityElementIndex])
                    candidateMajorityElementCount++;
            }

            if (candidateMajorityElementCount > majorityElementCount)
                majorityElementIndex = candidateMajorityElementIndex;

            Console.WriteLine($"Majority Element Index: {majorityElementIndex}");
        }
    }
}
