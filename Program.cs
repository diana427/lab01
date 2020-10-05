using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            string s;
            Console.WriteLine("Введите x");

            s = Console.ReadLine();
            x = Convert.ToSingle(s);

            double p = Math.Sin(x/3) + (Math.Pow(2, x) / Math.Cos(x));
            
            Console.WriteLine("1) p = " +p);

            p = (Math.Cos(x) / Math.Sin(x)) - Math.Acos(Math.Pow(x, 3));

            Console.WriteLine("2) p = " + p);

            p = Math.Pow(x, x + 3) + Math.Atan(x);
            Console.WriteLine("3) p = " + p);

            p = 1 + Math.Pow((1 + Math.Log10(x)), 1 / 3);
            Console.WriteLine("4) p = " + p);

            p = Math.Pow((Math.Cos(x - Math.PI)) / (Math.Sin(x - Math.PI)), -1);
            Console.WriteLine("5) p = " + p); 

            p = Math.Sinh(Math.Pow(x, 0.5));
            Console.WriteLine("6) p = " + p);

            p = Math.Pow(x, 2) + 2*x - Math.Tanh(x/2);
            Console.WriteLine("7) p = " + p);

            p = Math.Log(Math.Log10(Math.Pow(Math.E, x))) - 0.35;
            Console.WriteLine("8) p = " + p);

            p = Math.Pow(x/2, 1.72) - Math.Tan(Math.PI - 1);
            Console.WriteLine("9) p = " + p);

            p = Math.Abs(Math.Log(Math.Atan(x)));
            Console.WriteLine("10) p = " + p);
            Console.ReadKey();
        }
    }
}

