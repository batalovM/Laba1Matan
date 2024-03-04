namespace ConsoleApp1;

public class SimpleIterationsCalculate
{
    public void Calculate_defaultValue(float eps, Func<float, float> f1, Func<float,float> df1)
    {
        var simpleIteration1 = new SimpleIterations(-4.0f,-3.0f, eps,f1, df1);
        var simpleIteration2 = new SimpleIterations(-1.5f, -1.0f, eps, f1, df1);
        var simpleIteration3 = new SimpleIterations(0.5f, 0f, eps, f1, df1);
        var simpleIteration4 = new SimpleIterations(4.0f, 5.0f, eps, f1, df1);
        
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2, simpleIteration3, simpleIteration4 };
        Console.WriteLine("Посчитано методом Простых итераций");
        foreach (var root in list2)
        {
            root.SolveNonlinearEquation(root._x0, root._x1);
        }
    }

    public void Calculate_ExperimentalValue(Func<float, float> f1, Func<float, float> df1)
    {
        var simpleIteration1 = new SimpleIterations(-4.0f,-3.0f, 0.000001f,f1, df1);
        var simpleIteration2 = new SimpleIterations(-1.5f,-1.0f, 0.000001f, f1, df1);
        var simpleIteration3 = new SimpleIterations(0.5f, 0f,0.000001f, f1, df1);
        var simpleIteration4 = new SimpleIterations(4.0f, 5.0f,0.000001f, f1, df1);
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2, simpleIteration3, simpleIteration4 };
        Console.WriteLine("Посчитано методом Простых итераций c экспериментальной точностью");
        foreach (var root in list2)
        {
            root.SolveNonlinearEquation(root._x0, root._x1);
        }
    }

    public void Calculate_AnotherFuncDefaultValue(float eps, Func<float, float> f2, Func<float, float> df2)
    {
        var simpleIteration1 = new SimpleIterations(1f, 2f, eps,f2, df2);
        var simpleIteration2 = new SimpleIterations(101f, 103f, eps, f2, df2);
        
        
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2};
        Console.WriteLine("Посчитано методом Простых итераций (другая функция)");
        foreach (var root in list2)
        {
            root.SolveNonlinearEquation(root._x0, root._x1);
        }
    }

    public void Calculate_AnotherFuncExpValue(Func<float, float> f2, Func<float, float> df2)
    {
        var simpleIteration1 = new SimpleIterations(1f, 2f, 0.00001f,f2, df2);
        var simpleIteration2 = new SimpleIterations(101f, 2f, 0.00001f, f2, df2);
        
        
        var list2 = new List<SimpleIterations>{ simpleIteration1, simpleIteration2};
        Console.WriteLine("Посчитано методом Простых итераций (другая функция) c экспериментальной точностью");
        foreach (var root in list2)
        {
            root.SolveNonlinearEquation(root._x0, root._x1);
        }
    }

    public void CalculateAll(float eps, Func<float, float> f1, Func<float,float> df1, Func<float, float> f2, Func<float, float> df2 )
    {
        Calculate_defaultValue(eps, f1, df1 );
        Calculate_ExperimentalValue(f1, df1);
        Calculate_AnotherFuncDefaultValue(eps, f2, df2);
        Calculate_AnotherFuncExpValue(f2, df2);
    }
}