using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    class Program
    {
        private const string Numbers = "../../Numbers.txt";
        private const string p067_triangle = "../../p067_triangle.txt";

        static void Main(string[] args)
        {
            var reader = new FileReader();
            var alg = new AlgorithmQuick();

            var pyramid = reader.Read(p067_triangle);
            Console.WriteLine(alg.Run(pyramid, out List<int> order));

            var painter = new Painter();
            painter.Paint(pyramid, order);

            Console.Read();
        }
    }
}
