namespace DSA.Course._04_Array.Problems
{
    //Stock buy and sell
    //Easy      Accuracy: 29.18%    Submissions: 220K+      Points: 2

    //The cost of stock on each day is given in an array A[] of size N.Find all the segments of days on which you buy and sell the stock so that in between those days your profit is maximum.
    //Note: Since there can be multiple solutions, the driver code will print 1 if your answer is correct, otherwise, it will return 0. In case there's no profit the driver code will print the string "No Profit" for a correct solution.

    //Example 1:
    //--------------------
    //Input:
    // N = 7
    // A[] = { 100,180,260,310,40,535,695}
    //Output:
    // 1
    //Explanation: One possible solution is (0 3) (4 6) We can buy stock on day 0, and sell it on 3rd day, which will give us maximum profit.Now, we buy stock on day 4 and sell it on day 6.

    //Example 2:
    //--------------------
    //Input:
    // N = 5
    // A[] = {4,2,2,2,4}
    //Output:
    // 1
    //Explanation: There are multiple possible solutions. one of them is (3 4) We can buy stock on day 3, and sell it on 4th day, which will give us maximum profit.

    //Your Task:
    //The task is to complete the function stockBuySell() which takes an array A[] and N as input parameters and finds the days of buying and selling stock. The function must return a 2D list of integers containing all the buy-sell pairs i.e. first value of pair will represent the day on which you buy the stock and second value represent the day on which you sell that stock. If there is No Profit, return an empty list.

    //Expected Time Complexity: O(N)
    //Expected Auxiliary Space: O(N)

    //Constraints:
    //2 ≤ N ≤ 10^6
    //0 ≤ A[i] ≤ 10^6
    internal static class _08_StockBuyAndSell
    {
        // Time Complexity: O(N)
        // Auxiliary Space: O(N)
        internal static void Way01()
        {
            int[] array = new int[] { 100, 180, 60, 310, 40, 535, 695 };
            var profits = Way01FindProfits(array, array.Length);
            Console.WriteLine(profits.Count > 0 ? "Have profits" : "No Profits");
        }

        private static List<List<int>> Way01FindProfits(int[] array, int length)
        {
            List<List<int>> returnValue = new List<List<int>>();

            int buyingIndex = -1, sellingIndex = -1;
            for (int i = 1; i < length; i++)
            {
                if (buyingIndex == -1 && array[i] > array[i - 1])
                    buyingIndex = i - 1;
                if (buyingIndex != -1 && array[i] < array[i - 1])
                    sellingIndex = i - 1;

                if (buyingIndex != -1 && sellingIndex != -1)
                {
                    returnValue.Add(new List<int> { buyingIndex, sellingIndex });
                    buyingIndex = -1; sellingIndex = -1;
                }
            }

            if (buyingIndex != -1)
                returnValue.Add(new List<int> { buyingIndex, length - 1 });

            return returnValue;
        }

        // Time Complexity: O(N)
        // Auxiliary Space: O(N)
        internal static void Way02()
        {
            int[] array = new int[] { 100, 180, 60, 310, 40, 535, 695 };
            var profits = Way02FindProfits(array, array.Length);
            Console.WriteLine(profits.Count > 0 ? "Have profits" : "No Profits");
        }

        private static List<List<int>> Way02FindProfits(int[] array, int length)
        {
            List<List<int>> returnValue = new List<List<int>>();

            for (int i = 1; i < length; i++)
            {
                if (array[i] > array[i - 1])
                    returnValue.Add(new List<int> { i - 1, i });
            }

            return returnValue;
        }
    }
}
