namespace ConsoleApp1;

public class NewtonCalculate
{
    public void Calculate_defaultValue(float eps, Func<float, float> f1, Func<float,float> df1)
    {
        var newton1 = new Newton(-4.0f, eps, f1, df1);
        var newton2 = new Newton(-1.5f, eps, f1, df1);
        var newton3 = new Newton(0.5f, eps, f1, df1);
        var newton4 = new Newton(4.0f, eps, f1, df1);
        
        var list1 = new List<Newton>{ newton1, newton2, newton3, newton4 };
        
        Console.WriteLine("Посчитано методом Ньютона");
        foreach (var root in list1)
        {
            root.NewtonSolution();
        }
    }

    public void Calculate_ExperimentalValue(Func<float, float> f1, Func<float, float> df1)
    {
        var newton5 = new Newton(-4.0f, 0.01f, f1, df1);
        var newton6 = new Newton(-1.5f, 0.01f, f1, df1);
        var newton7 = new Newton(0.5f, 0.01f, f1, df1);
        var newton8 = new Newton(4.0f, 0.01f, f1, df1);
        
        var list2 = new List<Newton> { newton5, newton6, newton7, newton8};
        
        Console.WriteLine("Посчитано методом Ньютона c экспериментальной точностью");
        foreach (var root in list2)
        {
            root.NewtonSolution();
        }
    }

    public void Calculate_AnotherFuncDefaultValue(float eps, Func<float, float> f2, Func<float,float> df2)
    {
        var newton9 = new Newton(1f, eps, f2, df2);
        var newton10 = new Newton(101f, eps, f2, df2);
        
        var list3 = new List<Newton> { newton9, newton10};
        Console.WriteLine("Посчитано методом Ньютона (другая функция)");
        foreach (var root in list3)
        {
            root.NewtonSolution();
        }
    }
    public void Calculate_AnotherFuncExpValue(Func<float, float> f2, Func<float,float> df2)
    {
        var newton11 = new Newton(1f, 0.000001f , f2, df2);
        var newton12 = new Newton(101f, 0.00001f, f2, df2);
        
        var list4 = new List<Newton> { newton11, newton12};
        Console.WriteLine("Посчитано методом Ньютона (другая функция) с экспериментальной точностью");
        
        foreach (var root in list4)
        {
            root.NewtonSolution();
        }
    }

    public void CalculateAll(float eps,Func<float, float> f1, Func<float, float> df1 , Func<float, float> f2, Func<float,float> df2)
    {
        Calculate_defaultValue(eps, f1, df1);
        Calculate_ExperimentalValue(f1, df1);
        Calculate_AnotherFuncDefaultValue(eps, f2, df2);
        Calculate_AnotherFuncExpValue(f2,df2);
    }
}