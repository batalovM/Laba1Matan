namespace ConsoleApp1;

public class SimpleIterations
{
    public float _x0;
    public float _x1;
    private readonly float _eps;
    private readonly Func<float, float> _fx;
    private readonly Func<float, float> _dfx;
    public SimpleIterations(float x0, float x1, float eps, Func<float, float> fx, Func<float, float> dfx)
    {
        _x0 = x0;
        _x1 = x1;
        _eps = eps;
        _fx = fx;
        _dfx = dfx;
    }
    
    public void SolveNonlinearEquation(float leftBorder,float rightBorder)
    {
        var x = FindStartBorder(leftBorder, rightBorder);
        var lam= 1/_dfx(x);
        float oldX;
        do
        {
            oldX = x;
            x = oldX - _fx(oldX) * lam;
            Console.WriteLine(x);
        } while (Math.Abs(oldX - x) > _eps);
    }

    private float FindStartBorder(float left, float right)
    {
        return Math.Abs(_dfx(left))> Math.Abs(_dfx(right))? left:right;
    }
}