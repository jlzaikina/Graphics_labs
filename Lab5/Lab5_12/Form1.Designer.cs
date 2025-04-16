namespace Lab5_7
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ofzTrackBar = new System.Windows.Forms.TrackBar();
            this.ofyTrackBar = new System.Windows.Forms.TrackBar();
            this.ofxTrackBar = new System.Windows.Forms.TrackBar();
            this.ofzLabel = new System.Windows.Forms.Label();
            this.ofyLabel = new System.Windows.Forms.Label();
            this.ofxLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rxLabel = new System.Windows.Forms.Label();
            this.ryLabel = new System.Windows.Forms.Label();
            this.rzLabel = new System.Windows.Forms.Label();
            this.rxTrackBar = new System.Windows.Forms.TrackBar();
            this.ryTrackBar = new System.Windows.Forms.TrackBar();
            this.rzTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofzTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rzTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(277, 2);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1070, 641);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ofzTrackBar
            // 
            this.ofzTrackBar.Location = new System.Drawing.Point(13, 221);
            this.ofzTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofzTrackBar.Name = "ofzTrackBar";
            this.ofzTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofzTrackBar.TabIndex = 1;
            // 
            // ofyTrackBar
            // 
            this.ofyTrackBar.Location = new System.Drawing.Point(13, 139);
            this.ofyTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofyTrackBar.Name = "ofyTrackBar";
            this.ofyTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofyTrackBar.TabIndex = 1;
            // 
            // ofxTrackBar
            // 
            this.ofxTrackBar.Location = new System.Drawing.Point(13, 52);
            this.ofxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofxTrackBar.Name = "ofxTrackBar";
            this.ofxTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofxTrackBar.TabIndex = 1;
            // 
            // ofzLabel
            // 
            this.ofzLabel.AutoSize = true;
            this.ofzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ofzLabel.Location = new System.Drawing.Point(13, 188);
            this.ofzLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofzLabel.Name = "ofzLabel";
            this.ofzLabel.Size = new System.Drawing.Size(201, 20);
            this.ofzLabel.TabIndex = 0;
            this.ofzLabel.Text = "Перемещение по оси Z";
            // 
            // ofyLabel
            // 
            this.ofyLabel.AutoSize = true;
            this.ofyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ofyLabel.Location = new System.Drawing.Point(11, 102);
            this.ofyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofyLabel.Name = "ofyLabel";
            this.ofyLabel.Size = new System.Drawing.Size(202, 20);
            this.ofyLabel.TabIndex = 0;
            this.ofyLabel.Text = "Перемещение по оси Y";
            // 
            // ofxLabel
            // 
            this.ofxLabel.AutoSize = true;
            this.ofxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ofxLabel.Location = new System.Drawing.Point(13, 19);
            this.ofxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofxLabel.Name = "ofxLabel";
            this.ofxLabel.Size = new System.Drawing.Size(203, 20);
            this.ofxLabel.TabIndex = 0;
            this.ofxLabel.Text = "Перемещение по оси X";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sTrackBar
            // 
            this.sTrackBar.Location = new System.Drawing.Point(13, 576);
            this.sTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.sTrackBar.Maximum = 50;
            this.sTrackBar.Minimum = 20;
            this.sTrackBar.Name = "sTrackBar";
            this.sTrackBar.Size = new System.Drawing.Size(228, 56);
            this.sTrackBar.TabIndex = 2;
            this.sTrackBar.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масштаб";
            // 
            // rxLabel
            // 
            this.rxLabel.AutoSize = true;
            this.rxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rxLabel.Location = new System.Drawing.Point(13, 302);
            this.rxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rxLabel.Name = "rxLabel";
            this.rxLabel.Size = new System.Drawing.Size(157, 20);
            this.rxLabel.TabIndex = 0;
            this.rxLabel.Text = "Поворот по оси X";
            // 
            // ryLabel
            // 
            this.ryLabel.AutoSize = true;
            this.ryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ryLabel.Location = new System.Drawing.Point(13, 386);
            this.ryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ryLabel.Name = "ryLabel";
            this.ryLabel.Size = new System.Drawing.Size(156, 20);
            this.ryLabel.TabIndex = 0;
            this.ryLabel.Text = "Поворот по оси Y";
            // 
            // rzLabel
            // 
            this.rzLabel.AutoSize = true;
            this.rzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rzLabel.Location = new System.Drawing.Point(15, 466);
            this.rzLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rzLabel.Name = "rzLabel";
            this.rzLabel.Size = new System.Drawing.Size(155, 20);
            this.rzLabel.TabIndex = 0;
            this.rzLabel.Text = "Поворот по оси Z";
            // 
            // rxTrackBar
            // 
            this.rxTrackBar.Location = new System.Drawing.Point(13, 326);
            this.rxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.rxTrackBar.Maximum = 360;
            this.rxTrackBar.Name = "rxTrackBar";
            this.rxTrackBar.Size = new System.Drawing.Size(228, 56);
            this.rxTrackBar.TabIndex = 1;
            // 
            // ryTrackBar
            // 
            this.ryTrackBar.Location = new System.Drawing.Point(13, 410);
            this.ryTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ryTrackBar.Maximum = 360;
            this.ryTrackBar.Name = "ryTrackBar";
            this.ryTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ryTrackBar.TabIndex = 1;
            // 
            // rzTrackBar
            // 
            this.rzTrackBar.Location = new System.Drawing.Point(13, 490);
            this.rzTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.rzTrackBar.Maximum = 360;
            this.rzTrackBar.Name = "rzTrackBar";
            this.rzTrackBar.Size = new System.Drawing.Size(228, 56);
            this.rzTrackBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 645);
            this.Controls.Add(this.sTrackBar);
            this.Controls.Add(this.rzTrackBar);
            this.Controls.Add(this.ofzTrackBar);
            this.Controls.Add(this.rzLabel);
            this.Controls.Add(this.ryTrackBar);
            this.Controls.Add(this.rxTrackBar);
            this.Controls.Add(this.ryLabel);
            this.Controls.Add(this.ofzLabel);
            this.Controls.Add(this.ofyTrackBar);
            this.Controls.Add(this.ofyLabel);
            this.Controls.Add(this.rxLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ofxTrackBar);
            this.Controls.Add(this.ofxLabel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LR5";
            this.Load += new System.EventHandler(this.GrafikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofzTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rzTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar ofzTrackBar;
        private System.Windows.Forms.TrackBar ofyTrackBar;
        private System.Windows.Forms.TrackBar ofxTrackBar;
        private System.Windows.Forms.Label ofzLabel;
        private System.Windows.Forms.Label ofyLabel;
        private System.Windows.Forms.Label ofxLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar sTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rxLabel;
        private System.Windows.Forms.Label ryLabel;
        private System.Windows.Forms.Label rzLabel;
        private System.Windows.Forms.TrackBar rxTrackBar;
        private System.Windows.Forms.TrackBar ryTrackBar;
        private System.Windows.Forms.TrackBar rzTrackBar;
    }
}

