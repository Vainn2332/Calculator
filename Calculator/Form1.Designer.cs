namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ACButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ComaButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.MiniOutputLabel = new System.Windows.Forms.Label();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(289, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(510, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 27);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ACButton
            // 
            this.ACButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.ACButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACButton.Location = new System.Drawing.Point(12, 115);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(30, 41);
            this.ACButton.TabIndex = 2;
            this.ACButton.Text = "AC";
            this.ACButton.UseVisualStyleBackColor = false;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Location = new System.Drawing.Point(48, 115);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(35, 41);
            this.CButton.TabIndex = 3;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // PowButton
            // 
            this.PowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.PowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowButton.Location = new System.Drawing.Point(188, 115);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(45, 41);
            this.PowButton.TabIndex = 4;
            this.PowButton.Text = "^\r\n";
            this.PowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PowButton.UseVisualStyleBackColor = false;
            this.PowButton.Click += new System.EventHandler(this.PowButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.Location = new System.Drawing.Point(239, 115);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(56, 41);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(239, 162);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(56, 41);
            this.MultiplyButton.TabIndex = 9;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Location = new System.Drawing.Point(12, 162);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(56, 41);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(239, 209);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(56, 41);
            this.MinusButton.TabIndex = 13;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Location = new System.Drawing.Point(12, 209);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(56, 41);
            this.FourButton.TabIndex = 10;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(239, 256);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(56, 41);
            this.PlusButton.TabIndex = 17;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.ForeColor = System.Drawing.Color.Black;
            this.OneButton.Location = new System.Drawing.Point(12, 256);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(56, 41);
            this.OneButton.TabIndex = 14;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Location = new System.Drawing.Point(89, 162);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(56, 41);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Location = new System.Drawing.Point(165, 162);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(56, 41);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Location = new System.Drawing.Point(89, 209);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(56, 41);
            this.FiveButton.TabIndex = 11;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Location = new System.Drawing.Point(165, 209);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(56, 41);
            this.SixButton.TabIndex = 12;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Location = new System.Drawing.Point(89, 256);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(56, 41);
            this.TwoButton.TabIndex = 15;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Location = new System.Drawing.Point(165, 256);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(56, 41);
            this.ThreeButton.TabIndex = 16;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(184)))));
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualsButton.Location = new System.Drawing.Point(239, 303);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(56, 41);
            this.EqualsButton.TabIndex = 21;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ComaButton
            // 
            this.ComaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.ComaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComaButton.Location = new System.Drawing.Point(165, 303);
            this.ComaButton.Name = "ComaButton";
            this.ComaButton.Size = new System.Drawing.Size(56, 41);
            this.ComaButton.TabIndex = 20;
            this.ComaButton.Text = ",";
            this.ComaButton.UseVisualStyleBackColor = false;
            this.ComaButton.Click += new System.EventHandler(this.ComaButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Location = new System.Drawing.Point(89, 303);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(56, 41);
            this.ZeroButton.TabIndex = 19;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 303);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 41);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Location = new System.Drawing.Point(136, 115);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(46, 41);
            this.LogButton.TabIndex = 22;
            this.LogButton.Text = "log";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.White;
            this.OutputLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(12, 62);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputLabel.Size = new System.Drawing.Size(283, 40);
            this.OutputLabel.TabIndex = 26;
            this.OutputLabel.Text = "0";
            // 
            // MiniOutputLabel
            // 
            this.MiniOutputLabel.BackColor = System.Drawing.Color.White;
            this.MiniOutputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiniOutputLabel.Location = new System.Drawing.Point(12, 29);
            this.MiniOutputLabel.Name = "MiniOutputLabel";
            this.MiniOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MiniOutputLabel.Size = new System.Drawing.Size(283, 23);
            this.MiniOutputLabel.TabIndex = 27;
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.PlusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusMinusButton.Location = new System.Drawing.Point(89, 115);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(41, 41);
            this.PlusMinusButton.TabIndex = 28;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(309, 359);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.MiniOutputLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ComaButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.ACButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ACButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ComaButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label MiniOutputLabel;
        private System.Windows.Forms.Button PlusMinusButton;
    }
}

