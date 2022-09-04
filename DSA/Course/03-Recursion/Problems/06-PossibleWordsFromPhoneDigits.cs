namespace DSA.Course._03_Recursion.Problems
{
    internal static class _06_PossibleWordsFromPhoneDigits
    {
        private static string[] KEYPAD = new string[] {
              "",
              "",
              "abc",
              "def",
              "ghi",
              "jkl",
              "mno",
              "pqrs",
              "tuv",
              "wxyz"
            };

        internal static void Way01()
        {
            int[] input = new int[] { 2, 4, 9 };
            List<string> result = new List<string>();
            Way01FindCombination(input, result);
            foreach (string word in result)
                Console.WriteLine(word);
        }

        private static void Way01FindCombination(int[] input, List<string> result, string currentText = "", int currentIndex = 0)
        {
            if (input.Length == currentIndex)
            {
                result.Add(currentText);
                return;
            }

            int digit = input[currentIndex];
            string keys = KEYPAD[digit];

            for (int i = 0; i < keys.Length; i++)
                Way01FindCombination(input, result, currentText + keys[i], currentIndex + 1);
        }
    }
}
