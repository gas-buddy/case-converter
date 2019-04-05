using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    public class Converter
    {
        public static string ToPascal(string orig)
        {
            var snake = new Snake();
            return snake.ToPascal(orig);
        }
    }
}
