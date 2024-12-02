using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Flyweight
{
    public class GameObject
    {
        private ITexture _texture;

        public GameObject(ITexture texture)
        {
            _texture = texture;
        }

        public void Display()
        {
            _texture.Display(); 
        }
    }
}
