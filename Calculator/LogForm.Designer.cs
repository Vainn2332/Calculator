namespace Calculator
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValuetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BasetextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LncheckBox = new System.Windows.Forms.CheckBox();
            this.LogcheckBox = new System.Windows.Forms.CheckBox();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValuetextBox
            // 
            this.ValuetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuetextBox.Location = new System.Drawing.Point(75, 64);
            this.ValuetextBox.Name = "ValuetextBox";
            this.ValuetextBox.Size = new System.Drawing.Size(69, 27);
            this.ValuetextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log";
            // 
            // BasetextBox
            // 
            this.BasetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasetextBox.Location = new System.Drawing.Point(66, 94);
            this.BasetextBox.Name = "BasetextBox";
            this.BasetextBox.Size = new System.Drawing.Size(69, 22);
            this.BasetextBox.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(71, 131);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(64, 40);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "=";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(186, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Значение log";
            // 
            // LncheckBox
            // 
            this.LncheckBox.AutoSize = true;
            this.LncheckBox.Location = new System.Drawing.Point(12, 108);
            this.LncheckBox.Name = "LncheckBox";
            this.LncheckBox.Size = new System.Drawing.Size(34, 17);
            this.LncheckBox.TabIndex = 9;
            this.LncheckBox.Text = "ln";
            this.LncheckBox.UseVisualStyleBackColor = true;
            this.LncheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LncheckBox_MouseClick);
            // 
            // LogcheckBox
            // 
            this.LogcheckBox.AutoSize = true;
            this.LogcheckBox.Location = new System.Drawing.Point(12, 131);
            this.LogcheckBox.Name = "LogcheckBox";
            this.LogcheckBox.Size = new System.Drawing.Size(58, 17);
            this.LogcheckBox.TabIndex = 10;
            this.LogcheckBox.Text = "log(10)";
            this.LogcheckBox.UseVisualStyleBackColor = true;
            this.LogcheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogcheckBox_MouseClick);
            // 
            // Outputlabel
            // 
            this.Outputlabel.BackColor = System.Drawing.Color.White;
            this.Outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Outputlabel.Location = new System.Drawing.Point(10, 23);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(172, 25);
            this.Outputlabel.TabIndex = 11;
            this.Outputlabel.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "!!!дроби через запятую";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(206, 182);
            this.Controls.Add(this.ValuetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Outputlabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LogcheckBox);
            this.Controls.Add(this.LncheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BasetextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ValuetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasetextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox LncheckBox;
        private System.Windows.Forms.CheckBox LogcheckBox;
        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.Label label3;
    }
}