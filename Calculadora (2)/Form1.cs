namespace Calculadora__2_
{
    public partial class Calculadora : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }


        private void clickOperador(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
            Operador = Convert.ToChar(boton.Tag);



            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                tXTRESULTADO.Text = Numero1.ToString();


            }

            if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                tXTRESULTADO.Text = Numero1.ToString();

            }

            else
            {

                tXTRESULTADO.Text = "0";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(tXTRESULTADO.Text);

            if (Operador == '+')
            {
                tXTRESULTADO.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
            }

            if (Operador == '-')
            {
                tXTRESULTADO.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
            }

            if (Operador == 'X')
            {
                tXTRESULTADO.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
            }

            if (Operador == '/')
            {
                if (tXTRESULTADO.Text != "0")

                {

                    tXTRESULTADO.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
                }

                else
                {
                    MessageBox.Show("EMBUTE No se puede Dividir por cero");

                }
            }

            
    
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (tXTRESULTADO.Text.Length > 1)
            {
                tXTRESULTADO.Text = tXTRESULTADO.Text.Substring(0, tXTRESULTADO.Text.Length - 1);


            }
        }

        private void BtnBorrartodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            tXTRESULTADO.Text = "0";


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tXTRESULTADO.Text = "0";

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (!tXTRESULTADO.Text.Contains("."))
            {
                tXTRESULTADO.Text += ".";

            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(tXTRESULTADO.Text);
            Numero1 *= -1;
            tXTRESULTADO.Text = Numero1.ToString();

        }

        private void agregarNumero (object sender, EventArgs e)
        {
            var boton = ((Button)sender);


            if (tXTRESULTADO.Text == "0")
                tXTRESULTADO.Text = "";


            tXTRESULTADO.Text += boton.Text;


        }


       
    }
}