namespace _5___MiPrimerMenuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo Compra Maquillaje...");
            Form2 CompraMaquillaje = new Form2();
            CompraMaquillaje.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo Compra Ropa...");
            // Crear una instancia de Form5 sin pasar parámetros, ya que el constructor tiene un valor por defecto
            Form4 compraRopa = new Form4();
            compraRopa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo Consejos Maquillaje");
            Form6 ConsejosMaquillaje = new Form6();
            ConsejosMaquillaje.Show();
        }
    }
}
