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
    public partial class Form4 : Form
    {
        public List<string> seleccionRopa = new List<string>();

        public Form4()
        {
            InitializeComponent();
            MessageBox.Show("Selecciona los productos que queres comprar:)");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("remeras/tops");
            MessageBox.Show("remeras/tops agregado a la lista de compras.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("pantalones jeans");
            MessageBox.Show("pantalones jeans agregada a la lista de compras.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("faldas");
            MessageBox.Show("faldas agregada a la lista de compras.");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("shorts");
            MessageBox.Show("shorts agregado a la lista de compras.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("camperas");
            MessageBox.Show("camperas agregada a la lista de compras.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seleccionRopa.Add("camisas");
            MessageBox.Show("camisas agregada a la lista de compras.");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form5 y pasar la lista de productos seleccionados
            Form5 form5 = new Form5(seleccionRopa);
            form5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}