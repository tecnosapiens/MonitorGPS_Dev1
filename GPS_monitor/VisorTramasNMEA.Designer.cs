namespace GPS_monitor
{
    partial class VisorTramasNMEA
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_visorTramasNMEA0183 = new System.Windows.Forms.ListBox();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.button_parar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_visorTramasNMEA0183
            // 
            this.listBox_visorTramasNMEA0183.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.listBox_visorTramasNMEA0183.Location = new System.Drawing.Point(3, 3);
            this.listBox_visorTramasNMEA0183.Name = "listBox_visorTramasNMEA0183";
            this.listBox_visorTramasNMEA0183.Size = new System.Drawing.Size(234, 192);
            this.listBox_visorTramasNMEA0183.TabIndex = 0;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(14, 222);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(59, 32);
            this.button_cerrar.TabIndex = 1;
            this.button_cerrar.Text = "cerrar";
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_iniciar
            // 
            this.button_iniciar.Location = new System.Drawing.Point(86, 222);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(61, 32);
            this.button_iniciar.TabIndex = 2;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // button_parar
            // 
            this.button_parar.Location = new System.Drawing.Point(165, 220);
            this.button_parar.Name = "button_parar";
            this.button_parar.Size = new System.Drawing.Size(61, 32);
            this.button_parar.TabIndex = 3;
            this.button_parar.Text = "Parar";
            this.button_parar.Click += new System.EventHandler(this.button_parar_Click);
            // 
            // VisorTramasNMEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button_parar);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.listBox_visorTramasNMEA0183);
            this.Name = "VisorTramasNMEA";
            this.Size = new System.Drawing.Size(240, 268);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_visorTramasNMEA0183;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.Button button_parar;
    }
}
