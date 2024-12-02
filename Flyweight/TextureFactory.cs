using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Flyweight
{
    public class TextureFactory
    {
        private Dictionary<string, ITexture> _textures = new Dictionary<string, ITexture>();

        public ITexture GetTexture(string fileName)
        {
            if (!_textures.ContainsKey(fileName))
            {
                _textures[fileName] = new Texture(fileName);  
            }

            return _textures[fileName];  
        }
    }
}
