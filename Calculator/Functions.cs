using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Functions//класс где храним все функции и сути мат.операций
    {       
       public void separator(string str, ref double a, ref double b, ref char operation)
       {
            int PositionOfOperation;

            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    double iterator = double.Parse(str[i].ToString());//пробегаемся пока не найдем знак операции
                }
                catch
                {
                    if (i == 0)
                        continue;
                    PositionOfOperation = i;
                    string a_str = str.Substring(0, PositionOfOperation);
                    string b_str = str.Substring(PositionOfOperation + 1, str.Length - 1 - PositionOfOperation);
                    a = double.Parse(a_str);
                    b = double.Parse(b_str);
                    operation = str[i];
                    break;
                }
            }
       }
        public double calculate(double a, double b,char operation)
        {
            switch (operation)
            {
                case '+':                    
                    return a + b;
                case '-':
                    return a - b;
                case 'x':
                    return a * b;
                case '/':
                    return a / b;
                case '^':
                    return Math.Pow(a, b);
                case 'l':
                    return Math.Log(a,b);
                default:
                    return 0;

            }

        }
    }
}
