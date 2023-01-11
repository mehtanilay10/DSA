using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Pattern searching
    //Easy      Accuracy: 63.69%        Submissions: 7K+        Points: 2

    //Given a string str and a pattern pat. You need to check whether the pattern is present or not in the given string. 

    //Example 1:-
    //--------------------
    //Input:
    // abcdefh
    // bcd
    //Output: Present

    //Example 2:-
    //--------------------
    //Input:
    // axzy
    // xy
    //Output: Not present

    //Your task: You need to complete the function searchPattern() containing string and text as an argument. You don't have to worry about input. 

    //Constraints:
    //1 <= T <= 100
    //1 <= |str| <= 100
    //1 <= |text| <= 100

    internal static class _25_PatternSearching
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            string text = ConsoleHelper.ReadString();
            string pattern = ConsoleHelper.ReadString("Pattern");
            bool isMatched = Way01IsPatternMatch(text, pattern);
            Console.WriteLine($"IsMatched: {isMatched}");
        }

        private static bool Way01IsPatternMatch(string text, string pattern)
        {
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                int j = 0;
                while (j < pattern.Length)
                {
                    if (text[i + j] != pattern[j])
                        break;
                    j++;
                }

                if (j == pattern.Length)
                    return true;
            }

            return false;
        }
    }
}
