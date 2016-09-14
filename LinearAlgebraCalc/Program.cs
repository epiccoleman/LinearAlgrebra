using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LinearAlgebra;

namespace LinearAlgebraCalc
{
    class Program
    {
        public static int Main(string[] args)
        {
            System.Console.WriteLine("hello");
            

            Vector vec1 = new Vector(8.218, -9.341);
            Vector vec2 = new Vector(-1.129, 2.111);

            System.Console.WriteLine(vec1 + vec2);
            Console.ReadLine();
            return 0;
        }
    }
}
