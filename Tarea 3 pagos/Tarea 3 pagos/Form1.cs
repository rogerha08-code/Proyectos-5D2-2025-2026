namespace Tarea_3_pagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener valores
            double pagoHora = double.Parse(textBox1.Text);
            double horasTrabajadas = double.Parse(textBox2.Text);

            // Calcular sueldo bruto
            double sueldoBruto = pagoHora * horasTrabajadas;

            // Calcular descuentos
            double afp = sueldoBruto * 0.0287;
            double sfs = sueldoBruto * 0.0304;
            double desc700 = 700;

            // Total descuentos
            double totalDescuentos = afp + sfs + desc700;

            // Sueldo neto
            double sueldoNeto = sueldoBruto - totalDescuentos;

            // Mostrar resultados en Labels
            lblBruto.Text = "Sueldo Bruto: " + sueldoBruto.ToString("0.00");
            lblAFP.Text = "AFP: " + afp.ToString("0.00");
            lblSFS.Text = "SFS: " + sfs.ToString("0.00");
            lblDesc700.Text = "Descuento 700: " + desc700.ToString("0.00");
            lblTotalDesc.Text = "Total Descuentos: " + totalDescuentos.ToString("0.00");
            lblNeto.Text = "Sueldo Neto: " + sueldoNeto.ToString("0.00");
        }
    }
}
