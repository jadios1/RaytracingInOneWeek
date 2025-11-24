namespace RayTracing
{
    public sealed class Program
    {
        static void Main()
        {
            int image_width = 256;
            int image_height = 256;
            Console.WriteLine($"P3\n {image_width} {image_height} \n256");

            for (int j = 0; j < image_height; j++)
            {
                for (int i = 0; i < image_width; i++)
                {
                    var r = (double)i / (image_width - 1);
                    var g = (double)j / (image_height - 1);
                    var b = 0.0;

                    int ir = (int)(255.999 * r);
                    int ig = (int)(255.999 * g);
                    int ib = (int)(255.999 * b);

                    Console.WriteLine($"{ir} {ig} {ib}");
                    
                }
            }
        }
    }
}