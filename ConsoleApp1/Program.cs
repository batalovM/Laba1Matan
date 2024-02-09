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
        
        Func<float, float> f1 = x0 => (float)(-Math.Pow(x0, 4) + 15 * Math.Pow(x0, 2) + 12 * x0 - 10);
        Func<float, float> df1 = x0 => (float)(-4 * Math.Pow(x0, 3) + 30 * x0 + 12);
        Func<float, float> f2 = x0 => (float)(100 * Math.Pow(x0, 2) - 10000 * x0 - 3);
        Func<float, float> df2 = x0 => 200 * x0 - 10000;
        const float eps = 0.001f;
        var newton1 = new Newton(-4.0f, eps, f1, df1);
        var newton2 = new Newton(-1.5f, eps, f1, df1);
        var newton3 = new Newton(0.5f, eps, f1, df1);
        var newton4 = new Newton(4.0f, eps, f1, df1);
        var simpleIteration1 = new SimpleIterations(-4.0f, eps,f1, df1);
        var simpleIteration2 = new SimpleIterations(-1.5f, eps, f1, df1);
        var simpleIteration3 = new SimpleIterations(0.5f, eps, f1, df1);
        var simpleIteration4 = new SimpleIterations(4.0f, eps, f1, df1);
        var secant1 = new Secant(-4.0f, -3.0f, eps, f1, df1);
        var secant2 = new Secant(-1.5f, -1.0f, eps, f1, df1);
        var secant3 = new Secant(0.5f, 0f, eps, f1, df1);
        var secant4 = new Secant(4.0f, 5.0f, eps, f1, df1);
        var list1 = new List<Newton>{ newton1, newton2, newton3, newton4 };
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2, simpleIteration3, simpleIteration4 };
        var list3 = new List<Secant> { secant1, secant2, secant3, secant4 };
        Console.WriteLine("Посчитано методом Ньютона");
        foreach (var root in list1)
        {
            root.NewtonSolution();
        }
        Console.WriteLine("Посчитано методом Простых операций");
        foreach (var root in list2)
        {
            root.SolveNonlinearEquation();
        }
        Console.WriteLine("Посчитано методом секущей");
        foreach (var root in list3)
        {
            root.SecantSolution();
        }
        
    }
}



















