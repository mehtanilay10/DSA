using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Course._04_Array
{
    internal static class _22_PrefixSum
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 5, 3, 6, 2, 7, 4 };

            int sum1 = Way01FindSum(array, 0, 2);
            Console.WriteLine($"Sum1: {sum1}");
            int sum2 = Way01FindSum(array, 1, 4);
            Console.WriteLine($"Sum2: {sum2}");
            int sum3 = Way01FindSum(array, 3, 5);
            Console.WriteLine($"Sum3: {sum3}");
        }

        private static int Way01FindSum(int[] array, int startIndex, int endindex)
        {
            int sum = 0;
            for (int i = startIndex; i <= endindex; i++)
                sum += array[i];

            return sum;
        }

        // Time complexity - O(1)
        // Auxiliary Space - O(n)
        internal static void Way02()
        {
            int[] array = new int[] { 5, 3, 6, 2, 7, 4 };

            int[] preSumOfArray = new int[array.Length];
            preSumOfArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
                preSumOfArray[i] = preSumOfArray[i - 1] + array[i];

            int sum1 = Way02FindSum(preSumOfArray, 0, 2);
            Console.WriteLine($"Sum1: {sum1}");
            int sum2 = Way02FindSum(preSumOfArray, 1, 4);
            Console.WriteLine($"Sum2: {sum2}");
            int sum3 = Way02FindSum(preSumOfArray, 3, 5);
            Console.WriteLine($"Sum3: {sum3}");
        }

        private static int Way02FindSum(int[] preSumOfArray, int startIndex, int endindex)
        {
            if (startIndex == 0)
                return preSumOfArray[endindex];

            return preSumOfArray[endindex] - preSumOfArray[startIndex - 1];
        }
    }
}
