using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.day5
{
    internal class H2 : TextElement
    {
        public H2(string value, string Fontcolor) : base( value, Fontcolor)
        {
            type = "H2";
            Fontsize = 16;
        }

    }
}
