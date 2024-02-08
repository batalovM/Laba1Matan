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
        var newton1 = new Newton(-4.0f, eps);
        var newton2 = new Newton(-1.5f, eps);
        var newton3 = new Newton(0.5f, eps);
        var newton4 = new Newton(4.0f, eps);
        var simpleIteration1 = new SimpleIterations(-4.0f, eps);
        var simpleIteration2 = new SimpleIterations(-1.5f, eps);
        var simpleIteration3 = new SimpleIterations(0.5f, eps);
        var simpleIteration4 = new SimpleIterations(4.0f, eps);
        var list1 = new List<Newton>{ newton1, newton2, newton3, newton4 };
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2, simpleIteration3, simpleIteration4 };
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
        
    }
}



















