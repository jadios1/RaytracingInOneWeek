namespace RayTracing;
using point3 = vec3;

public class ray
{
    public ray(){}
    
    private readonly point3 orig;
    private readonly vec3 dir;
    
    public ray(point3 origin,vec3 direction)
    {
        orig = origin;
        dir = direction;
    }

    public point3 Origin => orig;
    public vec3 Direction => dir;
    
    public point3 at(double t)
    {
        return orig + t * dir;
    }
}