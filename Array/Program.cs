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
}
