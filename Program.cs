using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BasicEquationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation1 = Console.ReadLine();
            string equation2 = Console.ReadLine();

            EquationCalculator calc = new EquationCalculator();
            Point intersection = calc.CalculateIntersection(equation1, equation2);

            Console.WriteLine(intersection.ToString());

            Console.ReadKey(true);
        }
    }
}
