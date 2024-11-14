

namespace _5___MiPrimerMenuGUI
{
    partial class Form5
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
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Violet;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(216, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 244);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Location = new Point(12, 388);
            button1.Name = "button1";
            button1.Size = new Size(765, 50);
            button1.TabIndex = 1;
            button1.Text = "VOLVER AL MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.Location = new Point(247, 43);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 2;
            label1.Text = "♡♡♡♡♡Lista de Productos Seleccionados:♡♡♡♡♡";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 58);
            label2.Name = "label2";
            label2.Size = new Size(347, 15);
            label2.TabIndex = 3;
            label2.Text = "--------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 28);
            label3.Name = "label3";
            label3.Size = new Size(337, 15);
            label3.TabIndex = 4;
            label3.Text = "------------------------------------------------------------------";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}