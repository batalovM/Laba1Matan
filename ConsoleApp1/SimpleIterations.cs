namespace ConsoleApp1;

public class SimpleIterations
{
    private float _x0;
    private readonly float _eps;
    private readonly Func<float, float> _fx;
    private readonly Func<float, float> _dfx;
    public SimpleIterations(float x0, float eps, Func<float, float> fx, Func<float, float> dfx)
    {
        _x0 = x0;
        _eps = eps;
        _fx = fx;
        _dfx = dfx;
    }
    public void SolveNonlinearEquation()//метод простых операций
    {
        var x1 = _x0 + 2 * _eps;
        while (Math.Abs(x1 - _x0) > _eps)
        {
            _x0 = x1;
            x1 = _x0 - _fx(_x0) / _dfx(_x0);
            Console.WriteLine($"Корень: {x1}");
        }
    }
}
