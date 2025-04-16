namespace LR3
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
            LineChecked = new RadioButton();
            Field = new PictureBox();
            numericUpDown = new NumericUpDown();
            CircleChecked = new RadioButton();
            CurvesChecked = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            FillChecked = new RadioButton();
            PatternChecked = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)Field).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // LineChecked
            // 
            LineChecked.AutoSize = true;
            LineChecked.Location = new Point(74, 97);
            LineChecked.Name = "LineChecked";
            LineChecked.Size = new Size(75, 24);
            LineChecked.TabIndex = 0;
            LineChecked.TabStop = true;
            LineChecked.Text = "Линия";
            LineChecked.UseVisualStyleBackColor = true;
            LineChecked.CheckedChanged += LineChecked_CheckedChanged;
            // 
            // Field
            // 
            Field.BackColor = Color.White;
            Field.Location = new Point(307, 12);
            Field.Name = "Field";
            Field.Size = new Size(782, 653);
            Field.TabIndex = 1;
            Field.TabStop = false;
            Field.MouseClick += Field_MouseClick;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(213, 172);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(65, 27);
            numericUpDown.TabIndex = 2;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // CircleChecked
            // 
            CircleChecked.AutoSize = true;
            CircleChecked.Location = new Point(74, 172);
            CircleChecked.Name = "CircleChecked";
            CircleChecked.Size = new Size(114, 24);
            CircleChecked.TabIndex = 3;
            CircleChecked.TabStop = true;
            CircleChecked.Text = "Окружность";
            CircleChecked.UseVisualStyleBackColor = true;
            // 
            // CurvesChecked
            // 
            CurvesChecked.AutoSize = true;
            CurvesChecked.Location = new Point(75, 255);
            CurvesChecked.Name = "CurvesChecked";
            CurvesChecked.Size = new Size(81, 24);
            CurvesChecked.TabIndex = 4;
            CurvesChecked.TabStop = true;
            CurvesChecked.Text = "Кривая";
            CurvesChecked.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(213, 255);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // FillChecked
            // 
            FillChecked.AutoSize = true;
            FillChecked.Location = new Point(74, 339);
            FillChecked.Name = "FillChecked";
            FillChecked.Size = new Size(92, 24);
            FillChecked.TabIndex = 6;
            FillChecked.TabStop = true;
            FillChecked.Text = "Закраска";
            FillChecked.UseVisualStyleBackColor = true;
            // 
            // PatternChecked
            // 
            PatternChecked.AutoSize = true;
            PatternChecked.Location = new Point(75, 411);
            PatternChecked.Name = "PatternChecked";
            PatternChecked.Size = new Size(64, 24);
            PatternChecked.TabIndex = 7;
            PatternChecked.TabStop = true;
            PatternChecked.Text = "Узор";
            PatternChecked.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 540);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Цвет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 540);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(72, 472);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Доп";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(1101, 677);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatternChecked);
            Controls.Add(FillChecked);
            Controls.Add(numericUpDown1);
            Controls.Add(CurvesChecked);
            Controls.Add(CircleChecked);
            Controls.Add(numericUpDown);
            Controls.Add(Field);
            Controls.Add(LineChecked);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)Field).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton LineChecked;
        private PictureBox Field;
        private NumericUpDown numericUpDown;
        private RadioButton CircleChecked;
        private RadioButton CurvesChecked;
        private NumericUpDown numericUpDown1;
        private RadioButton FillChecked;
        private RadioButton PatternChecked;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
    }
}
