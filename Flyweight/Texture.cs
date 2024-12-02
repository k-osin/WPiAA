using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Flyweight
{
    public class Texture : ITexture
    {
        private string _fileName;

        public Texture(string fileName)
        {
            _fileName = fileName;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            Console.WriteLine($"Wczytywanie tekstury: {_fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Wyświetlanie tekstury: {_fileName}");
        }
    }
}
