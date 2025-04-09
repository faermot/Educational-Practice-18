using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task1
    {
        public static string Calculate(string line)
        {
            string state = "a"; // начальное состояние

            foreach (char symbol in line)
            {
                switch (state)
                {
                    case "a":
                        if (symbol == '0' || symbol == '1')
                            state = "b";
                        else if (symbol == '2')
                            state = "a";
                        else
                            return "Строка содержит недопустимый символ";
                        break;

                    case "b":
                        if (symbol == '0' || symbol == '1')
                            state = "b";
                        else if (symbol == '2')
                            state = "a";
                        else
                            return "Строка содержит недопустимый символ";
                        break;
                }
            }

            return state == "b" ? "Строка принята" : "Строка отклонена";
        }
    }
}
 