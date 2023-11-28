namespace Mediana_and_Avarage
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
            textBox1 = new TextBox();
            label1 = new Label();
            mediana = new Label();
            calculate = new Button();
            average = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 54);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // mediana
            // 
            mediana.AutoSize = true;
            mediana.Location = new Point(22, 74);
            mediana.Name = "mediana";
            mediana.Size = new Size(67, 20);
            mediana.TabIndex = 2;
            mediana.Text = "mediana";
            // 
            // calculate
            // 
            calculate.Location = new Point(166, 16);
            calculate.Name = "calculate";
            calculate.Size = new Size(94, 29);
            calculate.TabIndex = 3;
            calculate.Text = "calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // average
            // 
            average.AutoSize = true;
            average.Location = new Point(22, 94);
            average.Name = "average";
            average.Size = new Size(62, 20);
            average.TabIndex = 4;
            average.Text = "average";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(average);
            Controls.Add(calculate);
            Controls.Add(mediana);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label mediana;
        private Button calculate;
        private Label average;
    }
}