namespace DSA.Course._04_Array.Problems
{
    //Fraction Trouble
    //Easy      Accuracy: 58.85%        Submissions: 1K+    Points: 2

    //Consider the set of irreducible fractions A = {n/d | n≤d and d ≤ 10000 and gcd(n,d) = 1}.You are given a member of this set and your task is to find the largest fraction in this set less than the given fraction.
    //Note : this is a set and so all the members are unique.

    //Example 1:
    //--------------------
    //Input: n = 1, d = 8
    //Output: 1249 9993
    //Explanation: 1/8 >= 1249/9993 and this is the largest fraction. 

    //Example 2:
    //--------------------
    //Input: n = 2, d = 53
    //Output: 377 9991
    //Explanation: 2/53 >= 377/9991 and this is the largest fraction.

    //Your Task:
    //You don't need to read or print anything. Your task is to complete the function LargestFraction() which takes n and d as input parameter and returns the largest irreducible fraction in a list where the first element denotes the numerator and second elements denotes the denominator of the fraction.

    //Expected Time Complexity: O(K) where K <= 10000
    //Expected Space Complexity: O(1)

    //Constraints: 
    //1 <= n <= d <= 10000

    internal static class _24_FractionTrouble
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int numerator = 5;
            int denominator = 8;
            int[] newFraction = Way01FindLargestFraction(numerator, denominator);
            Console.WriteLine($"{numerator}/{denominator} => {newFraction[0]}/{newFraction[1]}");
        }

        private static int[] Way01FindLargestFraction(int n, int d)
        {
            int MAX_NUMBER = 10000;
            int maxNumerator = -1;
            int maxDenominator = 1;

            for (int denominator = MAX_NUMBER; denominator > 1; denominator--)
            {
                int numerator = (n * denominator - 1) / d;
                if ((Way01FindGCD(numerator, denominator) == 1) &&
                    (numerator * maxDenominator >= denominator * maxNumerator))
                {
                    maxNumerator = numerator;
                    maxDenominator = denominator;
                }
            }

            return new int[] { maxNumerator, maxDenominator };
        }

        private static int Way01FindGCD(int n1, int n2)
        {
            if (n2 == 0)
                return n1;

            return Way01FindGCD(n2, n1 % n2);
        }
    }
}
