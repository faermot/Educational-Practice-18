using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task6
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double i = vars["i"];
            double y = vars["y"];
            return (0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(2, i));
        }
    }
}
