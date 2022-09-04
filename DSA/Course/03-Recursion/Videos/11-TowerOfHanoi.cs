using Helper;

namespace DSA.Course._03_Recursion.Videos
{
    internal static class _11_TowerOfHanoi
    {
        // T(n) = 2T(n-1) + 1
        internal static void Way01()
        {
            int number = ConsoleHelper.ReadInteger();
            Way01MoveDisc(number, 'A', 'B', 'C');
        }

        private static void Way01MoveDisc(int number, char sourceTower, char auxiliarySpaceTower, char destinationTower)
        {
            if (number == 1)
            {
                Console.WriteLine($"Move {number} from {sourceTower} to {destinationTower}");
                return;
            }

            Way01MoveDisc(number - 1, sourceTower, destinationTower, auxiliarySpaceTower);
            Console.WriteLine($"Move {number} from {sourceTower} to {destinationTower}");
            Way01MoveDisc(number - 1, auxiliarySpaceTower, sourceTower, destinationTower);
        }

        // Also need to calculat steps to be taken
        internal static void Way02()
        {
            int number = ConsoleHelper.ReadInteger();
            int counts = Way02MoveDisc(number, 'A', 'B', 'C');
            Console.WriteLine($"Steps to be taken: {counts}");
        }

        private static int Way02MoveDisc(int number, char sourceTower, char auxiliarySpaceTower, char destinationTower)
        {
            if (number == 1)
            {
                Console.WriteLine($"Move {number} from {sourceTower} to {destinationTower}");
                return 1;
            }

            int counts = 1; // Set 1, as this method it self going to make 1 change, appart from those 2 recurscive call
            counts += Way02MoveDisc(number - 1, sourceTower, destinationTower, auxiliarySpaceTower);
            Console.WriteLine($"Move {number} from {sourceTower} to {destinationTower}");
            counts += Way02MoveDisc(number - 1, auxiliarySpaceTower, sourceTower, destinationTower);

            return counts;
        }
    }
}
