using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1yp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите сторону треугольника");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("Сторона треугольника не может иметь отрицательное или нулевое значение!");
                }
                else
                {
                    Console.Write("Радиус описанной окружности равен: ");
                    Console.WriteLine(Math.Round(a / Math.Sqrt(3),3));
                }
            }
            catch
                { Console.WriteLine("Ошибка. Данные введены некорректно!"); }
           
        }
    }
}
