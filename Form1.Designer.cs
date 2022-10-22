namespace g_lab_2
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
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.pixelsButton = new System.Windows.Forms.Button();
            this.millemetersButton = new System.Windows.Forms.Button();
            this.inchesButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(12, 12);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(1000, 500);
            this.graphPictureBox.TabIndex = 0;
            this.graphPictureBox.TabStop = false;
            // 
            // pixelsButton
            // 
            this.pixelsButton.Location = new System.Drawing.Point(116, 534);
            this.pixelsButton.Name = "pixelsButton";
            this.pixelsButton.Size = new System.Drawing.Size(121, 38);
            this.pixelsButton.TabIndex = 1;
            this.pixelsButton.Text = "Pixels";
            this.pixelsButton.UseVisualStyleBackColor = true;
            this.pixelsButton.Click += new System.EventHandler(this.pixelsButton_Click);
            // 
            // millemetersButton
            // 
            this.millemetersButton.Location = new System.Drawing.Point(315, 534);
            this.millemetersButton.Name = "millemetersButton";
            this.millemetersButton.Size = new System.Drawing.Size(121, 38);
            this.millemetersButton.TabIndex = 2;
            this.millemetersButton.Text = "Millemeters";
            this.millemetersButton.UseMnemonic = false;
            this.millemetersButton.UseVisualStyleBackColor = true;
            this.millemetersButton.Click += new System.EventHandler(this.millemetersButton_Click);
            // 
            // inchesButton
            // 
            this.inchesButton.Location = new System.Drawing.Point(513, 534);
            this.inchesButton.Name = "inchesButton";
            this.inchesButton.Size = new System.Drawing.Size(121, 38);
            this.inchesButton.TabIndex = 3;
            this.inchesButton.Text = "Inches";
            this.inchesButton.UseVisualStyleBackColor = true;
            this.inchesButton.Click += new System.EventHandler(this.inchesButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(721, 534);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 38);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 594);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inchesButton);
            this.Controls.Add(this.millemetersButton);
            this.Controls.Add(this.pixelsButton);
            this.Controls.Add(this.graphPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Button pixelsButton;
        private System.Windows.Forms.Button millemetersButton;
        private System.Windows.Forms.Button inchesButton;
        private System.Windows.Forms.Button clearButton;
    }
}

