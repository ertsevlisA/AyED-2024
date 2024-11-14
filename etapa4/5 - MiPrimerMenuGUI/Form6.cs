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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            
            comboBox1.Items.Add("Cómo elegir el maquillaje adecuado para tu tono de piel");
            comboBox1.Items.Add("Consejos para aplicar base de maquillaje");
            comboBox1.Items.Add("Cómo cuidar la piel antes del maquillaje");
            comboBox1.Items.Add("Errores comunes al aplicar maquillaje");
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consejo = string.Empty;

           
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    consejo = "Elige una base de maquillaje que sea del mismo tono que tu piel para un acabado natural.";
                    break;
                case 1:
                    consejo = "Aplica la base desde el centro del rostro hacia afuera para difuminarla mejor.";
                    break;
                case 2:
                    consejo = "Limpia bien tu rostro antes de maquillarte, usando productos que se adapten a tu tipo de piel.";
                    break;
                case 3:
                    consejo = "Evita usar demasiada cantidad de producto, menos es más para un look natural.";
                    break;
                default:
                    consejo = "Selecciona un consejo para ver los detalles.";
                    break;
            }


            MessageBox.Show(consejo, "Consejo de Maquillaje");

            DialogResult resultado = MessageBox.Show("¿Quieres otro consejo?", "Pregunta", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Por favor, elige otra opción del ComboBox.", "Nuevo Consejo");
            }
            else
            {
                MessageBox.Show("Apreta el botón para volver al menú principal.", "Volver al Menú");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 volvermenu = new Form1();
            volvermenu.Show();
            this.Close();
        }
    }
}
