using System;

class AlgebraicExpression
{
    private Polynomial numerator;
    private Polynomial denominator;

    // Конструктор с заданием числителя и знаменателя
    public AlgebraicExpression(Polynomial num, Polynomial den)
    {
        numerator = num;
        denominator = den;
    }

    // Конструктор без параметров
    public AlgebraicExpression()
    {
        numerator = new Polynomial();
        denominator = new Polynomial();
    }

    // Метод для вычисления значения выражения для заданной величины x
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

class Polynomial
{
    private double[] coefficients;

    // Конструктор с заданием коэффициентов
    public Polynomial(params double[] coef)
    {
        coefficients = coef;
    }

    // Метод для вычисления значения полинома для заданной величины x
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

class Program
{
    static void Main()
    {
        Polynomial num = new Polynomial(2, 3, 1); // Пример числителя: 2 + 3x + x^2
        Polynomial den = new Polynomial(1, 0, -1); // Пример знаменателя: 1 - x^2

        AlgebraicExpression expression = new AlgebraicExpression(num, den);
        double result = expression.Evaluate(2); // Вычисление значения выражения для x = 2
        Console.WriteLine("Результат: " + result);
    }
}
