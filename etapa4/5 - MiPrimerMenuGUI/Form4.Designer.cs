﻿
namespace _5___MiPrimerMenuGUI
{
    partial class Form4
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Location = new Point(29, 57);
            button1.Name = "button1";
            button1.Size = new Size(344, 106);
            button1.TabIndex = 0;
            button1.Text = "remeras/tops";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Location = new Point(29, 169);
            button2.Name = "button2";
            button2.Size = new Size(344, 92);
            button2.TabIndex = 1;
            button2.Text = "pantalones jeans";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.Location = new Point(29, 267);
            button3.Name = "button3";
            button3.Size = new Size(344, 108);
            button3.TabIndex = 2;
            button3.Text = "faldas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.Location = new Point(429, 57);
            button4.Name = "button4";
            button4.Size = new Size(344, 106);
            button4.TabIndex = 3;
            button4.Text = "shorts";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleVioletRed;
            button5.Location = new Point(429, 169);
            button5.Name = "button5";
            button5.Size = new Size(344, 92);
            button5.TabIndex = 4;
            button5.Text = "camperas";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Location = new Point(429, 267);
            button6.Name = "button6";
            button6.Size = new Size(344, 108);
            button6.TabIndex = 5;
            button6.Text = "camisas";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 255);
            button7.Location = new Point(29, 397);
            button7.Name = "button7";
            button7.Size = new Size(744, 41);
            button7.TabIndex = 6;
            button7.Text = "ver lista de productos seleccionados";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(341, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 7;
            label1.Text = "♡♡♡♡♡Ropa!!!!!♡♡♡♡♡";
            label1.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
    }
}