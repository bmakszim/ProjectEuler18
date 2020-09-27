using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new FileReader();
            var pyramid = reader.Read();
            var alg = new Algorithm();
            Console.WriteLine(alg.Run(pyramid, out List<int> order));
            var painter = new Painter();
            painter.Paint(pyramid, order);
            Console.Read();
        }
    }
}
