using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void clickk_Click(object sender, EventArgs e)
        {
            //x si dejan el textbox1 en blanco:
            if (textBox1.Text == "")
            {
                MessageBox.Show(" No lo dejes en blanco, ingresa tu edad >:(", "Error");
                return;
            }

            //convierte la edad en un nro valido,en caso de q no lo sea 
            int edad;

            if (!int.TryParse(textBox1.Text, out edad))
            {
                MessageBox.Show("ingresa un número válido para la edad.", "Error");
                return;
            }

            // creo una variable que funcion como la opcion elegida dentro del comboBox1
            string ingresosSeleccionados = comboBox1.SelectedItem.ToString();

            if (edad >= 19 && (ingresosSeleccionados == "100,001 - 200,000" || ingresosSeleccionados == "Más de 200,000"))
            {
                MessageBox.Show("¡Felicidades! Puedes cobrar la beca.", "Resultado");
            }
            else
            {
                MessageBox.Show("No cumples con los requisitos para cobrar la beca.", "Resultado");
            }

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
