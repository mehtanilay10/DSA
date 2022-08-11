using Helper;

namespace DSA.Course._01_Mathematics.Problems
{
    // 3. Quadratic Equation Roots
    //Basic Accuracy: 33.8% Submissions: 100k+ Points: 1
    //Given a quadratic equation in the form ax2 + bx + c.Find its roots.
    //Note: Return the maximum root followed by the minimum root.

    //Example 1:
    //----------------------
    //Input:
    //a = 1
    //b = -2
    //c = 1
    //Output: 1 1
    //Explanation:
    //Roots of equation x2-2x+1 are 1 and 1.

    //Example 2:
    //----------------------
    //Input:
    //a = 1
    //b = -7
    //c = 12
    //Output: 4 3
    //Explanation: Roots of equation
    //x2 - 7x + 12 are 4 and 3.

    //Your Task:
    //You don't need to read input or print anything. Your task is to complete the function quadraticRoots() which takes a, b, c as input parameters and returns a list of two integers containing the floor value of its roots in decreasing order. If roots are imaginary, the returning list should contain only 1 integer ie -1. Always return the greatest integer smaller than or equal to the result.
    //Note: If roots are imaginary, the generated output will display "Imaginary".

    //Expected Time Complexity: O(1)
    //Expected Auxiliary Space : O(1)

    //Constraints:
    //-103 <= a,b,c <= 103
    internal static class _03_QuadraticEquationRoot
    {
        internal static void Way01()
        {
            int a = ConsoleHelper.ReadInteger("A");
            int b = ConsoleHelper.ReadInteger("B");
            int c = ConsoleHelper.ReadInteger("C");

            List<int> roots = new List<int>();
            double determinant = (b * b) - (4 * a * c);

            if (determinant < 0)
                roots.Add(-1);
            else
            {
                double d = Math.Sqrt(determinant);
                double root1 = Math.Floor((-b + d) / (2 * a));
                double root2 = Math.Floor((-b - d) / (2 * a));

                roots.Add((int)Math.Max(root1, root2));
                roots.Add((int)Math.Min(root1, root2));
            }

            Console.WriteLine($"Roots: {string.Join(", ", roots)}");
        }
    }
}
