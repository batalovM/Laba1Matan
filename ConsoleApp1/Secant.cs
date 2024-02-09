namespace ConsoleApp1;

public class Secant
{
    private float _x0;
    private float _x1;
    private readonly float _eps;

    public Secant(float x0, float x1, float eps)
    {
        _x0 = x0;
        _x1 = x1;
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

    public void secant()
    {
        var x2 = _x1 - Fx(_x1) * (_x1 - _x0) / (Fx(_x1) - Fx(_x0));
            while (Math.Abs(x2 - _x1) < _eps)
            {
                _x0 = _x1;
                _x1 = x2;
            }
            Console.WriteLine(x2);
    }
}