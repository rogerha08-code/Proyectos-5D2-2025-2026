namespace gui_01
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
            label = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 35F);
            label.Location = new Point(186, -5);
            label.Name = "label";
            label.Size = new Size(503, 125);
            label.TabIndex = 0;
            label.Text = "Formulario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(84, 271);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(222, 36);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Horas trabajadas";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 313);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(404, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 264);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 126);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 0;
            label1.Text = "Sueldo final:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 63);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 1;
            label2.Text = "Total horas extras:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 188);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 2;
            label3.Text = "Total general:";
            // 
            // button1
            // 
            button1.Location = new Point(114, 369);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(211, 438);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(40, 438);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 7;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 503);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
