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
            Polynomial num = new Polynomial(2, 3, 1);// Пример числителя: 2 + 3x + x^2
            Polynomial den = new Polynomial(1, 0, -1);// Пример знаменателя: 1 - x^2
            AlgebraiсExpression expression = new AlgebraiсExpression(num, den);
            double result = expression.Evaluate(2);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
