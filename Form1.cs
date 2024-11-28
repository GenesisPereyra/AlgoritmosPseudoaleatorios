using GeneradorPseudoAleatorio.Algoritmos;
using GeneradorPseudoAleatorio.Clases;

namespace GeneradorPseudoAleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Los números tienen que ser diferentes de VACÍOS");
                return;
            }

            int a = 2;
            int m = 5;
            int semilla = 15;
            int cantidad = 10;

            List<FilaTabla> secuencia = new List<FilaTabla>();
            GeneradorCongruencialMultiplicativo simulacion = new GeneradorCongruencialMultiplicativo(a, m, semilla);
            secuencia = simulacion.ObtenerSecuencia(cantidad);

            textBox7.Text = secuencia[3].ToString(); // Media
            textBox6.Text = secuencia[2].ToString(); // Varianza
            textBox8.Text = secuencia[1].ToString();
            textBox9.Text = secuencia[0].ToString();// Desviación estándar (agregar textBox8 en el diseño)

            // Imprimir los valores de listaParcial en textBox9

            foreach (var panel in secuencia)
            {
                // Aquí puedes mostrar las propiedades del PanelSolar (por ejemplo, IdPanel, IdExperimento, VidaUtil)
                textBox9.AppendText($"{panel.N:F2}, {Environment.NewLine}");
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
