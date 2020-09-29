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
            var pyramid = input.Select(inner => new List<int>(inner)).ToList();
            var path = new List<List<int>>();

            for (int i = 0; i < input.Count; i++)
            {
                path.Add(new List<int>());
            }

            int row = pyramid.Count - 2;

            while (row > -1)
            {
                for (int index = 0; index < pyramid[row].Count; index++)
                {
                    if (pyramid[row + 1][index] > pyramid[row + 1][index + 1])
                    {
                        pyramid[row][index] += pyramid[row + 1][index];
                        path[row].Add(index);
                    }
                    else
                    {
                        pyramid[row][index] += pyramid[row + 1][index + 1];
                        path[row].Add(index + 1);
                    }
                }
                row--;
            }

            order = CreateOrder(path);
            return pyramid[0][0];
        }


        private List<int> CreateOrder(List<List<int>> path)
        {
            int index = 0;
            var order = new List<int> { index };
            for (int row = 0; row < path.Count - 1; row++)
            {
                index = path[row][index];
                order.Add(index);
            }
            return order;
        }
    }
}
