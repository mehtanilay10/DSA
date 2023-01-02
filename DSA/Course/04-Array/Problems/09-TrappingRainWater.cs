namespace DSA.Course._04_Array.Problems
{
    //Trapping Rain Water
    //Medium    Accuracy: 33.14%    Submissions: 312K+  Points: 4

    //Given an array arr[] of N non-negative integers representing the height of blocks.If width of each block is 1, compute how much water can be trapped between the blocks during the rainy season.

    //Example 1:
    //--------------------
    //Input:
    // N = 6
    // arr[] = { 3,0,0,2,0,4}
    //Output:
    // 10

    //Example 2:
    //--------------------
    //Input:
    // N = 4
    // arr[] = {7,4,0,9}
    //Output:
    // 10
    //Explanation: Water trapped by above block of height 4 is 3 units and above block of height 0 is 7 units. So, the total unit of water trapped is 10 units.

    //Example 3:
    //--------------------
    //Input:
    // N = 3
    // arr[] = { 6,9,9}
    //Output:
    // 0
    //Explanation: No water will be trapped.

    //Your Task:
    //You don't need to read input or print anything. The task is to complete the function trappingWater() which takes arr[] and N as input parameters and returns the total amount of water that can be trapped.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)

    //Constraints:
    //3 < N < 10^6
    //0 < Ai < 10^8
    internal static class _09_TrappingRainWater
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(n)
        internal static void Way01()
        {
            int[] array = new int[] { 8, 8, 2, 4, 5, 5, 1 };
            var trappedWater = Way01FindTrappingWater(array, array.Length);
            Console.WriteLine($"TrappedWater: {trappedWater}");
        }

        private static long Way01FindTrappingWater(int[] array, int length)
        {
            int[] leftMaxArray = new int[length];
            leftMaxArray[0] = array[0];
            for (int i = 1; i < length; i++)
                leftMaxArray[i] = Math.Max(leftMaxArray[i - 1], array[i]);

            int[] rightMaxArray = new int[length];
            rightMaxArray[length - 1] = array[length - 1];
            for (int i = length - 2; i >= 0; i--)
                rightMaxArray[i] = Math.Max(rightMaxArray[i + 1], array[i]);

            long trappedWater = 0;
            for (int i = 1; i < length; i++)
                trappedWater += Math.Min(leftMaxArray[i], rightMaxArray[i]) - array[i];

            return trappedWater;
        }
    }
}
