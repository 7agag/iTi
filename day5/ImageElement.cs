using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.day5
{
    internal class ImageElement : Html
    {
        public string src {  get; set; }

        public ImageElement(string src)
        {
            this.src = src;
            type = "img";
        }
        public override void render()
        {
            Console.WriteLine($"<{type}  src=\'{src}' > </img> " );
            

        }
    }
}
