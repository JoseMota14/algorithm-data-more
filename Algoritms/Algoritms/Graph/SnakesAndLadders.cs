using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Graph
{
    public class SnakesAndLadders
    {
        public static string InvokeFunction()
        {
            List<List<int>> ladders = new List<List<int>>()
            {
                new List<int> {2, 15},
                new List<int> {5, 25},
                new List<int> {10, 29}
            };

            List<List<int>> snakes = new List<List<int>>()
            {
                new List<int> {17, 4},
                new List<int> {28, 14},
                new List<int> {35, 6}
            };




            return SAndL(ladders, snakes);
        }

        public static string SAndL(List<List<int>> ladders, List<List<int>> snakes)
        {
            Queue<(int position, int roll)> queue = new();
            HashSet<int> seen = new HashSet<int>();

            Dictionary<int, int> board = new Dictionary<int, int>();
            foreach (var ladder in ladders)
            {
                board[ladder[0]] = ladder[1];  // Ladder: moves up
            }
            foreach (var snake in snakes)
            {
                board[snake[0]] = snake[1];  // Snake: moves down
            }

            queue.Enqueue((1, 0));
            seen.Add(1);

            while (queue.Count > 0)
            {
                var (pos, rolls) = queue.Dequeue();
                if (pos == 100)
                {
                    return rolls.ToString();
                }


                for(int i = 1; i  <=  6; i++)
                {
                    int nextPos = pos + i;
                    if (nextPos > 100) continue;

                    if (board.ContainsKey(nextPos))
                    {
                        nextPos = board[nextPos];
                    }


                    if (!seen.Contains(nextPos))
                    {
                        seen.Add(nextPos);
                        queue.Enqueue((nextPos, rolls + 1));
                    }
                }
            }

            return "-1";
        }
        

    }
}
