using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    public class Painter
    {
        public void Paint(List<List<int>> input, List<int> order)
        {
            for (int row = 0; row < input.Count; row++)
            {
                var stringBuilder = new StringBuilder();

                for (int s = 1; s < (input.Count - row); s++)
                {
                    stringBuilder.Append("  ");
                }

                Console.Write(stringBuilder.ToString());

                for (int i = 0; i < input[row].Count; i++)
                {
                    if (i == order[row])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (input[row][i] < 10)
                    {
                        Console.Write("0");
                    }

                    Console.Write("{0}  ", input[row][i]);

                    if (i == order[row])
                    {
                        Console.ResetColor();
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
