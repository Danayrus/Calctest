using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int resultAdd, resultSub;
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultAdd = num1 + num2;
            resultSub = num1 - num2;
            Console.WriteLine($"{num1} + {num2} = {resultAdd}");
            Console.WriteLine($"{num1} - {num2} = {resultSub}");


            Console.ReadKey();

        }
    }
}
