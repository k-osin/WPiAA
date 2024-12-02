using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Composite
{
    public class MenuCategory : IMenu
    {
        private string _name;
        private List<IMenu> _menuComponents;

        public MenuCategory(string name)
        {
            _name = name;
            _menuComponents = new List<IMenu>();
        }

        public void Add(IMenu component)
        {
            _menuComponents.Add(component);
        }

        public void Remove(IMenu component)
        {
            _menuComponents.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth * 2) + _name);

            foreach (var component in _menuComponents)
            {
                component.Display(depth + 1);
            }
        }
    }
}
