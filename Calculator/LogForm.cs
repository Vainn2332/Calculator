using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        Point point;
        private void LogForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);

        }

        private void LogForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void LogcheckBox_MouseClick(object sender, MouseEventArgs e)
        {            
            BasetextBox.Text = "10";
            if (LncheckBox.Checked)
            {
                LncheckBox.Checked = false;
                LogcheckBox.Checked = true;
            }
            else if (!LogcheckBox.Checked && !LncheckBox.Checked)
                        BasetextBox.Text = "";
        }

        private void LncheckBox_MouseClick(object sender, MouseEventArgs e)
        {           
            BasetextBox.Text = "e";
            if (LogcheckBox.Checked)
            {
                LogcheckBox.Checked = false;
                LncheckBox.Checked = true;
            }
            else if(!LogcheckBox.Checked&&!LncheckBox.Checked)
                BasetextBox.Text = "";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {

                double a = double.Parse(ValuetextBox.Text);
                if(a<=0)
                    MessageBox.Show("Значение логарифма не может быть отрицательным или равным нулю!");
                double b;
                if (BasetextBox.Text == "e")
                    b = Math.E;
                else
                    b = double.Parse(BasetextBox.Text);
                if (b <= 0)
                    MessageBox.Show("Основание логарифма не может быть отрицательным или равным нулю!");
                Outputlabel.Text=Math.Log(a,b).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка полей ввода!");
            }
        }

       
    }
}
