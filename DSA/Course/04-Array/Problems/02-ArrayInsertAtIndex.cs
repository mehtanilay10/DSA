using Helper;

namespace DSA.Course._04_Array.Problems
{
    //Array insert at index
    //Basic     Accuracy: 44.81%     Submissions: 65K+   Points: 1

    //Insertion is a basic but frequently used operation.Arrays in most languages cannnot be dynamically shrinked or expanded. Here, we will work with such arrays and try to insert an element at some index. You are given an array arr(0-based index). The size of the array is given by sizeOfArray.You need to insert an element at given index and print the modified array.

    //Example 1:
    //--------------------
    //Input:
    // sizeOfArray = 6
    // arr[] = { 1, 2, 3, 4, 5}
    // index = 5, element = 90
    //Output: 1 2 3 4 5 90
    //Explanation: 90 is inserted at index 5(0-based indexing). After inserting, array elements are like 1, 2, 3, 4, 5, 90.

    //Example 2:
    //--------------------
    //Input:
    //sizeOfArray = 6
    //arr[] = {1, 2, 3, 4, 5}
    //index = 2, element = 90
    //Output: 1 2 90 3 4 5
    //Explanation: 90 is inserted at index 2(0 - based indexing).After inserting, array elements are like  1, 2, 90, 3, 4, 5.

    //Your Task:
    //You don't need to read input or print anything.. The input is already taken care of by the driver code. You only need to complete the function insertAtIndex() that takes arr, sizeOfArray, index, element as input and modifies the array arr as per requirements. The printing is done by driver code.

    //Expected Time Complexity: O(N).
    //Expected Auxiliary Space: O(1).

    //Constraints:
    //2 <= sizeOfArray <= 10000
    //0 <= element, arri <= 106
    //0 <= index <= sizeOfArray - 1
    internal static class _02_ArrayInsertAtIndex
    {
        // Time complexity - O(n)
        // Auxiliary Space - O(1)
        internal static void Way01()
        {
            int sizeOfArray = 6;
            int[] array = new int[sizeOfArray];

            for (int i = 0; i <= 5; i++)
                array[i] = (i + 1);

            int newElement = 90;
            int index = 2;

            Way01InsertAtIndex(array, sizeOfArray, index, newElement);
            ConsoleHelper.PrintArray(array);
        }

        private static void Way01InsertAtIndex(int[] array, int sizeOfArray, int index, int newElement)
        {
            for (int i = sizeOfArray - 1; i < index; i--)
                array[i] = array[i - 1];

            array[index] = newElement;
        }
    }
}
