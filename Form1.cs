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
            UpdateCurrentOutput();
        }

        private void UpdateCurrentOutput()
        {
            string text = TextBox_Input.Text;
            string[] parts = text.Split(new[] { " + ", " - ", " × ", " ÷ " }, StringSplitOptions.None);
            if (parts.Length > 0)
            {
                TextBox_Output.Text = parts[parts.Length - 1].Trim();
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
                string dot = (string.IsNullOrEmpty(TextBox_Output.Text)) ? "0." : ".";
                TextBox_Input.Text += dot;
                TextBox_Output.Text += dot;
            }
        }

        private void Plus_Button_Click(object sender, EventArgs e) => AddOperator(" + ");
        private void Minus_Button_Click(object sender, EventArgs e) => AddOperator(" - ");
        private void Times_Button_Click(object sender, EventArgs e) => AddOperator(" × ");
        private void split_Button_Click(object sender, EventArgs e) => AddOperator(" ÷ ");

        private void AddOperator(string op)
        {
            if (TextBox_Input.Text.Contains("="))
            {
                TextBox_Input.Text = TextBox_Output.Text + op;
            }
            else if (!string.IsNullOrEmpty(TextBox_Input.Text))
            {
                if (TextBox_Input.Text.EndsWith(" "))
                {
                    TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 3) + op;
                }
                else
                {
                    TextBox_Input.Text += op;
                }
            }
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Input.Text) || TextBox_Input.Text.Contains("=")) return;
            if (TextBox_Input.Text.EndsWith(" ")) return;

            try
            {
                string expression = TextBox_Input.Text.Replace("×", "*").Replace("÷", "/");
                DataTable table = new DataTable();
                double result = Convert.ToDouble(table.Compute(expression, string.Empty));

                TextBox_Output.Text = result.ToString();
                TextBox_Input.Text += " = " + result.ToString();
            }
            catch
            {
                TextBox_Output.Text = "Error";
            }
        }

        private void Square_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => Math.Pow(val, 2));
        private void Sqrt_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => Math.Sqrt(val));
        private void Reciprocal_Button_Click(object sender, EventArgs e) => ApplySingleOp(val => 1 / val);

        private void ApplySingleOp(Func<double, double> operation)
        {
            if (string.IsNullOrEmpty(TextBox_Output.Text) || TextBox_Input.Text.Contains("=")) return;

            double currentVal = double.Parse(TextBox_Output.Text);
            double newVal = operation(currentVal);

            string text = TextBox_Input.Text;
            int lastSpace = text.LastIndexOf(' ');
            if (lastSpace != -1)
            {
                TextBox_Input.Text = text.Substring(0, lastSpace + 1) + newVal.ToString();
            }
            else
            {
                TextBox_Input.Text = newVal.ToString();
            }
            TextBox_Output.Text = newVal.ToString();
        }

        private void Percent_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Output.Text) || TextBox_Input.Text.Contains("=")) return;
            double val = double.Parse(TextBox_Output.Text) / 100.0;
            ApplySingleOp(v => val);
        }

        private void PM_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Output.Text) || TextBox_Input.Text.Contains("=")) return;
            double val = double.Parse(TextBox_Output.Text) * -1;
            ApplySingleOp(v => val);
        }

        private void C_Button_Click(object sender, EventArgs e) { TextBox_Input.Clear(); TextBox_Output.Clear(); }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { C_Button_Click(sender, e); return; }
            int lastSpace = TextBox_Input.Text.LastIndexOf(' ');
            if (lastSpace != -1) TextBox_Input.Text = TextBox_Input.Text.Substring(0, lastSpace + 1);
            else TextBox_Input.Clear();
            TextBox_Output.Clear();
        }

        private void del_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { C_Button_Click(sender, e); return; }
            if (TextBox_Input.Text.Length > 0)
            {
                if (TextBox_Input.Text.EndsWith(" "))
                {
                    TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 3);
                }
                else
                {
                    TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 1);
                }
                UpdateCurrentOutput();
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
                    e.Handled = true; e.SuppressKeyPress = true;
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