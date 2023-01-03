namespace DSA.Course._04_Array.Problems
{
    //Who has the majority?
    //Basic     Accuracy: 44.36%     Submissions: 74K+      Points: 1

    //Given an array arr[] of size N and two elements x and y, use counter variables to find which element appears most in the array, x or y.If both elements have the same frequency, then return the smaller element.
    //Note:  We need to return the element, not its count.

    //Example 1:
    //--------------------
    //Input:
    // N = 11
    // arr[] = { 1,1,2,2,3,3,4,4,4,4,5}
    // x = 4
    // y = 5
    //Output: 4
    //Explanation: frequency of 4 is 4. frequency of 5 is 1.

    //Example 2:
    //--------------------
    //Input:
    // N = 8
    // arr[] = {1,2,3,4,5,6,7,8}
    // x = 1
    // y = 7
    //Output: 1
    //Explanation: frequency of 1 is 1. frequency of 7 is 1. Since 1 < 7, return 1.

    //Your Task:
    //You don't need to read input or print anything. Complete the function majorityWins() that takes array, n, x, y as input parameters and return the element with higher frequency.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 <= n <= 10^3
    //0 <= arri , x , y <= 10^8
    internal static class _11_WhoHasTheMajority
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int[] array = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5 };
            int numberX = 4;
            int numberY = 5;

            int majorityValue = Way01FindMajority(array, array.Length, numberX, numberY);
            Console.WriteLine($"Majority value: {majorityValue}");
        }

        private static int Way01FindMajority(int[] array, int arrayLength, int numberX, int numberY)
        {
            int countsForX = 0;
            int countsForY = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] == numberX)
                    countsForX++;
                else if (array[i] == numberY)
                    countsForY++;
            }

            if (countsForX > countsForY)
                return numberX;

            if (countsForY > countsForX)
                return numberY;

            return Math.Min(numberX, numberY);
        }
    }
}
