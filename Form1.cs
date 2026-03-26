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

        private void Dot_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("=")) { TextBox_Input.Clear(); TextBox_Output.Clear(); }

            string currentText = TextBox_Input.Text;
            string op = GetCurrentOperator();

            if (string.IsNullOrEmpty(op))
            {
                if (!currentText.Contains("."))
                {
                    TextBox_Input.Text += (currentText == "" ? "0." : ".");
                }
            }
            else
            {
                string[] parts = currentText.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2 && !parts[1].Contains("."))
                {
                    TextBox_Input.Text += (parts[1] == "" ? "0." : ".");
                }
            }
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
            return !string.IsNullOrEmpty(GetCurrentOperator());
        }

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

        private void text_title_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Output_TextChanged(object sender, EventArgs e) { }
        private void TextBox_Input_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void C_Button_Click(object sender, EventArgs e)
        {
            TextBox_Input.Clear();
            TextBox_Output.Clear();
        }

        // 2. CE 버튼: 마지막으로 입력 중인 숫자(피연산자)만 통째로 삭제
        private void CE_Button_Click(object sender, EventArgs e)
        {
            // 이미 결과가 나온 상태라면 전체 초기화와 동일하게 작동
            if (TextBox_Input.Text.Contains("="))
            {
                C_Button_Click(sender, e);
                return;
            }

            string op = GetCurrentOperator();

            if (op == null)
            {
                // 연산자가 없다면 첫 번째 숫자 입력 중이므로 전체 삭제
                TextBox_Input.Clear();
            }
            else
            {
                // 연산자가 있다면 수식을 분리해서 앞부분과 연산자만 남김
                // 예: "12 + 100" -> "12 + "
                string[] parts = TextBox_Input.Text.Split(new string[] { op }, StringSplitOptions.None);
                TextBox_Input.Text = parts[0] + op;
            }
        }
        
        private void del_Button_Click(object sender, EventArgs e)
        {
            if (TextBox_Input.Text.Contains("="))
            {
                C_Button_Click(sender, e);
                return;
            }

            if (TextBox_Input.Text.Length > 0)
            {
                string currentText = TextBox_Input.Text;

                if (currentText.EndsWith(" "))
                {
                    TextBox_Input.Text = currentText.Substring(0, currentText.Length - 3);
                }
                else
                {
                    TextBox_Input.Text = currentText.Substring(0, currentText.Length - 1);
                }
            }
        }
    }
}