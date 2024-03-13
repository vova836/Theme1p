using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Класс под названием Алгебраическое выражение
    /// </summary>
    class AlgebraiсExpression
    {
        Polynomial numerator;
        Polynomial denominator;

        /// <summary>
        /// Конструктор с заданием числителя и знаменателя
        /// </summary>
        public AlgebraiсExpression( Polynomial num, Polynomial den)
        {
            numerator = num;
            denominator = den;
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public AlgebraiсExpression()
        {
            
        }

        /// <summary>
        /// Метод для вычесления значения выражения для заданной величины x
        /// </summary>
        public double Evaluate(double x)
        {
            if (denominator.Calculate(x) == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль");
                return 0;
            }

            return numerator.Calculate(x) / denominator.Calculate(x);
        }
    }
}
