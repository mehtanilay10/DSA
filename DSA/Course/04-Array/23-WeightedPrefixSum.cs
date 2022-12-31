using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Course._04_Array
{
    internal static class _23_WeightedPrefixSum
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 8, 9, 3, 4, 1, 6 };

            int sum1 = Way01FindWeightedSum(array, 0, 2);
            Console.WriteLine($"Sum1: {sum1}");
            int sum2 = Way01FindWeightedSum(array, 1, 4);
            Console.WriteLine($"Sum2: {sum2}");
            int sum3 = Way01FindWeightedSum(array, 5, 6);
            Console.WriteLine($"Sum3: {sum3}");
        }

        private static int Way01FindWeightedSum(int[] array, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex, weight = 1; i <= endIndex; i++, weight++)
                sum = sum + (array[i] * weight);

            return sum;
        }

        // Time complexity - O(1)
        // Auxiliary Space - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 2, 3, 5, 4, 6, 1 };

            int[] preSumArray = new int[array.Length];
            preSumArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                preSumArray[i] = preSumArray[i - 1] + array[i];

            int[] preWeightedSumArray = new int[array.Length];
            preWeightedSumArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                preWeightedSumArray[i] = preWeightedSumArray[i - 1] + (array[i] * (i + 1));

            int sum1 = Way02FindWeightedSum(preSumArray, preWeightedSumArray, 0, 2);
            Console.WriteLine($"Sum1: {sum1}");
            int sum2 = Way02FindWeightedSum(preSumArray, preWeightedSumArray, 2, 3);
            Console.WriteLine($"Sum2: {sum2}");
            int sum3 = Way02FindWeightedSum(preSumArray, preWeightedSumArray, 3, 5);
            Console.WriteLine($"Sum3: {sum3}");
        }

        // TODO: Need to check, sometime it does not work
        private static int Way02FindWeightedSum(int[] preSumArray, int[] preWeightedSumArray, int startIndex, int endIndex)
        {
            if (startIndex == 0)
                return preWeightedSumArray[endIndex];

            return preWeightedSumArray[endIndex] - preSumArray[endIndex];
        }
    }
}
