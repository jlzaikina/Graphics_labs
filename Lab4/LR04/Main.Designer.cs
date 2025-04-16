namespace LR04
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonToGrey = new System.Windows.Forms.Button();
            this.buttonMonochrome = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходное изображение";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(547, 149);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(435, 69);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть новое изображение";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonToGrey
            // 
            this.buttonToGrey.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonToGrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToGrey.Location = new System.Drawing.Point(547, 244);
            this.buttonToGrey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToGrey.Name = "buttonToGrey";
            this.buttonToGrey.Size = new System.Drawing.Size(435, 69);
            this.buttonToGrey.TabIndex = 7;
            this.buttonToGrey.Text = "Перевод в оттенки серого";
            this.buttonToGrey.UseVisualStyleBackColor = false;
            this.buttonToGrey.Click += new System.EventHandler(this.buttonToGrey_Click);
            // 
            // buttonMonochrome
            // 
            this.buttonMonochrome.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonMonochrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMonochrome.Location = new System.Drawing.Point(547, 345);
            this.buttonMonochrome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMonochrome.Name = "buttonMonochrome";
            this.buttonMonochrome.Size = new System.Drawing.Size(435, 69);
            this.buttonMonochrome.TabIndex = 8;
            this.buttonMonochrome.Text = "Преобразование серого \r\nизображения в монохромное ";
            this.buttonMonochrome.UseVisualStyleBackColor = false;
            this.buttonMonochrome.Click += new System.EventHandler(this.buttonMonochrome_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(547, 441);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(435, 69);
            this.buttonFilter.TabIndex = 9;
            this.buttonFilter.Text = " Фильтр Собеля";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(547, 534);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(435, 69);
            this.buttonResult.TabIndex = 10;
            this.buttonResult.Text = "Общий вывод";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 708);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonMonochrome);
            this.Controls.Add(this.buttonToGrey);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LR4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonToGrey;
        private System.Windows.Forms.Button buttonMonochrome;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonResult;
    }
}

