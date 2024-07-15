using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.day5
{
    internal class TextElement:Html 
    {
        public int Fontsize { set; get; }
        public string Fontcolor { set; get; }

        public TextElement(string value , string Fontcolor ,string type="text") 
        {
            this.value = value;
            this.Fontsize = Fontsize;
            this.Fontcolor = Fontcolor;

        }

        public override void render() {
            Console.WriteLine($"<{type} fontsize='{Fontsize}' color={Fontcolor}>{value} </text>");
        }
    }
}
