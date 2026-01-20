namespace Tarea_4
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtCompletivo = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(12, 88);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(200, 39);
            txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(12, 183);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(200, 39);
            txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(588, 88);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(200, 39);
            txtNota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(588, 183);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(200, 39);
            txtNota4.TabIndex = 3;
            // 
            // txtCompletivo
            // 
            txtCompletivo.Location = new Point(293, 88);
            txtCompletivo.Name = "txtCompletivo";
            txtCompletivo.Size = new Size(200, 39);
            txtCompletivo.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(285, 281);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(200, 39);
            txtResultado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 355);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 6;
            label1.Text = "Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 355);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 7;
            label2.Text = "Completivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 355);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 8;
            label3.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(309, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtCompletivo);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtCompletivo;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
    }
}
