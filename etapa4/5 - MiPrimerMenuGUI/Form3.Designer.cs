﻿namespace _5___MiPrimerMenuGUI
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Magenta;
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(764, 38);
            button1.TabIndex = 0;
            button1.Text = "VOLVER AL MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Plum;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(239, 127);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(318, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(271, 43);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 2;
            label1.Text = "♡♡♡♡♡Lista de Productos Seleccionados:♡♡♡♡♡";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Pink;
            label2.Location = new Point(205, 58);
            label2.Name = "label2";
            label2.Size = new Size(387, 15);
            label2.TabIndex = 3;
            label2.Text = "----------------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(205, 28);
            label3.Name = "label3";
            label3.Size = new Size(387, 15);
            label3.TabIndex = 4;
            label3.Text = "----------------------------------------------------------------------------";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}