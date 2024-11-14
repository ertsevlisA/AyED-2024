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
    public partial class Form3 : Form
    {
        private List<string> productosSeleccionados;

        // Constructor que recibe la lista de productos seleccionados
        public Form3(List<string> seleccionMaquillaje)
        {
            InitializeComponent();
            productosSeleccionados = seleccionMaquillaje;
            MostrarProductosSeleccionados();
        }

        private void MostrarProductosSeleccionados()
        {
            foreach (var producto in productosSeleccionados)
            {
                listBox1.Items.Add(producto); // Agrega cada producto a un ListBox o control de visualización
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menuForm = new Form1();
            menuForm.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
