using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheUniqueNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new[] { -2, 2, 2, 2 }));
            Console.ReadKey();
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }

        public static int GetUnique2(IEnumerable<int> numbers)
        {
            var a = numbers.Distinct().ToArray();
            int n = 0;
            int m = 0;
            foreach (var item in numbers)
            {
                if (a[0] == item)
                {
                    n++;
                }

                if (a[1] == item)
                {
                    m++;
                }
            }
            return n < m ? a[0] : a[1];
        }
    }
}
