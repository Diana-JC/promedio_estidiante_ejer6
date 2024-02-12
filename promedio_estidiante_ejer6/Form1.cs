namespace promedio_estidiante_ejer6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {



            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            double promedio = 0;

            if (double.TryParse(txt_nota1.Text, out nota1) && double.TryParse(txt_nota2.Text, out nota2) && double.TryParse(txt_nota3.Text, out nota3) && double.TryParse(txt_nota4.Text, out nota4))
            {
                promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                txt_promedio.Text = promedio.ToString();

                if (promedio >= 70)
                {
                    txt_promedio.ForeColor = Color.Green;
                    txt_situacion.Text = "APROBADO";
                    txt_situacion.ForeColor = Color.Green;
                }
                else
                {
                    txt_promedio.ForeColor = Color.Red;
                   txt_situacion.Text = "REPROBADO";
                   txt_situacion.ForeColor = Color.Red;
                }
            }



        }
    
            private void btn_Limpiar_Click(object sender, EventArgs e)
            {
                txt_nota1.Clear();
                txt_nota2.Clear();
                txt_nota3.Clear();
                txt_nota4.Clear();
                txt_promedio.Clear();
                txt_situacion.Clear();
        }

            private void btn_Salir_Click(object sender, EventArgs e)
            {
                Close();
            }
        }
    }

