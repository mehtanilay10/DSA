namespace DSA.Course._04_Array.Problems
{
    //Game of Chocolates
    //MediumAccuracy: 29.2%Submissions: 5K+Points: 4

    //Bunty and Dolly are playing a game, described as follows.
    //Game Description: -
    //There are two boxes having A and B number of chocolates respectively. Both can eat L (L ≥ 1) chocolates from any one box or L chocolates from both the boxes in one move. They play the game alternatively and the last one to eat the chocolate will be the winner.
    //As Bunty wants to impress Dolly, he wants to make Dolly the winner. You have to help Bunty in deciding who should play first. Assume that both the players play optimally.

    //Example 1:
    //--------------------
    //Input:
    // A = 1
    // B = 2
    //Output: Bunty
    //Explanation: If Bunty starts first, all the next possible state (0,2), (1,1), (1,0) are wining state for Dolly

    //Example 2:
    //--------------------
    //Input:
    // A = 1
    // B = 3
    //Output: Bunny

    //Your Task:  
    //You don't need to read input or print anything. Your task is to complete the function game() which takes the integer A and B as input parameters and returns false if Bunty should play first else returns true.

    //Expected Time Complexity: O(1)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //0 ≤ a, b ≤ 10^6
    internal static class _22_GameOfChocolates
    {
        // Time Complexity: O(1)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int a = 3;
            int b = 8;
            bool isDollyFirstPlays = Way01IsDollyFirstPlays(a, b);
            Console.WriteLine($"IsDollyFirstPlays: {isDollyFirstPlays}");
        }

        private static bool Way01IsDollyFirstPlays(int a, int b)
        {
            int absDiff = Math.Abs(b - a);
            double goldenRatio = (1 + Math.Sqrt(5)) / 2;
            double temp = goldenRatio * absDiff;

            return (Math.Min(a, b) != (int)temp);
        }
    }
}
