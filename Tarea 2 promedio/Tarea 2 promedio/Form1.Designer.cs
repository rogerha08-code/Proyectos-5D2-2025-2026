namespace Tarea_2_promedio
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(589, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(870, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(237, 39);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(353, 312);
            button1.Name = "button1";
            button1.Size = new Size(320, 46);
            button1.TabIndex = 4;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 262);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 5;
            label1.Text = "promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 37);
            label2.Name = "label2";
            label2.Size = new Size(392, 32);
            label2.TabIndex = 6;
            label2.Text = "INGRESAR NOTAS DEL ESTUDIANTE";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
