﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0___ConversorTemperaturasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(centigrados.Text) + 273).ToString();
            label1.Text = (int.Parse(centigrados.Text) * 18 / 10 + 32).ToString();
        }

        private void centigrados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
