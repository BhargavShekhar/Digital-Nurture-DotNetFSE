using System;

namespace ProxyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ProxyImage
            IImage proxyImage = new ProxyImage("photo.jpg");

            // First call - loads the image from remote server
            Console.WriteLine("First call to Display():");
            proxyImage.Display();

            Console.WriteLine();

            // Second call - uses the cached image
            Console.WriteLine("Second call to Display():");
            proxyImage.Display();
        }
    }
}
