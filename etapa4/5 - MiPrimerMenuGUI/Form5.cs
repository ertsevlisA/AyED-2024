using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5___MiPrimerMenuGUI
{
    public partial class Form5 : Form
    {
        public Form5(List<string> productosSeleccionados = null)
        {
            InitializeComponent();

            if (productosSeleccionados == null)
            {
                productosSeleccionados = new List<string>();  // Si no se pasa una lista, inicializa como vacía
            }

            MostrarProductosSeleccionados(productosSeleccionados);
        }

        // Método que agrega los productos al ListBox
        private void MostrarProductosSeleccionados(List<string> productos)
        {
            foreach (var producto in productos)
            {
                listBox1.Items.Add(producto);  // Agrega los productos seleccionados a listBox1
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 volverMenu = new Form1();
            volverMenu.Show();
            this.Close();
        }

    }
}