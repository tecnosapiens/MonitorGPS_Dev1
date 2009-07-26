namespace GPS_monitor
{
    partial class ConfiguraPuerto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.comboBox_ptoComunicaciones = new System.Windows.Forms.ComboBox();
            this.comboBox_bitParada = new System.Windows.Forms.ComboBox();
            this.comboBox_paridad = new System.Windows.Forms.ComboBox();
            this.comboBox_bitsDatos = new System.Windows.Forms.ComboBox();
            this.comboBox_velocidadPuerto = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox_tiempo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.Text = "Nombre Puerto";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.Text = "Velocidad";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.Text = "Bit de Datos";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.Text = "Paridad";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.Text = "Bit de Parada";
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Blue;
            this.button_cancelar.Location = new System.Drawing.Point(19, 205);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(80, 44);
            this.button_cancelar.TabIndex = 9;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackColor = System.Drawing.Color.Blue;
            this.button_aceptar.Location = new System.Drawing.Point(134, 205);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(90, 44);
            this.button_aceptar.TabIndex = 10;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // comboBox_ptoComunicaciones
            // 
            this.comboBox_ptoComunicaciones.Items.Add("COM1");
            this.comboBox_ptoComunicaciones.Items.Add("COM2");
            this.comboBox_ptoComunicaciones.Items.Add("COM3");
            this.comboBox_ptoComunicaciones.Items.Add("COM4");
            this.comboBox_ptoComunicaciones.Items.Add("COM5");
            this.comboBox_ptoComunicaciones.Items.Add("COM6");
            this.comboBox_ptoComunicaciones.Items.Add("COM7");
            this.comboBox_ptoComunicaciones.Items.Add("COM8");
            this.comboBox_ptoComunicaciones.Items.Add("COM9");
            this.comboBox_ptoComunicaciones.Location = new System.Drawing.Point(94, 11);
            this.comboBox_ptoComunicaciones.Name = "comboBox_ptoComunicaciones";
            this.comboBox_ptoComunicaciones.Size = new System.Drawing.Size(103, 22);
            this.comboBox_ptoComunicaciones.TabIndex = 16;
            // 
            // comboBox_bitParada
            // 
            this.comboBox_bitParada.Items.Add("1");
            this.comboBox_bitParada.Items.Add("1.5");
            this.comboBox_bitParada.Items.Add("2");
            this.comboBox_bitParada.Items.Add("Ninguno");
            this.comboBox_bitParada.Location = new System.Drawing.Point(94, 123);
            this.comboBox_bitParada.Name = "comboBox_bitParada";
            this.comboBox_bitParada.Size = new System.Drawing.Size(103, 22);
            this.comboBox_bitParada.TabIndex = 15;
            // 
            // comboBox_paridad
            // 
            this.comboBox_paridad.Items.Add("Par");
            this.comboBox_paridad.Items.Add("Impar");
            this.comboBox_paridad.Items.Add("Ninguno");
            this.comboBox_paridad.Items.Add("Marca");
            this.comboBox_paridad.Items.Add("Espacio");
            this.comboBox_paridad.Location = new System.Drawing.Point(94, 95);
            this.comboBox_paridad.Name = "comboBox_paridad";
            this.comboBox_paridad.Size = new System.Drawing.Size(103, 22);
            this.comboBox_paridad.TabIndex = 14;
            // 
            // comboBox_bitsDatos
            // 
            this.comboBox_bitsDatos.Items.Add("4");
            this.comboBox_bitsDatos.Items.Add("5");
            this.comboBox_bitsDatos.Items.Add("6");
            this.comboBox_bitsDatos.Items.Add("7");
            this.comboBox_bitsDatos.Items.Add("8");
            this.comboBox_bitsDatos.Location = new System.Drawing.Point(94, 67);
            this.comboBox_bitsDatos.Name = "comboBox_bitsDatos";
            this.comboBox_bitsDatos.Size = new System.Drawing.Size(103, 22);
            this.comboBox_bitsDatos.TabIndex = 13;
            // 
            // comboBox_velocidadPuerto
            // 
            this.comboBox_velocidadPuerto.Items.Add("150");
            this.comboBox_velocidadPuerto.Items.Add("300");
            this.comboBox_velocidadPuerto.Items.Add("600");
            this.comboBox_velocidadPuerto.Items.Add("1200");
            this.comboBox_velocidadPuerto.Items.Add("1800");
            this.comboBox_velocidadPuerto.Items.Add("2400");
            this.comboBox_velocidadPuerto.Items.Add("4800");
            this.comboBox_velocidadPuerto.Items.Add("7200");
            this.comboBox_velocidadPuerto.Items.Add("9600");
            this.comboBox_velocidadPuerto.Items.Add("115200");
            this.comboBox_velocidadPuerto.Location = new System.Drawing.Point(94, 39);
            this.comboBox_velocidadPuerto.Name = "comboBox_velocidadPuerto";
            this.comboBox_velocidadPuerto.Size = new System.Drawing.Size(103, 22);
            this.comboBox_velocidadPuerto.TabIndex = 12;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(203, 169);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 13);
            this.label31.Text = "ms";
            // 
            // comboBox_tiempo
            // 
            this.comboBox_tiempo.Items.Add("100");
            this.comboBox_tiempo.Items.Add("300");
            this.comboBox_tiempo.Items.Add("500");
            this.comboBox_tiempo.Items.Add("1000");
            this.comboBox_tiempo.Items.Add("2000");
            this.comboBox_tiempo.Items.Add("3000");
            this.comboBox_tiempo.Items.Add("4000");
            this.comboBox_tiempo.Items.Add("5000");
            this.comboBox_tiempo.Location = new System.Drawing.Point(141, 160);
            this.comboBox_tiempo.Name = "comboBox_tiempo";
            this.comboBox_tiempo.Size = new System.Drawing.Size(56, 22);
            this.comboBox_tiempo.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.Text = "Intervalo Recepción";
            // 
            // ConfiguraPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBox_tiempo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_ptoComunicaciones);
            this.Controls.Add(this.comboBox_bitParada);
            this.Controls.Add(this.comboBox_paridad);
            this.Controls.Add(this.comboBox_bitsDatos);
            this.Controls.Add(this.comboBox_velocidadPuerto);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfiguraPuerto";
            this.Size = new System.Drawing.Size(240, 268);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        public System.Windows.Forms.ComboBox comboBox_ptoComunicaciones;
        public System.Windows.Forms.ComboBox comboBox_bitParada;
        public System.Windows.Forms.ComboBox comboBox_paridad;
        public System.Windows.Forms.ComboBox comboBox_bitsDatos;
        public System.Windows.Forms.ComboBox comboBox_velocidadPuerto;
        private System.Windows.Forms.Label label31;
        public System.Windows.Forms.ComboBox comboBox_tiempo;
        private System.Windows.Forms.Label label7;
    }
}
