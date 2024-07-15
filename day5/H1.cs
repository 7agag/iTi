using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.day5
{
    internal class H1 : TextElement
    {
        public H1(string value,string Fontcolor) : base( value, Fontcolor)
        {
            type = "H1";
            Fontsize = 32;
        }
    }
}
