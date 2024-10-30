namespace _1___CobrarBecaGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clickk = new System.Windows.Forms.Button();
            this.edad = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entre 0 - 50,000",
            "50,001 - 100,000",
            "100,001 - 200,000",
            "Más de 200,000"});
            this.comboBox1.Location = new System.Drawing.Point(123, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clickk
            // 
            this.clickk.Location = new System.Drawing.Point(87, 222);
            this.clickk.Name = "clickk";
            this.clickk.Size = new System.Drawing.Size(75, 23);
            this.clickk.TabIndex = 2;
            this.clickk.Text = "click";
            this.clickk.UseVisualStyleBackColor = true;
            this.clickk.Click += new System.EventHandler(this.clickk_Click);
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(37, 111);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(31, 13);
            this.edad.TabIndex = 3;
            this.edad.Text = "edad";
            // 
            // salario
            // 
            this.salario.AutoSize = true;
            this.salario.Location = new System.Drawing.Point(40, 169);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(37, 13);
            this.salario.TabIndex = 4;
            this.salario.Text = "salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(408, 325);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.clickk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button clickk;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label salario;
    }
}

