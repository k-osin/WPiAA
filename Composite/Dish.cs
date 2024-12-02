using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Composite
{
    public class Dish : IMenu
    {
        private string _name;
        private decimal _price;

        public Dish(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth * 2) + $"{_name} - {_price:C}");
        }
    }
}
