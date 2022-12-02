using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (1 != 0)
            {
                Console.WriteLine("Введите стороны треугольника");

                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введен недопустимый символ.");
                    continue;
                }
            }

            double hypotenuse = Math.Pow(a, 2) + Math.Pow(b, 2);
            if(hypotenuse == (Math.Pow(c, 2)))
            {
                Console.WriteLine("Треугольник являтся прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }
        }
    }
}
