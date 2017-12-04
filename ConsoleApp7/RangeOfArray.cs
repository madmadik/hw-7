using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class RangeOfArray
    {
        int[] mas;
        static int size;
        public void get()
        {
            int.TryParse(Console.ReadLine(), out size);
            mas = new int[size];
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public int this[int index] 
        {
            get
            {
                return mas[index - Min];
            }
            set
            {
                int u = index - Min;
                mas[u] = value;
            }
        }



    }
}
