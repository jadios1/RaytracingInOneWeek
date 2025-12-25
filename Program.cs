using System.Reflection.Metadata.Ecma335;

namespace RayTracing
{
    using point3 = vec3;
    using color = vec3;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            
            
            var aspectRatio = 16.0 / 9.0;
            int imageWidth = 700;

            int imageHeight = (int)(imageWidth / aspectRatio);
            imageHeight = (imageHeight < 1) ? 1 : imageHeight;

            var viewportHeight = 2.0;
            var viewportWidth = viewportHeight * (double)((imageWidth)/imageHeight);

            
            
            
            
            
            
            Console.WriteLine($"P3\n {imageWidth} {imageHeight} \n256");
    
            for (int j = 0; j < imageHeight; j++)
            {
                Console.Error.WriteLine($"Scanlines remaining: {imageHeight - j}");

                for (int i = 0; i < imageWidth; i++)
                {
                    var pixel_color = new color((double)i/(imageWidth-1),(double)j/(imageHeight-1),0);
                    WriteColor(pixel_color);
                }
            }
            

        }
        
        
        public static void WriteColor(color pixelColor)
        {
            double r = pixelColor.x;
            double g = pixelColor.y;
            double b = pixelColor.z;
            int rByte = (int)(255.999 * r);
            int gByte = (int)(255.999 * g);
            int bByte = (int)(255.999 * b);
            
            Console.WriteLine($"{rByte} {gByte} {bByte}");
        }

    }
}