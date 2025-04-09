using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task10
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double t = vars["t"];
            double y = vars["y"];
            return (2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831));
        }
    }
}
