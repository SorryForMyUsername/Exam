using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleFunc triangleSquareFunc = S;

            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Вычислить площадь треугольника\n" +
                    "2. Выход\n");

                int choice = Console.ReadKey(true).KeyChar - '0';

                switch (choice)
                {
                    case 1: IOTriangleSquare(triangleSquareFunc); break;
                    case 2: return;
                }
                Console.WriteLine();
            }
        }

        delegate double TriangleFunc(double a, double b, double c);

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        static void IOTriangleSquare(TriangleFunc squareFunc)
        {
            while (true)
            {
                double a = InputDouble("Первая сторона: ");
                double b = InputDouble("Вторая сторона: ");
                double c = InputDouble("Третья сторона: ");

                if(IsTriangle(a, b, c))
                {
                    Console.WriteLine($"\nПлощадь треугольника: {squareFunc.Invoke(a, b, c):f2}");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Треугольника с такими сторонами не существует!");
                Console.ResetColor();
            }
        }

        public static double InputDouble(string message, double min = double.MinValue)
        {
            Console.Write(message);
            double input;
            while (!double.TryParse(Console.ReadLine(), out input) || input <= min)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный ввод!");
                Console.ResetColor();
                Console.Write(message);
            }
            return input;
        }
    }
}
