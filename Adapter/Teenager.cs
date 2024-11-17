using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Adapter
{
    public class Teenager : Adult
    {
        public Teenager(string name, int age) : base(name, age)
        {
        
        }

        public override bool IsAdult()
        {
            return false;
        }
    }
}
