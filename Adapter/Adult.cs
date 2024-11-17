using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Adapter
{
    public class Adult
    {
        public string Name { get; }
        public int Age { get; }

        public Adult(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual bool IsAdult()
        {
            return Age >= 18;
        }
    }
}