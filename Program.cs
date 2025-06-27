using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __24
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleFunc triangleSquareFunc = S;
        }

        delegate double TriangleFunc(double a, double b, double c);

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static bool IsTriangle(double a, double b, double c)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        static void IOTriangleSquare()
        {

        }

        public static int Int(string message, int min = Int32.MinValue)
        {
            Console.Write(message);
            int price;
            while (!int.TryParse(Console.ReadLine(), out price) || price < min)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный ввод!");
                Console.ResetColor();
                Console.Write(message);
            }
            return price;
        }
    }
}
