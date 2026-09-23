namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            Subtract = new Button();
            Multiply = new Button();
            Divide = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Zero = new Button();
            Decimal = new Button();
            Result = new Label();
            Title = new Label();
            Clear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(271, 43);
            button1.Name = "button1";
            button1.Size = new Size(73, 99);
            button1.TabIndex = 0;
            button1.Text = "Nah, I'd Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Calculate_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(271, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 74);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Add_Click;
            // 
            // Subtract
            // 
            Subtract.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Subtract.ForeColor = SystemColors.ActiveCaption;
            Subtract.Location = new Point(271, 267);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(75, 74);
            Subtract.TabIndex = 3;
            Subtract.Text = "Subtract";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Multiply.ForeColor = SystemColors.ActiveCaption;
            Multiply.Location = new Point(271, 369);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 74);
            Multiply.TabIndex = 4;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Divide
            // 
            Divide.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Divide.ForeColor = SystemColors.ActiveCaption;
            Divide.Location = new Point(271, 463);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 74);
            Divide.TabIndex = 5;
            Divide.Text = "Divide";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // One
            // 
            One.ForeColor = SystemColors.ActiveCaption;
            One.Location = new Point(6, 275);
            One.Name = "One";
            One.Size = new Size(58, 66);
            One.TabIndex = 6;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.ForeColor = SystemColors.ActiveCaption;
            Two.Location = new Point(70, 275);
            Two.Name = "Two";
            Two.Size = new Size(58, 66);
            Two.TabIndex = 7;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.ForeColor = SystemColors.ActiveCaption;
            Three.Location = new Point(134, 275);
            Three.Name = "Three";
            Three.Size = new Size(58, 66);
            Three.TabIndex = 8;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Four
            // 
            Four.ForeColor = SystemColors.ActiveCaption;
            Four.Location = new Point(6, 347);
            Four.Name = "Four";
            Four.Size = new Size(58, 66);
            Four.TabIndex = 9;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.ForeColor = SystemColors.ActiveCaption;
            Five.Location = new Point(70, 347);
            Five.Name = "Five";
            Five.Size = new Size(58, 66);
            Five.TabIndex = 10;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.ForeColor = SystemColors.ActiveCaption;
            Six.Location = new Point(134, 347);
            Six.Name = "Six";
            Six.Size = new Size(58, 64);
            Six.TabIndex = 11;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Seven
            // 
            Seven.ForeColor = SystemColors.ActiveCaption;
            Seven.Location = new Point(6, 419);
            Seven.Name = "Seven";
            Seven.Size = new Size(58, 64);
            Seven.TabIndex = 12;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.ForeColor = SystemColors.ActiveCaption;
            Eight.Location = new Point(70, 419);
            Eight.Name = "Eight";
            Eight.Size = new Size(58, 64);
            Eight.TabIndex = 13;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.ForeColor = SystemColors.ActiveCaption;
            Nine.Location = new Point(134, 419);
            Nine.Name = "Nine";
            Nine.Size = new Size(58, 64);
            Nine.TabIndex = 14;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Zero
            // 
            Zero.ForeColor = SystemColors.ActiveCaption;
            Zero.Location = new Point(7, 495);
            Zero.Name = "Zero";
            Zero.Size = new Size(121, 42);
            Zero.TabIndex = 15;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Decimal
            // 
            Decimal.ForeColor = SystemColors.ActiveCaption;
            Decimal.Location = new Point(131, 495);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(61, 42);
            Decimal.TabIndex = 16;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            Decimal.Click += Decimal_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = Color.Transparent;
            Result.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(28, 73);
            Result.Name = "Result";
            Result.Size = new Size(0, 30);
            Result.TabIndex = 17;
            Result.Click += Result_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.DodgerBlue;
            Title.Location = new Point(15, -3);
            Title.Name = "Title";
            Title.Size = new Size(339, 43);
            Title.TabIndex = 18;
            Title.Text = "The Strongest Calculator Of Today";
            Title.Click += Title_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Clear.ForeColor = SystemColors.ActiveCaption;
            Clear.Location = new Point(198, 369);
            Clear.Name = "Clear";
            Clear.Size = new Size(67, 168);
            Clear.TabIndex = 19;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(352, 552);
            Controls.Add(Clear);
            Controls.Add(Title);
            Controls.Add(Result);
            Controls.Add(Decimal);
            Controls.Add(Zero);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button Subtract;
        private Button Multiply;
        private Button Divide;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Zero;
        private Button Decimal;
        private Label Result;
        private Label Title;
        private Button Clear;
    }
}
