using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Класс под названием Полином
    /// </summary>
    class Polynomial
    {
        double[] coefficients;
        /// <summary>
        /// Конструктор с заданием коэффициентов
        /// </summary>
        public Polynomial(params double[] coef)
        {
            coefficients = coef;
        }

        /// <summary>
        /// Метод для вычесления значени полинома для заданной величины x
        /// </summary>
        public double Calculate(double x)
        {
            double result = 0;
            for (int i = 0; i < coefficients.Length; i++)
            {
                result += coefficients[i] * Math.Pow(x, i);
            }

            return result;
        }
    }
}
