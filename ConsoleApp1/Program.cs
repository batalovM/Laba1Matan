

namespace ConsoleApp1;
/*
f(x) = -x^4 + 15x^2 + 12x - 10
g(x) = 100x^2 - 10000x - 3
 *
 * 
 */
public abstract class Solution
{
    public static void Main(string[] args)
    {
        const float eps = 0.001f;
        // const float eps1 = 0.000001f;
        // метод простых операций крайнее значение эпсилоне == 0.0000001f
        //
        Func<float, float> f1 = x0 => (float)(-Math.Pow(x0, 4) + 15 * Math.Pow(x0, 2) + 12 * x0 - 10);
        Func<float, float> f2 = x0 => (float)(100 * Math.Pow(x0, 2) - 10000 * x0 - 3);
        var df1 = Derivative(f1);
        var dxf2 = Derivative(f2);

        var newtonCalc = new NewtonCalculate();
        newtonCalc.CalculateAll(eps, f1, df1 , f2, dxf2);

        var simpleIterationCalc = new SimpleIterationsCalculate();
        simpleIterationCalc.CalculateAll(eps, f1 , df1, f2, dxf2);

        var secantCalc = new SecantCalculate();
        secantCalc.CalculateAll(eps, f1, f2);
    }
    static Func<float, float> Derivative(Func<float, float> f)
    {
        return x =>
        {
            var h = 0.0001f; // Шаг для численного дифференцирования
            return (f(x + h) - f(x)) / h;
        };
    }
}



















