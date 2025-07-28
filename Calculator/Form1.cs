using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //DialogResult Confirmation =MessageBox.Show("Are you sure you wanna exit?","Attention",MessageBoxButtons.OKCancel);
            //if (Confirmation == DialogResult.OK)
                Application.Exit();
            //else
              //  return;
        }        
        Point point;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X-point.X;
                this.Top += e.Y-point.Y;
            }

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
            new Point(25, 40), // Начальная точка градиента
            new Point(309, 359), // Конечная точка градиента
            Color.FromArgb(135, 125, 199), // Начальный цвет
            Color.FromArgb(91, 45, 99)); // Конечный цвет

            e.Graphics.FillRectangle(gradientBrush, 0, 0, 309, 359); // Заливка прямоугольника
            Graphics g = e.Graphics;//для возможности рисовать
            Point[] points =new Point[]{
                new Point(309, 0),
                new Point(237, 0),
                new Point(309, 63),
                };
            Brush brush = new SolidBrush(Color.FromArgb(93, 49, 104));//.FromArgb(60, 60, 134)
            g.FillPolygon(brush, points);
        }
        bool IsActiveOperation = false;//будет показывать когда нажата какая-нибудь операция (5+ -> 5- а не 5+-)
        bool ExpressionIsFormed = false;//будет показывать готово ли выражение для вычисления(5+3   15-6)

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0")
                return;
            else if(IsActiveOperation == false)
            {
                OutputLabel.Text += '0';
            }
            else
            {
                OutputLabel.Text += "0";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "1";
            
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "1";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "1";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "2";
                
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "2";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "2";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0"&&IsActiveOperation==false)
            {
                OutputLabel.Text = "3";
                
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "3";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "3";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "4";
              
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "4";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "4";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "5";
                
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "5";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "5";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "6";
              
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "6";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "6";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "7";
             
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "7";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "7";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "8";
                
            }
            else if (IsActiveOperation == false)
            {
                OutputLabel.Text += "8";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += '8';
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text == "0" && IsActiveOperation == false)
            {
                OutputLabel.Text = "9";
                
              
            }else if(IsActiveOperation == false)
            {
                OutputLabel.Text += "9";
            }
            else //if (IsActiveOperation)
            {
                OutputLabel.Text += "9";
                IsActiveOperation = false;
                ExpressionIsFormed = true;
            }

        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "0";
            HaveComaInFirstOperand = false;
            HaveComaInSecondOperand = false;
            IsActiveOperation = false;
            ExpressionIsFormed = false;
        }
       
        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            if (!IsActiveOperation && ExpressionIsFormed == false)//если false
            {
                OutputLabel.Text += "+";
                IsActiveOperation = true;
            }
            else if (IsActiveOperation==true &&ExpressionIsFormed==false)//стадия 5+ -> 5-
            {
                char[] str = OutputLabel.Text.ToCharArray();//заменили одну букву(строки в c# неизменяемые поэтому обходные пути)
                str[str.Length-1] = '+';
                OutputLabel.Text = new string(str);

            }
            else//ситуация 5+13
            {
                //посчитать выражение и поставить знак 
            }


        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            if (!IsActiveOperation && ExpressionIsFormed == false)//если false
            {
                OutputLabel.Text += "-";
                IsActiveOperation = true;
            }
            else if (IsActiveOperation == true && ExpressionIsFormed == false)//стадия 5+ -> 5-
            {
                char[] str = OutputLabel.Text.ToCharArray();//заменили одну букву(строки в c# неизменяемые поэтому обходные пути)
                str[str.Length - 1] = '-';
                OutputLabel.Text = new string(str);

            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            if (!IsActiveOperation && ExpressionIsFormed == false)//если false
            {
                OutputLabel.Text += "x";

                IsActiveOperation = true;
            }
            else if (IsActiveOperation == true && ExpressionIsFormed == false)//стадия 5+ -> 5-
            {
                char[] str = OutputLabel.Text.ToCharArray();//заменили одну букву(строки в c# неизменяемые поэтому обходные пути)
                str[str.Length - 1] = 'x';
                OutputLabel.Text = new string(str);

            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            if (!IsActiveOperation && ExpressionIsFormed == false)//если false
            {
                OutputLabel.Text += "/";
                IsActiveOperation = true;
            }
            else if (IsActiveOperation == true && ExpressionIsFormed == false)//стадия 5+ -> 5-
            {
                char[] str = OutputLabel.Text.ToCharArray();//заменили одну букву(строки в c# неизменяемые поэтому обходные пути)
                str[str.Length - 1] = '/';
                OutputLabel.Text = new string(str);
            }
        }

         double a=0;//первое слагаемое
         double b=0;//второе слагаемое
         char operation=' ';//какая оперпция       

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Functions funcs = new Functions();//класс где храним все функции и сути мат.операций
                funcs.separator(OutputLabel.Text, ref a, ref b, ref operation);
                //MessageBox.Show($"a={a}\t b={b}\t oper={operation}");
                MiniOutputLabel.Text = OutputLabel.Text;
                OutputLabel.Text = funcs.calculate(a, b, operation).ToString();
                IsActiveOperation = false;
                ExpressionIsFormed = false;
                HaveComaInFirstOperand = false;
                HaveComaInSecondOperand = false;
            }
            catch
            {
                MessageBox.Show("синтаксическая ошибка!");
            }
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            if (!IsActiveOperation && ExpressionIsFormed == false)//если false
            {
                OutputLabel.Text += "^";
                IsActiveOperation = true;
            }
            else if (IsActiveOperation == true && ExpressionIsFormed == false)//стадия 5+ -> 5-
            {
                char[] str = OutputLabel.Text.ToCharArray();//заменили одну букву(строки в c# неизменяемые поэтому обходные пути)
                str[str.Length - 1] = '^';
                OutputLabel.Text = new string(str);
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;
            char first_char = OutputLabel.Text[0];
            //первый операнд
            if (first_char == '-' && !ExpressionIsFormed)
            {
                string a = OutputLabel.Text.Substring(1, OutputLabel.Text.Length - 1);
                OutputLabel.Text = a;

            }
            else if (first_char == '0'&&OutputLabel.Text.Length==1 && !ExpressionIsFormed)//если только 0 в строке
                return;
            else if (!first_char.Equals('-') && !ExpressionIsFormed)//не равен - и мы не на стадии операции 
            {
                string a = "-" + OutputLabel.Text;
                OutputLabel.Text = a;

            }
            //второй операнд
            else if (ExpressionIsFormed && OutputLabel.Text[OutputLabel.Text.Length-1]!=')' )
            {
                //когда уже ExpressionIsFormed==true(выражение сформировано) и до этого не было минуса
                Functions functions = new Functions();
                functions.separator(OutputLabel.Text, ref a, ref b, ref operation);
                string b_str = b.ToString();
                int IndexOf_b= OutputLabel.Text.IndexOf(b_str,(a.ToString().Length));//нашли позицию где начинается второ операнд
                //MessageBox.Show($"index_of_b={IndexOf_b}");
                OutputLabel.Text = OutputLabel.Text.Insert(IndexOf_b, "(-");
                OutputLabel.Text +=')';
            }
            else if(ExpressionIsFormed && OutputLabel.Text[OutputLabel.Text.Length - 1] == ')')
            {  //когда нужно превратить отрицательный операнд в положительный
                int IndexOf_OpenBracket=OutputLabel.Text.IndexOf('(');//нашли индекс где нах. символ (
                string a = OutputLabel.Text.Substring(0, IndexOf_OpenBracket);//от нуля до знака операции(включительно)
                string b = OutputLabel.Text.Substring(IndexOf_OpenBracket + 2, OutputLabel.Text.Length - a.Length - 3);
                //всё остальное без скобок и без значка минуса
                OutputLabel.Text = a + b;
            }
        }

        private void CButton_Click(object sender, EventArgs e)//стирать запятые у 1го и у 2го операнд
        {
            char[] operations = new[] { '+', '-', 'x', '/', '^', 'l', 'o', 'g' };
            if (OutputLabel.Text.Length > 2)
            {
                if (operations.Contains(OutputLabel.Text[OutputLabel.Text.Length - 2]) && OutputLabel.Text[OutputLabel.Text.Length - 3] != '(')
                {//если хотим удалить цифру и перед ней стоит знак операции
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    IsActiveOperation = true;
                    ExpressionIsFormed = false;
                }
                else if (OutputLabel.Text[OutputLabel.Text.Length - 1] == '-' && OutputLabel.Text[OutputLabel.Text.Length - 2] == '(')
                {//если хотим удалить знак отрицательного числа а не операции вычитания
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                }
                else if (operations.Contains(OutputLabel.Text[OutputLabel.Text.Length - 1]))
                {//если хотим удалить знак операции
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    IsActiveOperation = false;
                    ExpressionIsFormed = false;
                }
                else if (OutputLabel.Text[OutputLabel.Text.Length - 1] == ',' && ExpressionIsFormed)
                {//стираем запятую у второго операнда
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    HaveComaInSecondOperand = false;
                }
                else if (OutputLabel.Text[OutputLabel.Text.Length - 1] == ',' && !ExpressionIsFormed)
                {//стираем запятую у второго операнда
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    HaveComaInFirstOperand = false;
                }
                else
                {
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                }
            }
            else
            {
                //когда всего 2 символа
                if (OutputLabel.Text.Length == 1)
                    OutputLabel.Text = "0";
                else if (operations.Contains(OutputLabel.Text[OutputLabel.Text.Length - 1]))
                {//если хотим удалить знак операции
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    IsActiveOperation = false;
                    ExpressionIsFormed = false;
                }
                else if (OutputLabel.Text[OutputLabel.Text.Length - 1] == ',' && !ExpressionIsFormed)
                {//стираем запятую у второго операнда
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                    HaveComaInFirstOperand = false;
                }
                else
                {
                    OutputLabel.Text = OutputLabel.Text.Substring(0, OutputLabel.Text.Length - 1);
                }
            }
        }

        bool HaveComaInFirstOperand = false;
            bool HaveComaInSecondOperand = false;
        private void ComaButton_Click(object sender, EventArgs e)
        {
            if (OutputLabel.Text.Length == 1 && OutputLabel.Text[0] == '-')
                return;            
            else if (!HaveComaInFirstOperand && !ExpressionIsFormed && !IsActiveOperation)
            {//если хотим добавить запятую в первом операнде
                OutputLabel.Text += ',';
                HaveComaInFirstOperand = true;
            }
            else if (ExpressionIsFormed &&!HaveComaInSecondOperand)
            {//если хотим добавить запятую во втором операнде
                OutputLabel.Text += ',';
                HaveComaInSecondOperand = true;
            }     
        }
    }
}
