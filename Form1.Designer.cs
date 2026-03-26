namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_title = new System.Windows.Forms.TextBox();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.CE_Button = new System.Windows.Forms.Button();
            this.C_Button = new System.Windows.Forms.Button();
            this.del_Button = new System.Windows.Forms.Button();
            this.split_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Times_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.PM_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Dot_Button = new System.Windows.Forms.Button();
            this.Result_Button = new System.Windows.Forms.Button();
            this.Percent_Button = new System.Windows.Forms.Button();
            this.Square_Button = new System.Windows.Forms.Button();
            this.Reciprocal_Button = new System.Windows.Forms.Button();
            this.Sqrt_Button = new System.Windows.Forms.Button();
            this.Left_Button = new System.Windows.Forms.Button();
            this.Right_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_title
            // 
            this.text_title.BackColor = System.Drawing.SystemColors.Menu;
            this.text_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_title.Font = new System.Drawing.Font("맑은 고딕", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_title.ForeColor = System.Drawing.Color.Green;
            this.text_title.Location = new System.Drawing.Point(123, 12);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(380, 58);
            this.text_title.TabIndex = 0;
            this.text_title.Text = "SimpleCalculator";
            this.text_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_title.TextChanged += new System.EventHandler(this.text_title_TextChanged);
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Input.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Input.Location = new System.Drawing.Point(12, 88);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(638, 47);
            this.TextBox_Input.TabIndex = 1;
            this.TextBox_Input.TextChanged += new System.EventHandler(this.TextBox_Input_TextChanged);
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Output.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Output.Location = new System.Drawing.Point(12, 156);
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.Size = new System.Drawing.Size(638, 47);
            this.TextBox_Output.TabIndex = 2;
            this.TextBox_Output.TextChanged += new System.EventHandler(this.TextBox_Output_TextChanged);
            // 
            // CE_Button
            // 
            this.CE_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CE_Button.Location = new System.Drawing.Point(216, 223);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(88, 65);
            this.CE_Button.TabIndex = 3;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = true;
            this.CE_Button.Click += new System.EventHandler(this.CE_Button_Click);
            // 
            // C_Button
            // 
            this.C_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.C_Button.Location = new System.Drawing.Point(111, 223);
            this.C_Button.Name = "C_Button";
            this.C_Button.Size = new System.Drawing.Size(88, 65);
            this.C_Button.TabIndex = 3;
            this.C_Button.Text = "C";
            this.C_Button.UseVisualStyleBackColor = true;
            this.C_Button.Click += new System.EventHandler(this.C_Button_Click);
            // 
            // del_Button
            // 
            this.del_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.del_Button.Location = new System.Drawing.Point(324, 223);
            this.del_Button.Name = "del_Button";
            this.del_Button.Size = new System.Drawing.Size(88, 65);
            this.del_Button.TabIndex = 3;
            this.del_Button.Text = "del";
            this.del_Button.UseVisualStyleBackColor = true;
            this.del_Button.Click += new System.EventHandler(this.del_Button_Click);
            // 
            // split_Button
            // 
            this.split_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.split_Button.ForeColor = System.Drawing.Color.Red;
            this.split_Button.Location = new System.Drawing.Point(434, 294);
            this.split_Button.Name = "split_Button";
            this.split_Button.Size = new System.Drawing.Size(88, 65);
            this.split_Button.TabIndex = 3;
            this.split_Button.Text = "÷";
            this.split_Button.UseVisualStyleBackColor = true;
            this.split_Button.Click += new System.EventHandler(this.split_Button_Click);
            // 
            // Seven_Button
            // 
            this.Seven_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Seven_Button.ForeColor = System.Drawing.Color.Blue;
            this.Seven_Button.Location = new System.Drawing.Point(111, 365);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(88, 65);
            this.Seven_Button.TabIndex = 3;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = true;
            this.Seven_Button.Click += new System.EventHandler(this.Seven_Button_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Eight_Button.ForeColor = System.Drawing.Color.Blue;
            this.Eight_Button.Location = new System.Drawing.Point(216, 365);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(88, 65);
            this.Eight_Button.TabIndex = 3;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = true;
            this.Eight_Button.Click += new System.EventHandler(this.Eight_Button_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Nine_Button.ForeColor = System.Drawing.Color.Blue;
            this.Nine_Button.Location = new System.Drawing.Point(324, 365);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(88, 65);
            this.Nine_Button.TabIndex = 3;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = true;
            this.Nine_Button.Click += new System.EventHandler(this.Nine_Button_Click);
            // 
            // Times_Button
            // 
            this.Times_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Times_Button.ForeColor = System.Drawing.Color.Red;
            this.Times_Button.Location = new System.Drawing.Point(434, 365);
            this.Times_Button.Name = "Times_Button";
            this.Times_Button.Size = new System.Drawing.Size(88, 65);
            this.Times_Button.TabIndex = 3;
            this.Times_Button.Text = "X";
            this.Times_Button.UseVisualStyleBackColor = true;
            this.Times_Button.Click += new System.EventHandler(this.Times_Button_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Four_Button.ForeColor = System.Drawing.Color.Blue;
            this.Four_Button.Location = new System.Drawing.Point(111, 436);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(88, 65);
            this.Four_Button.TabIndex = 3;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = true;
            this.Four_Button.Click += new System.EventHandler(this.Four_Button_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Five_Button.ForeColor = System.Drawing.Color.Blue;
            this.Five_Button.Location = new System.Drawing.Point(216, 436);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(88, 65);
            this.Five_Button.TabIndex = 3;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = true;
            this.Five_Button.Click += new System.EventHandler(this.Five_Button_Click);
            // 
            // Six_Button
            // 
            this.Six_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Six_Button.ForeColor = System.Drawing.Color.Blue;
            this.Six_Button.Location = new System.Drawing.Point(324, 436);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(88, 65);
            this.Six_Button.TabIndex = 3;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = true;
            this.Six_Button.Click += new System.EventHandler(this.Six_Button_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minus_Button.ForeColor = System.Drawing.Color.Red;
            this.Minus_Button.Location = new System.Drawing.Point(434, 436);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(88, 65);
            this.Minus_Button.TabIndex = 3;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = true;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // One_Button
            // 
            this.One_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.One_Button.ForeColor = System.Drawing.Color.Blue;
            this.One_Button.Location = new System.Drawing.Point(111, 507);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(88, 65);
            this.One_Button.TabIndex = 3;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = true;
            this.One_Button.Click += new System.EventHandler(this.One_Button_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Two_Button.ForeColor = System.Drawing.Color.Blue;
            this.Two_Button.Location = new System.Drawing.Point(216, 507);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(88, 65);
            this.Two_Button.TabIndex = 3;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = true;
            this.Two_Button.Click += new System.EventHandler(this.Two_Button_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Three_Button.ForeColor = System.Drawing.Color.Blue;
            this.Three_Button.Location = new System.Drawing.Point(324, 507);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(88, 65);
            this.Three_Button.TabIndex = 3;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = true;
            this.Three_Button.Click += new System.EventHandler(this.Three_Button_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Plus_Button.ForeColor = System.Drawing.Color.Red;
            this.Plus_Button.Location = new System.Drawing.Point(434, 507);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(88, 65);
            this.Plus_Button.TabIndex = 3;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // PM_Button
            // 
            this.PM_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PM_Button.ForeColor = System.Drawing.Color.Black;
            this.PM_Button.Location = new System.Drawing.Point(111, 578);
            this.PM_Button.Name = "PM_Button";
            this.PM_Button.Size = new System.Drawing.Size(88, 65);
            this.PM_Button.TabIndex = 3;
            this.PM_Button.Text = "+/-";
            this.PM_Button.UseVisualStyleBackColor = true;
            this.PM_Button.Click += new System.EventHandler(this.PM_Button_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Zero_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Zero_Button.ForeColor = System.Drawing.Color.Black;
            this.Zero_Button.Location = new System.Drawing.Point(216, 578);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(88, 65);
            this.Zero_Button.TabIndex = 3;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = false;
            this.Zero_Button.Click += new System.EventHandler(this.Zero_Button_Click);
            // 
            // Dot_Button
            // 
            this.Dot_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Dot_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dot_Button.ForeColor = System.Drawing.Color.Black;
            this.Dot_Button.Location = new System.Drawing.Point(324, 578);
            this.Dot_Button.Name = "Dot_Button";
            this.Dot_Button.Size = new System.Drawing.Size(88, 65);
            this.Dot_Button.TabIndex = 3;
            this.Dot_Button.Text = ".";
            this.Dot_Button.UseVisualStyleBackColor = false;
            this.Dot_Button.Click += new System.EventHandler(this.Dot_Button_Click);
            // 
            // Result_Button
            // 
            this.Result_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Result_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_Button.ForeColor = System.Drawing.Color.Black;
            this.Result_Button.Location = new System.Drawing.Point(434, 578);
            this.Result_Button.Name = "Result_Button";
            this.Result_Button.Size = new System.Drawing.Size(88, 65);
            this.Result_Button.TabIndex = 3;
            this.Result_Button.Text = "=";
            this.Result_Button.UseVisualStyleBackColor = false;
            this.Result_Button.Click += new System.EventHandler(this.Result_Button_Click);
            // 
            // Percent_Button
            // 
            this.Percent_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Percent_Button.ForeColor = System.Drawing.Color.Black;
            this.Percent_Button.Location = new System.Drawing.Point(324, 294);
            this.Percent_Button.Name = "Percent_Button";
            this.Percent_Button.Size = new System.Drawing.Size(88, 65);
            this.Percent_Button.TabIndex = 3;
            this.Percent_Button.Text = "%";
            this.Percent_Button.UseVisualStyleBackColor = true;
            this.Percent_Button.Click += new System.EventHandler(this.Percent_Button_Click);
            // 
            // Square_Button
            // 
            this.Square_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Square_Button.ForeColor = System.Drawing.Color.Black;
            this.Square_Button.Location = new System.Drawing.Point(111, 294);
            this.Square_Button.Name = "Square_Button";
            this.Square_Button.Size = new System.Drawing.Size(88, 65);
            this.Square_Button.TabIndex = 3;
            this.Square_Button.Text = "x²";
            this.Square_Button.UseVisualStyleBackColor = true;
            this.Square_Button.Click += new System.EventHandler(this.Square_Button_Click);
            // 
            // Reciprocal_Button
            // 
            this.Reciprocal_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reciprocal_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reciprocal_Button.ForeColor = System.Drawing.Color.Black;
            this.Reciprocal_Button.Location = new System.Drawing.Point(216, 294);
            this.Reciprocal_Button.Name = "Reciprocal_Button";
            this.Reciprocal_Button.Size = new System.Drawing.Size(88, 65);
            this.Reciprocal_Button.TabIndex = 3;
            this.Reciprocal_Button.Text = "¹/x";
            this.Reciprocal_Button.UseVisualStyleBackColor = false;
            this.Reciprocal_Button.Click += new System.EventHandler(this.Reciprocal_Button_Click);
            // 
            // Sqrt_Button
            // 
            this.Sqrt_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sqrt_Button.ForeColor = System.Drawing.Color.Black;
            this.Sqrt_Button.Location = new System.Drawing.Point(434, 223);
            this.Sqrt_Button.Name = "Sqrt_Button";
            this.Sqrt_Button.Size = new System.Drawing.Size(88, 65);
            this.Sqrt_Button.TabIndex = 3;
            this.Sqrt_Button.Text = "√";
            this.Sqrt_Button.UseVisualStyleBackColor = true;
            this.Sqrt_Button.Click += new System.EventHandler(this.Sqrt_Button_Click);
            // 
            // Left_Button
            // 
            this.Left_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Left_Button.ForeColor = System.Drawing.Color.Black;
            this.Left_Button.Location = new System.Drawing.Point(545, 223);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(88, 65);
            this.Left_Button.TabIndex = 3;
            this.Left_Button.Text = "(";
            this.Left_Button.UseVisualStyleBackColor = true;
            this.Left_Button.Click += new System.EventHandler(this.Left_Button_Click);
            // 
            // Right_Button
            // 
            this.Right_Button.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Right_Button.ForeColor = System.Drawing.Color.Black;
            this.Right_Button.Location = new System.Drawing.Point(545, 294);
            this.Right_Button.Name = "Right_Button";
            this.Right_Button.Size = new System.Drawing.Size(88, 65);
            this.Right_Button.TabIndex = 3;
            this.Right_Button.Text = ")";
            this.Right_Button.UseVisualStyleBackColor = true;
            this.Right_Button.Click += new System.EventHandler(this.Right_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 655);
            this.Controls.Add(this.split_Button);
            this.Controls.Add(this.del_Button);
            this.Controls.Add(this.C_Button);
            this.Controls.Add(this.Times_Button);
            this.Controls.Add(this.Nine_Button);
            this.Controls.Add(this.Eight_Button);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.Six_Button);
            this.Controls.Add(this.Five_Button);
            this.Controls.Add(this.Plus_Button);
            this.Controls.Add(this.Three_Button);
            this.Controls.Add(this.Two_Button);
            this.Controls.Add(this.Result_Button);
            this.Controls.Add(this.Dot_Button);
            this.Controls.Add(this.Zero_Button);
            this.Controls.Add(this.PM_Button);
            this.Controls.Add(this.One_Button);
            this.Controls.Add(this.Four_Button);
            this.Controls.Add(this.Right_Button);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.Sqrt_Button);
            this.Controls.Add(this.Reciprocal_Button);
            this.Controls.Add(this.Square_Button);
            this.Controls.Add(this.Percent_Button);
            this.Controls.Add(this.Seven_Button);
            this.Controls.Add(this.CE_Button);
            this.Controls.Add(this.TextBox_Output);
            this.Controls.Add(this.TextBox_Input);
            this.Controls.Add(this.text_title);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button C_Button;
        private System.Windows.Forms.Button del_Button;
        private System.Windows.Forms.Button split_Button;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Times_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Six_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button PM_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Dot_Button;
        private System.Windows.Forms.Button Result_Button;
        private System.Windows.Forms.Button Percent_Button;
        private System.Windows.Forms.Button Square_Button;
        private System.Windows.Forms.Button Reciprocal_Button;
        private System.Windows.Forms.Button Sqrt_Button;
        private System.Windows.Forms.Button Left_Button;
        private System.Windows.Forms.Button Right_Button;
    }
}

