using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] number = new int[] { 69, 62, 69,  61,44, 67, 88, 44, 2019 };
            //sum from 44 to 2019
            var sum = number.Sum(x => x++);
            Console.WriteLine($"Sum :{sum}");


            var min = number.Min();
            Console.WriteLine($"Min : {min}");

            var max = number.Max();
            Console.WriteLine($"Max : {max}");


            var duplicatest = number.Distinct();
            foreach (var item in duplicatest)
            {
                Console.Write(item);
            }
        }
    }
}
