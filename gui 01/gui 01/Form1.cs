using System;
using System.Windows.Forms;

namespace gui_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;

            textBox2.Enabled = false;
        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            textBox2.Enabled = checkBox1.Checked;

            if (!checkBox1.Checked)
            {
                textBox2.Text = "";
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el sueldo.");
                return;
            }

            double sueldo = Convert.ToDouble(textBox1.Text);
            double totalHorasExtras = 0;

            if (checkBox1.Checked)
            {
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese las horas extras.");
                    return;
                }

                double horasExtras = Convert.ToDouble(textBox2.Text);
                double precioHora = sueldo / 160;
                totalHorasExtras = precioHora * 1.35 * horasExtras;
            }

            double totalGeneral = sueldo + totalHorasExtras;

            label1.Text = sueldo.ToString("C2");
            label2.Text = totalHorasExtras.ToString("C2");
            label3.Text = totalGeneral.ToString("C2");
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            textBox1.Focus();
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
