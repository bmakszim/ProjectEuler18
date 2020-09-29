using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    public class Algorithm
    {
        private int highest = 0;
        private List<int> order = null;
        private int called = 0;

        public int Run(List<List<int>> input, out List<int> order)
        {
            Sum(0, 0, input, 0, new List<int>());
            order = this.order;
            Console.WriteLine("Called: {0} times", called);
            return highest;
        }

        private void Sum(int row, int index, List<List<int>> tree, int sum, List<int> order)
        {
            called++;
            order.Add(index);
            sum += tree[row][index];

            if (row + 1 < tree.Count)
            {
                if (sum + (tree.Count - row - 1) * 99 > highest)
                {
                    Sum(row + 1, index, tree, sum, new List<int>(order));
                    Sum(row + 1, index + 1, tree, sum, new List<int>(order));
                }
            }
            else
            {
                if (sum > highest)
                {
                    highest = sum;
                    this.order = order;
                }
            }
        }
    }
}
