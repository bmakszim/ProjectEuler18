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

        public int Run(List<List<int>> input, out List<int> order)
        {
            Sum(0, 0, input, 0, new List<int>());
            order = this.order;
            return highest;
        }

        private void Sum(int row, int index, List<List<int>> tree, int sum, List<int> order)
        {
            order.Add(index);
            sum += tree[row][index];

            if (row + 1 < tree.Count)
            {
                Sum(row + 1, index, tree, sum, new List<int>(order));
                Sum(row + 1, index + 1, tree, sum, new List<int>(order));
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



    public static class Extensions
    {
        //public static int LeftChild(this int)
        //{

        //}
    }
}
