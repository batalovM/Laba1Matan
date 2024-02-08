namespace ConsoleApp1;

public class Newton
{
    private float _x0;
    private readonly float _eps;
    public Newton(float x0, float eps)
    {
        _x0 = x0;
        _eps = eps;
    }
    private static float Fx(float x0)//функция
    {
        return (float)(-Math.Pow(x0, 4) + 15 * Math.Pow(x0, 2) + 12 * x0 - 10);   
    }
    private static float Dfx(float x0)//производная
    {
        return (float)(-4 * Math.Pow(x0, 3) + 30 * x0 + 12);
    }
    public void NewtonSolution()//метод ньютона
    {
        var x1 = _x0 - Fx(_x0) / Dfx(_x0);
        while (Math.Abs(x1 - _x0) > _eps)
        {
            _x0 = x1;
            x1 = _x0 - Fx(_x0) / Dfx(_x0);
            Console.WriteLine($"Корень: {x1}");
        }
    }
}