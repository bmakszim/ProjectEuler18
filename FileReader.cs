using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    public class FileReader
    {
        public List<List<int>> Read(string filePath)
        {
            var result = new List<List<int>>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var numbers = line.Split(' ').Select(n => Convert.ToInt32(n)).ToList();
                    result.Add(numbers);
                }
            }

            return result;
        }
    }
}
