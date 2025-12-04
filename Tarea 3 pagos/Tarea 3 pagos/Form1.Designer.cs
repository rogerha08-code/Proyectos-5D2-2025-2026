namespace Tarea_3_pagos
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
            button1 = new Button();
            lblBruto = new Label();
            lblAFP = new Label();
            lblSFS = new Label();
            lblDesc700 = new Label();
            lblTotalDesc = new Label();
            lblNeto = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(797, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 39);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(496, 307);
            button1.Name = "button1";
            button1.Size = new Size(266, 51);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(32, 278);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(72, 32);
            lblBruto.TabIndex = 3;
            lblBruto.Text = "Bruto";
            // 
            // lblAFP
            // 
            lblAFP.AutoSize = true;
            lblAFP.Location = new Point(122, 181);
            lblAFP.Name = "lblAFP";
            lblAFP.Size = new Size(54, 32);
            lblAFP.TabIndex = 4;
            lblAFP.Text = "AFP";
            // 
            // lblSFS
            // 
            lblSFS.AutoSize = true;
            lblSFS.Location = new Point(339, 246);
            lblSFS.Name = "lblSFS";
            lblSFS.Size = new Size(52, 32);
            lblSFS.TabIndex = 5;
            lblSFS.Text = "SFS";
            // 
            // lblDesc700
            // 
            lblDesc700.AutoSize = true;
            lblDesc700.Location = new Point(712, 246);
            lblDesc700.Name = "lblDesc700";
            lblDesc700.Size = new Size(65, 32);
            lblDesc700.TabIndex = 6;
            lblDesc700.Text = "Desc";
            // 
            // lblTotalDesc
            // 
            lblTotalDesc.AutoSize = true;
            lblTotalDesc.Location = new Point(921, 181);
            lblTotalDesc.Name = "lblTotalDesc";
            lblTotalDesc.Size = new Size(116, 32);
            lblTotalDesc.TabIndex = 7;
            lblTotalDesc.Text = "TotalDesc";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(940, 278);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(67, 32);
            lblNeto.TabIndex = 8;
            lblNeto.Text = "Neto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 73);
            label7.Name = "label7";
            label7.Size = new Size(164, 32);
            label7.TabIndex = 9;
            label7.Text = "Pago por hora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(858, 73);
            label8.Name = "label8";
            label8.Size = new Size(190, 32);
            label8.TabIndex = 10;
            label8.Text = "Horas trabajadas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 478);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblNeto);
            Controls.Add(lblTotalDesc);
            Controls.Add(lblDesc700);
            Controls.Add(lblSFS);
            Controls.Add(lblAFP);
            Controls.Add(lblBruto);
            Controls.Add(button1);
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
        private Button button1;
        private Label lblBruto;
        private Label lblAFP;
        private Label lblSFS;
        private Label lblDesc700;
        private Label lblTotalDesc;
        private Label lblNeto;
        private Label label7;
        private Label label8;
    }
}
