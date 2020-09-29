using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    public class AlgorithmQuick
    {
        public int Run(List<List<int>> input, out List<int> order)
        {
            order = new List<int> { 0 };
            var pyramid = input.Select(inner => new List<int>(inner)).ToList();

            int row = pyramid.Count - 2;

            while (row > -1)
            {
                for (int index = 0; index < pyramid[row].Count; index++)
                {
                    //if (input[row + 1][index] > input[row + 1][index + 1])
                    //{

                    //}
                    //else
                    //{

                    //}
                    pyramid[row][index] += Math.Max(pyramid[row + 1][index], pyramid[row + 1][index + 1]);
                }
                row--;
            }

            return pyramid[0][0];
        }
    }
}
