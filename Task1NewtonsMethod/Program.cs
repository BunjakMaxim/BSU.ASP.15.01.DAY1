using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1NewtonsMethod
{
    class Program
    {
        private double value;
        private int n;
        private double r;

        private static int ShowMenu()
        {
            Console.WriteLine("*********************Меню**********************");
            Console.WriteLine("*  0 - Выход                                  *");
            Console.WriteLine("*  другое число - Вычислить корень n стрепени *");
            Console.WriteLine("***********************************************");
            return int.Parse(Console.ReadLine());
        }

        private double NjutanMetod()
        {
            double x, x1 = 1;
            do
            {
                x = x1;
                x1 = 1.0 / n * ((n - 1) * x + value / Math.Pow(x, n - 1));
            } while (Math.Abs(x - x1) > r);
            return x;
        }

        private void SetValue()
        {
            Console.Write("\n Введите число ");
            value = double.Parse(Console.ReadLine());
            Console.Write(" Введите степель ");
            n = int.Parse(Console.ReadLine());
            Console.Write(" Введите точность ");
            r = double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            while (ShowMenu() > 0)
            {
                Program pr = new Program();
                pr.SetValue();

                Console.WriteLine("Корень {0}-ой степени из {1} равен {2}", pr.n, pr.value, pr.NjutanMetod());
                Console.WriteLine("Результат функции Math.Pow {0}\n", Math.Pow(pr.value, 1d / pr.n));
            }
        }
    }
}
