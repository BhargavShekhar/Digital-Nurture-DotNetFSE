namespace ProxyPatternExample
{
    public class ProxyImage : IImage
    {
        private RealImage? _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
            _realImage = null;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            else
            {
                System.Console.WriteLine($"Displaying cached image: {_fileName}");
            }
            _realImage.Display();
        }
    }
}
