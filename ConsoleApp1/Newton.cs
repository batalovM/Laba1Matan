namespace ConsoleApp1;
using MathNet.Numerics;
public class Newton
{
    private float _x0;
    private readonly float _eps;
    private readonly Func<float, float> _fx;
    private readonly Func<float, float> _dfx;
    public Newton(float x0, float eps, Func<float, float> fx, Func<float, float> dfx)
    {
        _x0 = x0;
        _eps = eps;
        _fx = fx;
        _dfx = dfx;
    }
    public void NewtonSolution()//метод ньютона
    {
        var x1 = _x0 - _fx(_x0) / _dfx(_x0);
        while (Math.Abs(x1 - _x0) > _eps)
        {
            _x0 = x1;
            x1 = _x0 - _fx(_x0) / _dfx(_x0);
            Console.WriteLine($"Корень: {x1}");
        }
    }
    
}