namespace lesson1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            zero = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            test = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            minus = new Button();
            plus = new Button();
            comma = new Button();
            button16 = new Button();
            button17 = new Button();
            button19 = new Button();
            equals = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            txtDisplay = new TextBox();
            clear = new Button();
            SuspendLayout();
            // 
            // zero
            // 
            zero.Location = new Point(12, 276);
            zero.Name = "zero";
            zero.Size = new Size(106, 52);
            zero.TabIndex = 0;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += btnNumberAction_Click;
            // 
            // one
            // 
            one.Location = new Point(12, 215);
            one.Name = "one";
            one.Size = new Size(50, 52);
            one.TabIndex = 3;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += btnNumberAction_Click;
            // 
            // two
            // 
            two.Location = new Point(68, 215);
            two.Name = "two";
            two.Size = new Size(50, 52);
            two.TabIndex = 4;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += btnNumberAction_Click;
            // 
            // three
            // 
            three.Location = new Point(124, 215);
            three.Name = "three";
            three.Size = new Size(50, 52);
            three.TabIndex = 5;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += btnNumberAction_Click;
            // 
            // four
            // 
            four.Location = new Point(12, 157);
            four.Name = "four";
            four.Size = new Size(50, 52);
            four.TabIndex = 6;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += btnNumberAction_Click;
            // 
            // five
            // 
            five.Location = new Point(68, 157);
            five.Name = "five";
            five.Size = new Size(50, 52);
            five.TabIndex = 7;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += btnNumberAction_Click;
            // 
            // six
            // 
            six.Location = new Point(124, 157);
            six.Name = "six";
            six.Size = new Size(50, 52);
            six.TabIndex = 8;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += btnNumberAction_Click;
            // 
            // test
            // 
            test.Location = new Point(12, 99);
            test.Name = "test";
            test.Size = new Size(50, 52);
            test.TabIndex = 9;
            test.Text = "7";
            test.UseVisualStyleBackColor = true;
            test.Click += btnNumberAction_Click;
            // 
            // button11
            // 
            button11.Location = new Point(68, 99);
            button11.Name = "button11";
            button11.Size = new Size(50, 52);
            button11.TabIndex = 10;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnNumberAction_Click;
            // 
            // button12
            // 
            button12.Location = new Point(124, 99);
            button12.Name = "button12";
            button12.Size = new Size(50, 52);
            button12.TabIndex = 11;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnNumberAction_Click;
            // 
            // button13
            // 
            button13.Location = new Point(180, 99);
            button13.Name = "button13";
            button13.Size = new Size(50, 52);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(180, 157);
            button14.Name = "button14";
            button14.Size = new Size(50, 52);
            button14.TabIndex = 13;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Location = new Point(180, 215);
            minus.Name = "minus";
            minus.Size = new Size(50, 52);
            minus.TabIndex = 14;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            plus.Location = new Point(180, 276);
            plus.Name = "plus";
            plus.Size = new Size(50, 52);
            plus.TabIndex = 15;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            // 
            // comma
            // 
            comma.Location = new Point(124, 276);
            comma.Name = "comma";
            comma.Size = new Size(50, 52);
            comma.TabIndex = 16;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = true;
            comma.Click += btnNumberAction_Click;
            // 
            // button16
            // 
            button16.Location = new Point(12, 41);
            button16.Name = "button16";
            button16.Size = new Size(50, 52);
            button16.TabIndex = 17;
            button16.Text = "←";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(68, 41);
            button17.Name = "button17";
            button17.Size = new Size(50, 52);
            button17.TabIndex = 18;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(180, 41);
            button19.Name = "button19";
            button19.Size = new Size(50, 52);
            button19.TabIndex = 20;
            button19.Text = "±";
            button19.UseVisualStyleBackColor = true;
            // 
            // equals
            // 
            equals.Location = new Point(236, 215);
            equals.Name = "equals";
            equals.Size = new Size(50, 113);
            equals.TabIndex = 21;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(236, 157);
            button21.Name = "button21";
            button21.Size = new Size(50, 52);
            button21.TabIndex = 22;
            button21.Text = "1/x";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(236, 99);
            button22.Name = "button22";
            button22.Size = new Size(50, 52);
            button22.TabIndex = 23;
            button22.Text = "%";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Location = new Point(236, 41);
            button23.Name = "button23";
            button23.Size = new Size(50, 52);
            button23.TabIndex = 24;
            button23.Text = "✓";
            button23.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 4);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(274, 31);
            txtDisplay.TabIndex = 25;
            // 
            // clear
            // 
            clear.Location = new Point(124, 41);
            clear.Name = "clear";
            clear.Size = new Size(50, 52);
            clear.TabIndex = 26;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += btnNumberActionClear;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 359);
            Controls.Add(clear);
            Controls.Add(txtDisplay);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(equals);
            Controls.Add(button19);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(comma);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(test);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(zero);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zero;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button test;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button minus;
        private Button plus;
        private Button comma;
        private Button button16;
        private Button button17;
        private Button btnClear;
        private Button button19;
        private Button equals;
        private Button button21;
        private Button button22;
        private Button button23;
        private TextBox txtDisplay;
        private Button clear;
    }
}
