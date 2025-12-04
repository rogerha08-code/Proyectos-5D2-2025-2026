namespace Tarea_2_promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;

            label1.Text = "El promedio es " + promedio.ToString("0.00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
