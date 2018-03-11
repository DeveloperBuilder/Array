using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop.ForLoops();
            string[] names = { "Tom", "Judith", "Max", "Marlon", "Mike" };
            Console.WriteLine($"{names[1]} is second and {names[4]} is fourth");
            names[1] = "Jolin";
            names[2] = "Helen";
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }

    class ForLoop
    {
        public static void ForLoops()
        {
        int[] numb = { 1, 3, 6, 9, 24, 33, 41, 56 };
        for(int sum = 0; sum < numb.Length; sum++)
            {
                Console.WriteLine(numb[sum]);
            }
            Array.Clear(numb, 1, 5);
            Console.WriteLine(numb[sum]);
        }
    }
}
