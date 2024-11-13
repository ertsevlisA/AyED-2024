using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
        class Personaje
        {
            string nombre;
            int vida;
            string Habilidades;


        }
        Personaje personaje = new Personaje();
         
        public Form1()
        {
            InitializeComponent();
            //eleccion de raza
            //Humano
            //Enano
            //Hobbit
            comboBox1.Items.Add("Humano");
            comboBox1.Items.Add("enano");
            comboBox1.Items.Add("hobbit");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            personaje.nombre = textBox1.Text;
            personaje.vida = int.Parse(textBox2.Text);
            personaje.raza = comboBox1.SelectedItem.ToString();

            personaje.Habilidades = "";
            if (checkBox1.Checked) personaje.Habilidades += "Invisibilidad ";
            if (checkBox2.Checked) personaje.Habilidades += "super fuerza";
            if (checkBox3.Checked) personaje.Habilidades += "Curación Rápida ";
            if (checkBox4.Checked) personaje.Habilidades += "super velocidad ";


            Form2 form2 = new Form2(personaje);
            this.Hide(); 


            form2.Show(); 



        }
    }
}
