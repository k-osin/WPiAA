using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA.Adapter
{
    public class ClubValidator
    {
        public bool ValidateEntry(Adult person)
        {
            return person.IsAdult();
        }
    }
}