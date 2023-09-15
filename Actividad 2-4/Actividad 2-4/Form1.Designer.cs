namespace Actividad_2_4
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
            this.seleccionarMetodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_numero = new System.Windows.Forms.Label();
            this.primer_valor = new System.Windows.Forms.TextBox();
            this.text_cambiante = new System.Windows.Forms.Label();
            this.segundo_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // seleccionarMetodo
            // 
            this.seleccionarMetodo.FormattingEnabled = true;
            this.seleccionarMetodo.Items.AddRange(new object[] {
            "Factorial ",
            "Fibonacci",
            "MCD"});
            this.seleccionarMetodo.Location = new System.Drawing.Point(12, 125);
            this.seleccionarMetodo.Name = "seleccionarMetodo";
            this.seleccionarMetodo.Size = new System.Drawing.Size(121, 21);
            this.seleccionarMetodo.TabIndex = 0;
            this.seleccionarMetodo.Text = "Seleccionar";
            this.seleccionarMetodo.SelectedIndexChanged += new System.EventHandler(this.SelecMetodo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // total_numero
            // 
            this.total_numero.AutoSize = true;
            this.total_numero.Location = new System.Drawing.Point(476, 133);
            this.total_numero.Name = "total_numero";
            this.total_numero.Size = new System.Drawing.Size(13, 13);
            this.total_numero.TabIndex = 2;
            this.total_numero.Text = "0";
            this.total_numero.Click += new System.EventHandler(this.NumeroTotal);
            // 
            // primer_valor
            // 
            this.primer_valor.Location = new System.Drawing.Point(182, 126);
            this.primer_valor.Name = "primer_valor";
            this.primer_valor.Size = new System.Drawing.Size(55, 20);
            this.primer_valor.TabIndex = 3;
            this.primer_valor.Text = "00";
            this.primer_valor.TextChanged += new System.EventHandler(this.primer_valor_TextChanged);
            // 
            // text_cambiante
            // 
            this.text_cambiante.AutoSize = true;
            this.text_cambiante.Location = new System.Drawing.Point(201, 63);
            this.text_cambiante.Name = "text_cambiante";
            this.text_cambiante.Size = new System.Drawing.Size(167, 13);
            this.text_cambiante.TabIndex = 4;
            this.text_cambiante.Text = "Seleccione un metodo para iniciar";
            this.text_cambiante.Click += new System.EventHandler(this.text_cambiante_Click);
            // 
            // segundo_valor
            // 
            this.segundo_valor.Location = new System.Drawing.Point(279, 126);
            this.segundo_valor.Name = "segundo_valor";
            this.segundo_valor.Size = new System.Drawing.Size(54, 20);
            this.segundo_valor.TabIndex = 5;
            this.segundo_valor.Text = "00";
            this.segundo_valor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.segundo_valor);
            this.Controls.Add(this.text_cambiante);
            this.Controls.Add(this.primer_valor);
            this.Controls.Add(this.total_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionarMetodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionarMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_numero;
        private System.Windows.Forms.TextBox primer_valor;
        private System.Windows.Forms.Label text_cambiante;
        private System.Windows.Forms.TextBox segundo_valor;
    }
}

