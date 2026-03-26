using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            TextBox_Input.ReadOnly = true;
            TextBox_Output.ReadOnly = true;
            TextBox_Input.BackColor = Color.White;
            TextBox_Output.BackColor = Color.White;
        }

        private void AppendNumber(string num)
        {
            if (TextBox_Input.Text.Contains("="))
            {
                TextBox_Input.Clear();
                TextBox_Output.Clear();
            }
            TextBox_Input.Text += num;

            string op = GetCurrentOperator();
            if (op == null)
            {
                TextBox_Output.Text = TextBox_Input.Text;
            }
            else
            {
                string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    TextBox_Output.Text = parts[1].Trim();
                }
            }
        }

        private void Zero_Button_Click(object sender, EventArgs e) => AppendNumber("0");
        private void One_Button_Click(object sender, EventArgs e) => AppendNumber("1");
        private void Two_Button_Click(object sender, EventArgs e) => AppendNumber("2");
        private void Three_Button_Click(object sender, EventArgs e) => AppendNumber("3");
        private void Four_Button_Click(object sender, EventArgs e) => AppendNumber("4");
        private void Five_Button_Click(object sender, EventArgs e) => AppendNumber("5");
        private void Six_Button_Click(object sender, EventArgs e) => AppendNumber("6");
        private void Seven_Button_Click(object sender, EventArgs e) => AppendNumber("7");
        private void Eight_Button_Click(object sender, EventArgs e) => AppendNumber("8");
        private void Nine_Button_Click(object sender, EventArgs e) => AppendNumber("9");

        private void Dot_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }

            if (!TextBox_Output.Text.Contains("."))
            {
                string addDot = (TextBox_Output.Text == "" || TextBox_Output.Text == "0") ? "0." : ".";
                TextBox_Input.Text += addDot;
                TextBox_Output.Text += addDot;
            }
        }

        private void Plus_Button_Click(object sender, EventArgs e) => PrepareOperator(" + ");
        private void Minus_Button_Click(object sender, EventArgs e) => PrepareOperator(" - ");
        private void Times_Button_Click(object sender, EventArgs e) => PrepareOperator(" × ");
        private void split_Button_Click(object sender, EventArgs e) => PrepareOperator(" ÷ ");

        private void PrepareOperator(string op)
        {
            if (TextBox_Input.Text.Contains("="))
            {
                TextBox_Input.Text = TextBox_Output.Text + op;
                TextBox_Output.Text = TextBox_Output.Text;
            }
            else if (TextBox_Input.Text != "" && !HasOperator())
            {
                TextBox_Input.Text += op;
            }
        }

        private bool HasOperator() => !string.IsNullOrEmpty(GetCurrentOperator());

        private string GetCurrentOperator()
        {
            if (TextBox_Input.Text.Contains(" + ")) return " + ";
            if (TextBox_Input.Text.Contains(" - ")) return " - ";
            if (TextBox_Input.Text.Contains(" × ")) return " × ";
            if (TextBox_Input.Text.Contains(" ÷ ")) return " ÷ ";
            return null;
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            string op = GetCurrentOperator();
            if (TextBox_Input.Text.Contains("=") || op == null) return;
            string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
            if (parts.Length == 2 && parts[1] != "")
            {
                double n1 = double.Parse(parts[0]);
                double n2 = double.Parse(parts[1]);
                double result = 0;
                if (op == " + ") result = n1 + n2;
                else if (op == " - ") result = n1 - n2;
                else if (op == " × ") result = n1 * n2;
                else if (op == " ÷ ")
                {
                    if (n2 == 0) { TextBox_Output.Text = "Error"; return; }
                    result = n1 / n2;
                }
                TextBox_Output.Text = result.ToString();
                TextBox_Input.Text += " = " + result.ToString();
            }
        }

        private void Square_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => Math.Pow(val, 2));
        private void Sqrt_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => Math.Sqrt(val));
        private void Reciprocal_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => 1 / val);

        private void Percent_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=") || TextBox_Input.Text == "") return;
            string op = GetCurrentOperator();
            if (op == null)
            {
                double res = double.Parse(TextBox_Input.Text) / 100.0;
                TextBox_Input.Text = res.ToString();
                TextBox_Output.Text = res.ToString();
            }
            else
            {
                string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2 && parts[1] != "")
                {
                    double n1 = double.Parse(parts[0]);
                    double n2 = double.Parse(parts[1]);
                    double res = n1 * (n2 / 100.0);
                    TextBox_Input.Text = parts[0] + op + res.ToString();
                    TextBox_Output.Text = res.ToString();
                }
            }
        }

        private void ApplySingleOp(Func<double, double> operation)
        {
            if (TextBox_Input.Text.Contains("=") || TextBox_Input.Text == "") return;
            string op = GetCurrentOperator();
            if (op == null)
            {
                double res = operation(double.Parse(TextBox_Input.Text));
                TextBox_Input.Text = res.ToString();
                TextBox_Output.Text = res.ToString();
            }
            else
            {
                string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2 && parts[1] != "")
                {
                    double res = operation(double.Parse(parts[1]));
                    TextBox_Input.Text = parts[0] + op + res.ToString();
                    TextBox_Output.Text = res.ToString();
                }
            }
        }

        private void PM_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) return;
            string op = GetCurrentOperator();
            if (op == null && TextBox_Input.Text != "")
            {
                double val = double.Parse(TextBox_Input.Text) * -1;
                TextBox_Input.Text = val.ToString();
                TextBox_Output.Text = val.ToString();
            }
            else if (op != null)
            {
                string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2 && parts[1] != "")
                {
                    double val = double.Parse(parts[1]) * -1;
                    TextBox_Input.Text = parts[0] + op + val.ToString();
                    TextBox_Output.Text = val.ToString();
                }
            }
        }

        private void C_Button_Click(object sender, EventArgs e) { TextBox_Input.Clear(); TextBox_Output.Clear(); }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { C_Button_Click(sender, e); return; }
            string op = GetCurrentOperator();
            if (op == null) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            else
            {
                TextBox_Input.Text = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None)[0] + op;
                TextBox_Output.Clear();
            }
        }

        private void del_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { C_Button_Click(sender, e); return; }
            if (TextBox_Input.Text.Length > 0)
            {
                string currentText = TextBox_Input.Text;
                if (currentText.EndsWith(" ")) TextBox_Input.Text = currentText.Substring(0, currentText.Length - 3);
                else TextBox_Input.Text = currentText.Substring(0, currentText.Length - 1);

                string op = GetCurrentOperator();
                if (op == null) TextBox_Output.Text = TextBox_Input.Text;
                else
                {
                    string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                    TextBox_Output.Text = (parts.Length == 2) ? parts[1] : "";
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                if (!e.Shift)
                {
                    string keyStr = e.KeyCode.ToString();
                    AppendNumber(keyStr.Substring(keyStr.Length - 1));
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Add: Plus_Button_Click(null, null); e.Handled = true; break;
                case Keys.Oemplus: if (e.Shift) Plus_Button_Click(null, null); else Result_Button_Click(null, null); e.Handled = true; break;
                case Keys.Subtract: case Keys.OemMinus: Minus_Button_Click(null, null); e.Handled = true; break;
                case Keys.Multiply: Times_Button_Click(null, null); e.Handled = true; break;
                case Keys.D8: if (e.Shift) { Times_Button_Click(null, null); e.Handled = true; } break;
                case Keys.Divide: case Keys.OemQuestion: split_Button_Click(null, null); e.Handled = true; break;
                case Keys.Decimal: case Keys.OemPeriod: Dot_Button_Click(null, null); e.Handled = true; break;
                case Keys.Enter: Result_Button_Click(null, null); e.Handled = true; e.SuppressKeyPress = true; break;
                case Keys.Back: del_Button_Click(null, null); e.Handled = true; break;
                case Keys.Escape: C_Button_Click(null, null); e.Handled = true; break;
            }
        }

        private void text_title_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Output_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Input_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}