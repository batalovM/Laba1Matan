namespace ConsoleApp1;

public class Secant
{
    private float _x0;
    private float _x1;
    private readonly float _eps;
    private readonly Func<float, float> _fx;
    private readonly Func<float, float> _dfx;
    public Secant(float x0, float x1, float eps, Func<float, float> fx, Func<float, float> dfx)
    {
        _x0 = x0;
        _x1 = x1;
        _eps = eps;
        _fx = fx;
        _dfx = dfx;
    }
    
    public void SecantSolution()
    {
        var x2 = _x1 - _fx(_x1) * (_x1 - _x0) / (_fx(_x1) - _fx(_x0));
        while (Math.Abs(x2 - _x1) < _eps)
        {
            _x0 = _x1;
            _x1 = x2;
        }
        Console.WriteLine(x2);
    }
}