using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _5___MiPrimerMenuGUI
{
    public partial class Form2 : Form
    {
        public List<string> seleccionMaquillaje = new List<string>();

        public Form2()
        {

            InitializeComponent();
            MessageBox.Show("Selecciona los productos que queres comprar:)");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            seleccionMaquillaje.Add("Labial - Rojo");
            MessageBox.Show("Labial Rojo agregado a la lista de compras.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seleccionMaquillaje.Add("Sombra de Ojos - Nude");
            MessageBox.Show("Sombra de ojos Nude agregada a la lista de compras.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seleccionMaquillaje.Add("Base - Tono Medio");
            MessageBox.Show("Base Tono Medio agregada a la lista de compras.");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(seleccionMaquillaje);
            form3.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            seleccionMaquillaje.Add("Delineador-Negro");
            MessageBox.Show("Delineador-Negro agregada a la lista de compras.");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
