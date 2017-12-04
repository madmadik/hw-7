using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray maas = new RangeOfArray();
            maas.get();
            maas.Min = int.Parse(Console.ReadLine());
            maas.Max = int.Parse(Console.ReadLine());
            maas[-5] = 5;
            maas[-4] = 4;
            maas[-3] = 6;
            maas[-2] = 7;

            Console.WriteLine(maas[-5]);
            Console.ReadLine();

        }
    }
}
