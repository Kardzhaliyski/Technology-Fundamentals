using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapitalist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Remove(3);
            numbers.Remove(3);
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
