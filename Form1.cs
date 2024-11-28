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
                MessageBox.Show("Los n�meros tienen que ser diferentes de VAC�OS");
                return;
            }

            int cantidad = 10;

            List<double> secuencia = new List<double>();
            GeneradorCongruencialMultiplicativo simulacion = new GeneradorCongruencialMultiplicativo();
            secuencia = simulacion.ObtenerSecuencia(cantidad);

            textBox7.Text = secuencia[1].ToString(); // Media
            textBox6.Text = secuencia[0].ToString(); // Varianza
            textBox8.Text = secuencia[2].ToString();
            textBox9.Text = secuencia[2].ToString();// Desviaci�n est�ndar (agregar textBox8 en el dise�o)

            // Obtener la listaParcial de PanelSolar
            List<PanelSolar> listaParcial = simulacion.ListaPaneles;  // Aseg�rate de que la lista de Paneles sea accesible

            // Imprimir los valores de listaParcial en textBox9

            foreach (var panel in listaParcial)
            {
                // Aqu� puedes mostrar las propiedades del PanelSolar (por ejemplo, IdPanel, IdExperimento, VidaUtil)
                textBox9.AppendText($"{panel.N:F2}, {Environment.NewLine}");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
