namespace tareaCalculadora
{
    public partial class Calculadora : Form
    {
        
        private double valor1;
        private double valor2;  
        private double resultado;

        private int operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Boton igual
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 3:
                    resultado = (valor1 * valor2 );
                    textBox1.Text = resultado.ToString();
                    break;
                case 4:
                    resultado = (valor1 / valor2);
                    textBox1.Text = resultado.ToString();
                    break;
                default:
                    textBox1.Text = "Operacion no disponible";
                    break;

            }
          
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Boton 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Boton 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Boton 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Boton 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Boton 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Boton 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Boton 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Boton 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Boton 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Boton .
            textBox1.Text = textBox1.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Suma
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Division
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
}