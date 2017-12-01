using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution
{
    class Program
    {
        static Program()
        {
            queenPositions = new List<coordinate>();
            takenPositions = new bool[8,8];
        }

        private static bool[,] takenPositions { get; set; }
        private static List<coordinate> queenPositions { get; set; }

        static void Main(string[] args)
        {
            // step: add a queen
            var queen = new coordinate() { x = 0, y = 0 };
            queenPositions.Add(queen);
            
            // step: remove positions
            removePositions(queen, takenPositions);

            // find open position
            findFalseSpot(takenPositions);

            // add a queen to it

            // run above again
            Console.WriteLine(takenPositions[0,0]);
        }

        private static coordinate findFalseSpot(bool[,] board)
        {
            // while spot not found
            while (true)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    // check every row
                }
            }
        }

        private static void removePositions(coordinate queen, bool[,] board)
        {
            // remove x and y rows
            for (int i = 0; i < board.Length; i++)
            {
                board[queen.x, i] = true;
                board[i, queen.y] = true;

                board[(queen.x + i) % board.Length, (queen.y + i) % board.Length] = true;

                var diagY = (queen.y - i) % board.Length;
                if (diagY < 0) diagY += board.Length;
                board[(queen.x + i) % board.Length, diagY] = true;

            }

        }

        private void removeIfLegal(int x, int y, bool[,] board)
        {
            if (isLegal(x, y, board))
            {
                board[x,y] = false;
            }
        }

        private bool isLegal(int x, int y, bool[,] board)
        {
            return (
                x < board.Length && 
                y < board.Length && 
                x >= 0 && 
                y >= 0);
        }
    }

    class coordinate
    {
        public int x;
        public int y;
    }


}
