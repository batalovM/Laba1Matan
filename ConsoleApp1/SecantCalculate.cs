namespace ConsoleApp1;

public class SecantCalculate
{
    public void Calculate_defaultValue(float eps, Func<float, float> f1)
    {
        var secant1 = new Secant(-4.0f, -3.0f, eps, f1);
        var secant2 = new Secant(-1.5f, -1.0f, eps, f1);
        var secant3 = new Secant(0.5f, 0f, eps, f1);
        var secant4 = new Secant(4.0f, 5.0f, eps, f1);
        
        
        var list1 = new List<Secant> { secant1, secant2, secant3, secant4 };
        Console.WriteLine("Посчитано методом секущих");
        foreach (var root in list1)
        {
            root.SecantSolution();
        }
    }

    public void Calculate_ExperimentalValue(Func<float, float> f1)
    {
        var secant1 = new Secant(-4.0f, -3.0f, 0.00001f, f1);
        var secant2 = new Secant(-1.5f, -1.0f, 0.00001f, f1);
        var secant3 = new Secant(0.5f, 0f, 0.00001f, f1);
        var secant4 = new Secant(4.0f, 5.0f, 0.00001f, f1);
        
        
        var list1 = new List<Secant> { secant1, secant2, secant3, secant4 };
        Console.WriteLine("Посчитано методом секущих c экспериментальными значениями");
        foreach (var root in list1)
        {
            root.SecantSolution();
        }
    }

    public void Calculate_AnotherFuncDefaultValue(float eps, Func<float, float> f2)
    {
        var secant1 = new Secant(-0.5f, 0.5f, eps, f2);
        var secant2 = new Secant(99.5f, 100.5f, eps, f2);
        
        var list1 = new List<Secant> { secant1, secant2,};
        Console.WriteLine("Посчитано методом секущих (другая функция)");
        foreach (var root in list1)
        {
            root.SecantSolution();
        }
    }

    public void Calculate_AnotherFuncExpValue(Func<float, float> f2)
    {
        var secant1 = new Secant(-0.5f, 0.5f, 0.0000001f, f2);
        var secant2 = new Secant(99.5f, 100.5f, 0.0000001f, f2);
        
        var list1 = new List<Secant> { secant1, secant2};
        Console.WriteLine("Посчитано методом секущих (другая функция) c экспериментальными значениями");
        foreach (var root in list1)
        {
            root.SecantSolution();
        }
    }

    public void CalculateAll(float eps, Func<float, float> f1, Func<float, float> f2 )
    {
        Calculate_defaultValue(eps, f1);
        Calculate_ExperimentalValue(f1);
        Calculate_AnotherFuncDefaultValue(eps, f2);
        Calculate_AnotherFuncExpValue(f2);
    }
}