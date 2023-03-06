using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSolution
{
    public partial class Form1 : Form
    {
        string[] text =
        {
            "Нахождение корней квадратного уравнения",
            "Нахождение корней линейнего уравнения"
        };

        string[] textLabel =
        {
            "ax² + bx + c = 0",
            "bx + c = 0"
        };

        int flag = 0;

        ErrorProvider errorProvider;

        char sep = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];

        public Form1()
        {
            InitializeComponent();

            this.Text = text[flag];

            this.labelTop.Text = textLabel[flag];

            this.textboxA.Select(); // выделенный текстбокс А
            this.CenterToScreen(); // приложение в центре экрана

            errorProvider = new ErrorProvider();
            errorProvider.BlinkRate = 500;
            errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            MaximizeBox = false;

            textboxA.MaxLength = 20;
            textboxB.MaxLength = 20;
            textboxC.MaxLength = 20;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            if (rbt.Checked)
            {
                if (rbt == radioButton1)
                {
                    flag = 1;
                    //textboxA.Text = "";
                    //textboxA.Enabled = false;

                    this.labelA.Visible = false;
                    this.textboxA.Visible = false;

                    this.textboxB.Select();
                }
                else
                {
                    flag = 0;
                    //textboxA.Enabled = true;

                    this.labelA.Visible = true;
                    this.textboxA.Visible = true;

                    this.textboxA.Select();
                }

                this.Text = text[flag];

                this.labelTop.Text = textLabel[flag];

                errorProvider.SetError(textboxA, "");
                errorProvider.SetError(textboxB, "");
                errorProvider.SetError(textboxC, "");
            }
        }

        private void textboxA_Validating(object sender, CancelEventArgs e)
        {
            if ((TextBox)sender == this.textboxA)
            {
                try
                {
                    if (Double.Parse(this.textboxA.Text) == 0)
                    {
                        errorProvider.SetError(this.textboxA, "Cannot be 0!");
                    }
                    else
                    {
                        errorProvider.SetError(this.textboxA, "");
                    }
                }
                catch (Exception exc)
                {
                    errorProvider.SetError(this.textboxA, exc.Message);
                }

            }
            else
            {
                try
                {
                    double d = Double.Parse(((TextBox)sender).Text);
                    errorProvider.SetError((TextBox)sender, "");
                }
                catch (Exception exc)
                {
                    errorProvider.SetError((TextBox)sender, exc.Message);
                }
            }
        }

        private void textboxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == '.' || ch == ',')
                e.KeyChar = ch = sep;

            // контроль правильности вводимых данных
            if (!Char.IsDigit(ch) && !(ch == 8) &&
                (ch != sep || ((TextBox)sender).Text.IndexOf(sep) != -1 || ((TextBox)sender).Text.Length == 0) &&
                (ch != '-' || ((TextBox)sender).Text.Length > 0)
                )
            {
                e.Handled = true;
            }

            // при нажатии Esc текущее поле очищается
            if(ch == 27)
            {
                ((TextBox)sender).Text = "";
            }

            // при нажатии Enter переход к следующему полю
            else if(ch == 13)
            {
                if((TextBox)sender == this.textboxA)
                {
                    this.textboxB.Focus();
                }
                else if ((TextBox)sender == this.textboxB)
                {
                    this.textboxC.Focus();
                }
                else if ((TextBox)sender == this.textboxC)
                {
                    // кое что сюда добавим

                    if (buttonSum.Enabled)
                    {
                        buttonSum.Focus();
                        InvokeOnClick(buttonSum, EventArgs.Empty);
                    }
                }
            }
        }

        private void textboxA_KeyUp(object sender, KeyEventArgs e)
        {
            if(flag == 0)
            {
                buttonSum.Enabled = (
                    textboxA.Text != "0" &&
                    textboxA.Text != "" && textboxA.Text != "-" &&
                    textboxA.Text != sep.ToString() &&

                    textboxB.Text != "" && textboxB.Text != "-" &&
                    textboxB.Text != sep.ToString() &&

                    textboxC.Text != "" && textboxC.Text != "-" &&
                    textboxC.Text != sep.ToString())
                    ? true : false;
            }
            else
            {
                buttonSum.Enabled = (
                    textboxB.Text != "" && textboxB.Text != "-" &&
                    textboxB.Text != sep.ToString() &&

                    textboxC.Text != "" && textboxC.Text != "-" &&
                    textboxC.Text != sep.ToString())
                    ? true : false;
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (buttonSum.Enabled)
            {
                if (flag == 00)
                {
                    double a, b, c;
                    a = Double.Parse(textboxA.Text);
                    b = Double.Parse(textboxB.Text);
                    c = Double.Parse(textboxC.Text);

                    double x1, x2;

                    int res = GetSolution(out x1, out x2, a, b, c);

                    switch (res)
                    {
                        case 2:
                            labelBot.Text = "x1 = " + x1 + ", x2 = " + x2;
                            //labelBot.Text = String.Format("x1 = {0}, x2 = {0}", x1, x2);
                            break;
                        case 1:
                            labelBot.Text = "x1 = x2 = " + x1;
                            break;
                        case 0:
                            labelBot.Text = "Нет корней уравнения!";
                            break;
                        case -1:
                            labelBot.Text = "Error  a==0!!!";
                            break;
                    }

                }
                else
                {
                    double b, c;
                    b = Double.Parse(textboxB.Text);
                    c = Double.Parse(textboxC.Text);

                    double x;
                    int res = GetLinear(out x, b, c);

                    switch (res)
                    {
                        case 1:
                            labelBot.Text = "x = " + x;
                            break;
                        case 0:
                            labelBot.Text = "Корень уравнения — любое число";
                            break;
                        case -1:
                            labelBot.Text = "Нет корней уравнения!";
                            break;
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textboxA, "");
            errorProvider.SetError(textboxB, "");
            errorProvider.SetError(textboxC, "");

            //textboxA.Text = "";
            //textboxB.Text = "";
            //textboxC.Text = "";
            //labelBot.Text = "";

            textboxA.Text = textboxB.Text = textboxC.Text = labelBot.Text = "";
            buttonSum.Enabled = false;
        }

        public static int GetSolution(
            out double x1, out double x2,
            double a, double b, double c)
        {
            x1 = x2 = 0;

            if (a == 0) { return -1; }
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 2;
            }
            if (d == 0)
            {
                x1 = x2 = -b / (2 * a); return 1;
            }
            return 0;
        }

        public static int GetLinear(out double x, double b, double c)
        {
            x = 0;

            if(b != 0)
            {
                x = -c / b;
                return 1;
            }
            if(b == 0 && c != 0)
            {
                return -1;
            }
            return 0;
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.Text = text[flag];
            dlg.ShowDialog();
        }
    }
}
