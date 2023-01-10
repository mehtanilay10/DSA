﻿using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    //Matchsticks game
    //MediumAccuracy: 62.44%Submissions: 8K+Points: 4

    //Two friends, A and B, are playing the game of matchsticks. In this game, a group of N matchsticks is placed on the table. The players can pick any number of matchsticks from 1 to 4 (both inclusive) during their chance. The player who takes the last match stick wins the game. If A starts first, how many matchsticks should he pick on his 1st turn such that he is guaranteed to win the game or determine if it's impossible for him to win. Return -1 if it's impossible for A to win the game, else return the number of matchsticks should he pick on his 1st turn such that he is guaranteed to win.
    //Note : Consider both A and B play the game optimally.

    //Example 1:

    //--------------------
    //Input:
    // N = 48
    //Output: 3
    //Explanation: Player A is guaranteed a win if he picks 3 matchsticks first.

    //Example 2:
    //--------------------
    //Input:
    //N = 15
    //Output: -1
    //Explanation: Player A is guaranteed a loss no matter how many matches he picks at first.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function matchGame() which takes an Integer N as input and returns the answer.

    //Expected Time Complexity: O(1)
    //Expected Auxiliary Space: O(1)

    //Constraints:
    //1 <= N <= 10^18
    internal class _10_MatchsticksGame
    {
        // Time Complexity: O(1)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            long number = ConsoleHelper.ReadLong();
            int numberOfSticks = Way01FindNumberOfSticksToPick(number);
            Console.WriteLine($"NumberOfSticksToPick: {numberOfSticks}");
        }

        private static int Way01FindNumberOfSticksToPick(long number)
        {
            int reminder = (int)(number % 5);
            return reminder == 0 ? -1 : reminder;
        }
    }
}
