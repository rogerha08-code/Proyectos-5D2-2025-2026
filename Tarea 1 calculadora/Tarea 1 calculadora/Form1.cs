namespace Tarea_1_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double n1, n2, res;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                res = n1 + n2;

                textBox3.Text = res.ToString();


            }
            if (radioButton2.Checked)

            {
                res = n2 - n1;
                textBox3.Text = res.ToString();
            }

            if (radioButton3.Checked)
            {
                res = n1 * n2;
                textBox3.Text = res.ToString();
            }
            if (radioButton4.Checked)
            {
                res = n2 / n1;
                textBox3.Text = res.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
