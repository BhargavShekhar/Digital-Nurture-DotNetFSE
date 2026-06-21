using System;
using System.Threading;

namespace ProxyPatternExample
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromServer();
        }

        private void LoadImageFromServer()
        {
            Console.WriteLine($"Loading image from remote server: {_fileName}");
            Thread.Sleep(2000); // Simulate network delay
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }
}
