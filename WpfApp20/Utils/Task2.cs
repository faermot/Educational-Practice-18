using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task2
    {
        public static string Calculate(string line)
        {
            string state = "a"; 

            foreach (char symbol in line)
            {
                switch (state)
                {
                    case "a":
                        if (symbol == '0')
                            state = "a"; 
                        else if (symbol == '1' || symbol == '2')
                            state = "b"; 
                        else
                            return "Строка содержит недопустимый символ";
                        break;

                    case "b":
                        if (symbol == '1' || symbol == '2')
                            state = "b"; 
                        else
                            return "Строка содержит недопустимый символ";
                        break;
                }
            }

            return state == "b" ? "Строка принята" : "Строка отклонена";
        }
    }
}
