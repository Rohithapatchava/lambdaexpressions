using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaexpressions
{
    class Program

    { 

        private static void LambdaExpression()
        {
            Func<int, int> Cube = a => a * a * a;
            Console.WriteLine("Enter any number");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }
        private static void LambdaLinqordr()
        {
            int[] nos = { 45, 150, 15, 30, 65 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sort));
        }
         public static void Lambdalinq()
        {
            int[] numbers = { 2,3,4,5,6 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
        }
        public static void Lamdaexp()
        {
            int[] scores =
                {78,90,85};
            int exelent = scores.Where(n => n >= 85).Count();
            int aPlus = scores.Where(x => x >= 75).Count()-exelent;
            Console.WriteLine(exelent);
            Console.WriteLine(aPlus);
        }
        public delegate void Mydelg(string s);

        static void Main(string[] args)

        {
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine( Calc(12, 10.0));
            //LambdaExpression();
            // LambdaLinqordr();
            //Lambdalinq();
            Lamdaexp();
            Mydelg delgt = a => Console.WriteLine(a);
            delgt("hai");
           
        }
    }
}
