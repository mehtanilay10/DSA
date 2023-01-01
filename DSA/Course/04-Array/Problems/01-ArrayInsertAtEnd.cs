using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Array insert at end
    //BasicAccuracy: 87.65%     Submissions: 36K+   Points: 1

    //Insertion is a basic but frequently used operation.Arrays in most languages can not be dynamically shrinked or expanded.Here, we will work with such arrays and try to insert an element at the end of the array. You are given an array arr. The size of the array is given by sizeOfArray.You need to insert an element at the end. Array already have the sizeofarray -1 elements.

    //Example 1:
    //--------------------
    //Input:
    // sizeOfArray = 6
    // arr[] = { 1, 2, 3, 4, 5}
    // element = 90
    //Output: 1 2 3 4 5 90
    //Explanation: After inserting 90 at the end, we have array elements as 1 2 3 4 5 90.

    //Example 2:
    //--------------------
    //Input:
    // sizeOfArray = 4
    // arr[] = {1, 2, 3}
    // element = 50
    //Output: 1 2 3 50
    //Explanation: After inserting 50 at the end, we have array elements as 1 2 3 50.

    //Your Task:
    //You don't need to read input or print anything. You only need to complete the function insertAtEnd() that takes arr, sizeOfArray, element as input and modifies arr as per requirements. The driver code takes care of the printing.

    //Expected Time Complexity: O(1).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //2 <= sizeOfArray <= 1000
    //0 <= element, arri <= 106
    internal static class _01_ArrayInsertAtEnd
    {
        // Time Complexity: O(1)
        // Auxiliary Space: O(1)
        internal static void Way01()
        {
            int sizeOfArray = 6;
            int[] array = new int[sizeOfArray];

            for (int i = 0; i <= 5; i++)
                array[i] = (i + 1);

            int newElement = 90;

            Way01InsertAtEnd(array, sizeOfArray, newElement);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01InsertAtEnd(int[] array, int sizeOfArray, int newElement)
        {
            // Here we just need to set at last index, no validation required as per problem
            array[sizeOfArray - 1] = newElement;
        }
    }
}
