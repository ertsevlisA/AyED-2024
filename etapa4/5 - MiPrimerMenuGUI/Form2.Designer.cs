namespace _5___MiPrimerMenuGUI
{
    partial class Form2
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Location = new Point(17, 76);
            button1.Name = "button1";
            button1.Size = new Size(393, 148);
            button1.TabIndex = 0;
            button1.Text = "Labial-Rojo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Location = new Point(17, 230);
            button2.Name = "button2";
            button2.Size = new Size(393, 147);
            button2.TabIndex = 1;
            button2.Text = "Sombra de ojos-nude";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 255);
            button3.Location = new Point(416, 76);
            button3.Name = "button3";
            button3.Size = new Size(372, 148);
            button3.TabIndex = 2;
            button3.Text = "base tono-medio";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 255);
            button4.Location = new Point(416, 230);
            button4.Name = "button4";
            button4.Size = new Size(372, 147);
            button4.TabIndex = 3;
            button4.Text = "delineador negro";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(17, 395);
            button5.Name = "button5";
            button5.Size = new Size(771, 43);
            button5.TabIndex = 4;
            button5.Text = "ver productos seleccionados";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Location = new Point(320, 25);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 5;
            label1.Text = "♡♡♡♡♡COMPRAS!!!!♡♡♡♡♡";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}