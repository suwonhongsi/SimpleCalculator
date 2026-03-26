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
        }

        private void Zero_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "0";
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "1";
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "2";
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "3";
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "4";
        }

        private void Five_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "5";
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "6";
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "7";
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "8";
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }
            TextBox_Input.Text += "9";
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text != "" && !HasOperator())
            {
                TextBox_Input.Text += " + ";
            }
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text != "" && !HasOperator())
            {
                TextBox_Input.Text += " - ";
            }
        }

        private void Times_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text != "" && !HasOperator())
            {
                TextBox_Input.Text += " × ";
            }
        }

        private void split_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text != "" && !HasOperator())
            {
                TextBox_Input.Text += " ÷ ";
            }
        }

        private bool HasOperator()
        {
            return TextBox_Input.Text.Contains(" + ") || TextBox_Input.Text.Contains(" - ") ||
                   TextBox_Input.Text.Contains(" × ") || TextBox_Input.Text.Contains(" ÷ ");
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=") || !HasOperator()) return;

            string op = "";
            if (TextBox_Input.Text.Contains(" + ")) op = " + ";
            else if (TextBox_Input.Text.Contains(" - ")) op = " - ";
            else if (TextBox_Input.Text.Contains(" × ")) op = " × ";
            else if (TextBox_Input.Text.Contains(" ÷ ")) op = " ÷ ";

            string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);

            if (parts.Length == 2 && parts[1] != "")
            {
                int n1 = int.Parse(parts[0]);
                int n2 = int.Parse(parts[1]);
                int result = 0;

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

        private void text_title_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Output_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Input_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}