namespace GPS_monitor
{
    partial class Form_ppal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu_herramientas;

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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu_herramientas = new System.Windows.Forms.MainMenu();
            this.menuItem_configuracion = new System.Windows.Forms.MenuItem();
            this.menuItem_configurarPuertoSerial = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.pictureBox_rosaManiobra = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_latitud = new System.Windows.Forms.Label();
            this.label_longitud = new System.Windows.Forms.Label();
            this.timer_recepcionDatos = new System.Windows.Forms.Timer();
            this.button_recibirGPS = new System.Windows.Forms.Button();
            this.button_pararRecepcionGPS = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_numeroSatelites = new System.Windows.Forms.Label();
            this.label_altitud = new System.Windows.Forms.Label();
            this.timer_graficadoRosa = new System.Windows.Forms.Timer();
            this.label5 = new System.Windows.Forms.Label();
            this.label_velocidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_rumbo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu_herramientas
            // 
            this.mainMenu_herramientas.MenuItems.Add(this.menuItem_configuracion);
            this.mainMenu_herramientas.MenuItems.Add(this.menuItem2);
            // 
            // menuItem_configuracion
            // 
            this.menuItem_configuracion.MenuItems.Add(this.menuItem_configurarPuertoSerial);
            this.menuItem_configuracion.Text = "Configuración";
            // 
            // menuItem_configurarPuertoSerial
            // 
            this.menuItem_configurarPuertoSerial.Text = "Configurar Puerto";
            this.menuItem_configurarPuertoSerial.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem4);
            this.menuItem2.MenuItems.Add(this.menuItem1);
            this.menuItem2.MenuItems.Add(this.menuItem3);
            this.menuItem2.Text = "Ver";
            // 
            // menuItem4
            // 
            this.menuItem4.Enabled = false;
            this.menuItem4.Text = "MapaTools";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "GeoImagen";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "NMEA-0183";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // pictureBox_rosaManiobra
            // 
            this.pictureBox_rosaManiobra.BackColor = System.Drawing.Color.Black;
            this.pictureBox_rosaManiobra.Location = new System.Drawing.Point(0, 138);
            this.pictureBox_rosaManiobra.Name = "pictureBox_rosaManiobra";
            this.pictureBox_rosaManiobra.Size = new System.Drawing.Size(136, 127);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.Text = "Latitud:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.Text = "Longitud:";
            // 
            // label_latitud
            // 
            this.label_latitud.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_latitud.ForeColor = System.Drawing.Color.Black;
            this.label_latitud.Location = new System.Drawing.Point(94, 4);
            this.label_latitud.Name = "label_latitud";
            this.label_latitud.Size = new System.Drawing.Size(143, 29);
            this.label_latitud.Text = "00° 00.00 N";
            // 
            // label_longitud
            // 
            this.label_longitud.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_longitud.Location = new System.Drawing.Point(94, 25);
            this.label_longitud.Name = "label_longitud";
            this.label_longitud.Size = new System.Drawing.Size(143, 29);
            this.label_longitud.Text = "000° 00.00 W";
            // 
            // timer_recepcionDatos
            // 
            this.timer_recepcionDatos.Interval = 1000;
            this.timer_recepcionDatos.Tick += new System.EventHandler(this.timer_recepcionDatos_Tick);
            // 
            // button_recibirGPS
            // 
            this.button_recibirGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_recibirGPS.Location = new System.Drawing.Point(142, 138);
            this.button_recibirGPS.Name = "button_recibirGPS";
            this.button_recibirGPS.Size = new System.Drawing.Size(95, 28);
            this.button_recibirGPS.TabIndex = 6;
            this.button_recibirGPS.Text = "Recibir GPS";
            this.button_recibirGPS.Click += new System.EventHandler(this.button_recibirGPS_Click);
            // 
            // button_pararRecepcionGPS
            // 
            this.button_pararRecepcionGPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_pararRecepcionGPS.Enabled = false;
            this.button_pararRecepcionGPS.Location = new System.Drawing.Point(142, 172);
            this.button_pararRecepcionGPS.Name = "button_pararRecepcionGPS";
            this.button_pararRecepcionGPS.Size = new System.Drawing.Size(95, 28);
            this.button_pararRecepcionGPS.TabIndex = 7;
            this.button_pararRecepcionGPS.Text = "Parar GPS";
            this.button_pararRecepcionGPS.Click += new System.EventHandler(this.button_pararRecepcionGPS_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.BackColor = System.Drawing.Color.Red;
            this.button_cerrar.Location = new System.Drawing.Point(142, 237);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(95, 28);
            this.button_cerrar.TabIndex = 8;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.Text = "Satelites:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.Text = "Altitud:";
            // 
            // label_numeroSatelites
            // 
            this.label_numeroSatelites.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_numeroSatelites.Location = new System.Drawing.Point(94, 44);
            this.label_numeroSatelites.Name = "label_numeroSatelites";
            this.label_numeroSatelites.Size = new System.Drawing.Size(143, 29);
            this.label_numeroSatelites.Text = "0";
            // 
            // label_altitud
            // 
            this.label_altitud.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_altitud.Location = new System.Drawing.Point(94, 63);
            this.label_altitud.Name = "label_altitud";
            this.label_altitud.Size = new System.Drawing.Size(143, 29);
            this.label_altitud.Text = "00.0";
            // 
            // timer_graficadoRosa
            // 
            this.timer_graficadoRosa.Interval = 1000;
            this.timer_graficadoRosa.Tick += new System.EventHandler(this.timer_graficadoRosa_Tick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.Text = "Velocidad:";
            // 
            // label_velocidad
            // 
            this.label_velocidad.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_velocidad.Location = new System.Drawing.Point(94, 83);
            this.label_velocidad.Name = "label_velocidad";
            this.label_velocidad.Size = new System.Drawing.Size(143, 29);
            this.label_velocidad.Text = "0.0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(4, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.Text = "Rumbo:";
            // 
            // label_rumbo
            // 
            this.label_rumbo.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label_rumbo.Location = new System.Drawing.Point(94, 103);
            this.label_rumbo.Name = "label_rumbo";
            this.label_rumbo.Size = new System.Drawing.Size(143, 29);
            this.label_rumbo.Text = "000.0";
            // 
            // Form_ppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label_rumbo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_velocidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_altitud);
            this.Controls.Add(this.label_numeroSatelites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_pararRecepcionGPS);
            this.Controls.Add(this.button_recibirGPS);
            this.Controls.Add(this.label_longitud);
            this.Controls.Add(this.label_latitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_rosaManiobra);
            this.Menu = this.mainMenu_herramientas;
            this.Name = "Form_ppal";
            this.Text = "GPS_Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem_configuracion;
        private System.Windows.Forms.MenuItem menuItem_configurarPuertoSerial;
        private System.Windows.Forms.PictureBox pictureBox_rosaManiobra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_latitud;
        private System.Windows.Forms.Label label_longitud;
        private System.Windows.Forms.Timer timer_recepcionDatos;
        private System.Windows.Forms.Button button_recibirGPS;
        private System.Windows.Forms.Button button_pararRecepcionGPS;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_numeroSatelites;
        private System.Windows.Forms.Label label_altitud;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Timer timer_graficadoRosa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_velocidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_rumbo;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;


    }
}

