using System.Runtime.CompilerServices;

namespace RayTracing;

public class vec3
{
    private double []e = new double[3];

    public vec3()
    {
        e = new[] { 0.0, 0.0, 0.0 };
    }

    public vec3(double e0, double e1, double e2)
    {
        e = new[] { e0, e1, e2 };
    }

    public double x => e[0];
    public double y => e[1];
    public double z => e[2];

    
    
    public static vec3 operator -(vec3 v)
    {
        return new vec3(-v.e[0], -v.e[1], -v.e[2]);
    }

    public double this[int i]
    {
        get { return e[i]; }
        set { e[i] = value; }
    }

    public static vec3 operator +(vec3 a, vec3 b)
    {
        return new vec3(
            a.e[0] + b.e[0],
            a.e[1] + b.e[1],
            a.e[2] + b.e[2]
        );
    }
    
    public static vec3 operator *(vec3 a, double b)
    {
        return new vec3(
            a.e[0] * b,
            a.e[1] * b,
            a.e[2] * b
        );
    }

    public static vec3 operator /(vec3 a, double b)
    {
        return new vec3(
            a.e[0] / b,
            a.e[1] / b,
            a.e[2] / b
        );
    }
    double length()  {
        return Math.Sqrt(length_squared());
    }

    public double length_squared()  {
        return e[0]*e[0] + e[1]*e[1] + e[2]*e[2];
    }


}