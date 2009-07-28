namespace GPS_monitor
{
    partial class CanvasMapa
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
            this.button_abrirImagen = new System.Windows.Forms.Button();
            this.openFileDialog_geoImagen = new System.Windows.Forms.OpenFileDialog();
            this.button_cerrarCanvas = new System.Windows.Forms.Button();
            this.pictureBox_canvasMapa = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel_pictureBox = new System.Windows.Forms.Panel();
            this.label_latitud = new System.Windows.Forms.Label();
            this.label_longitud = new System.Windows.Forms.Label();
            this.checkBox_seguirPosicion = new System.Windows.Forms.CheckBox();
            this.panel_herramientas = new System.Windows.Forms.Panel();
            this.button_fullExtent = new System.Windows.Forms.Button();
            this.button_zoomOut = new System.Windows.Forms.Button();
            this.checkBox_verVector = new System.Windows.Forms.CheckBox();
            this.label_imagen = new System.Windows.Forms.Label();
            this.button_zoomIn = new System.Windows.Forms.Button();
            this.button_cargarMision = new System.Windows.Forms.Button();
            this.button_ocultarPanelHerramientas = new System.Windows.Forms.Button();
            this.timer_graficadoCanvas = new System.Windows.Forms.Timer();
            this.panel_barraHerramientas = new System.Windows.Forms.Panel();
            this.panel_pictureBox.SuspendLayout();
            this.panel_herramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_abrirImagen
            // 
            this.button_abrirImagen.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.button_abrirImagen.Location = new System.Drawing.Point(6, 34);
            this.button_abrirImagen.Name = "button_abrirImagen";
            this.button_abrirImagen.Size = new System.Drawing.Size(59, 21);
            this.button_abrirImagen.TabIndex = 1;
            this.button_abrirImagen.Text = "GeoImagen";
            this.button_abrirImagen.Click += new System.EventHandler(this.button_abrirImagen_Click);
            // 
            // openFileDialog_geoImagen
            // 
            this.openFileDialog_geoImagen.FileName = "img";
            this.openFileDialog_geoImagen.Filter = "\"Image Files(.JPG)|*.JPG|All files (*.*)|*.* \"";
            // 
            // button_cerrarCanvas
            // 
            this.button_cerrarCanvas.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_cerrarCanvas.Location = new System.Drawing.Point(177, 57);
            this.button_cerrarCanvas.Name = "button_cerrarCanvas";
            this.button_cerrarCanvas.Size = new System.Drawing.Size(57, 20);
            this.button_cerrarCanvas.TabIndex = 2;
            this.button_cerrarCanvas.Text = "Cerrar";
            this.button_cerrarCanvas.Click += new System.EventHandler(this.button_cerrarCanvas_Click);
            // 
            // pictureBox_canvasMapa
            // 
            this.pictureBox_canvasMapa.BackColor = System.Drawing.Color.White;
            this.pictureBox_canvasMapa.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_canvasMapa.Name = "pictureBox_canvasMapa";
            this.pictureBox_canvasMapa.Size = new System.Drawing.Size(103, 72);
            this.pictureBox_canvasMapa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_canvasMapa_MouseMove);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(224, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 164);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.HandleScroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 164);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(240, 16);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.HandleScroll);
            // 
            // panel_pictureBox
            // 
            this.panel_pictureBox.Controls.Add(this.panel_barraHerramientas);
            this.panel_pictureBox.Controls.Add(this.pictureBox_canvasMapa);
            this.panel_pictureBox.Controls.Add(this.vScrollBar1);
            this.panel_pictureBox.Controls.Add(this.hScrollBar1);
            this.panel_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.panel_pictureBox.Name = "panel_pictureBox";
            this.panel_pictureBox.Size = new System.Drawing.Size(240, 180);
            // 
            // label_latitud
            // 
            this.label_latitud.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label_latitud.Location = new System.Drawing.Point(7, 3);
            this.label_latitud.Name = "label_latitud";
            this.label_latitud.Size = new System.Drawing.Size(68, 19);
            this.label_latitud.Text = "Latitud";
            // 
            // label_longitud
            // 
            this.label_longitud.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label_longitud.Location = new System.Drawing.Point(7, 17);
            this.label_longitud.Name = "label_longitud";
            this.label_longitud.Size = new System.Drawing.Size(75, 19);
            this.label_longitud.Text = "Longitud";
            // 
            // checkBox_seguirPosicion
            // 
            this.checkBox_seguirPosicion.Checked = true;
            this.checkBox_seguirPosicion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_seguirPosicion.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.checkBox_seguirPosicion.Location = new System.Drawing.Point(143, 34);
            this.checkBox_seguirPosicion.Name = "checkBox_seguirPosicion";
            this.checkBox_seguirPosicion.Size = new System.Drawing.Size(91, 20);
            this.checkBox_seguirPosicion.TabIndex = 3;
            this.checkBox_seguirPosicion.Text = "GeoAutomatica";
            // 
            // panel_herramientas
            // 
            this.panel_herramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_herramientas.Controls.Add(this.button_fullExtent);
            this.panel_herramientas.Controls.Add(this.button_zoomOut);
            this.panel_herramientas.Controls.Add(this.checkBox_verVector);
            this.panel_herramientas.Controls.Add(this.label_imagen);
            this.panel_herramientas.Controls.Add(this.button_zoomIn);
            this.panel_herramientas.Controls.Add(this.button_cargarMision);
            this.panel_herramientas.Controls.Add(this.button_ocultarPanelHerramientas);
            this.panel_herramientas.Controls.Add(this.button_abrirImagen);
            this.panel_herramientas.Controls.Add(this.checkBox_seguirPosicion);
            this.panel_herramientas.Controls.Add(this.button_cerrarCanvas);
            this.panel_herramientas.Controls.Add(this.label_longitud);
            this.panel_herramientas.Controls.Add(this.label_latitud);
            this.panel_herramientas.Location = new System.Drawing.Point(1, 183);
            this.panel_herramientas.Name = "panel_herramientas";
            this.panel_herramientas.Size = new System.Drawing.Size(237, 82);
            // 
            // button_fullExtent
            // 
            this.button_fullExtent.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.button_fullExtent.Location = new System.Drawing.Point(70, 8);
            this.button_fullExtent.Name = "button_fullExtent";
            this.button_fullExtent.Size = new System.Drawing.Size(47, 20);
            this.button_fullExtent.TabIndex = 23;
            this.button_fullExtent.Text = "Full Extent";
            this.button_fullExtent.Click += new System.EventHandler(this.button_fullExtent_Click);
            // 
            // button_zoomOut
            // 
            this.button_zoomOut.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.button_zoomOut.Location = new System.Drawing.Point(70, 34);
            this.button_zoomOut.Name = "button_zoomOut";
            this.button_zoomOut.Size = new System.Drawing.Size(47, 20);
            this.button_zoomOut.TabIndex = 19;
            this.button_zoomOut.Text = "Zoom Out";
            this.button_zoomOut.Click += new System.EventHandler(this.button_zoomOut_Click);
            // 
            // checkBox_verVector
            // 
            this.checkBox_verVector.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.checkBox_verVector.Location = new System.Drawing.Point(144, 16);
            this.checkBox_verVector.Name = "checkBox_verVector";
            this.checkBox_verVector.Size = new System.Drawing.Size(91, 20);
            this.checkBox_verVector.TabIndex = 15;
            this.checkBox_verVector.Text = "Vector";
            // 
            // label_imagen
            // 
            this.label_imagen.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label_imagen.Location = new System.Drawing.Point(171, 3);
            this.label_imagen.Name = "label_imagen";
            this.label_imagen.Size = new System.Drawing.Size(60, 19);
            this.label_imagen.Text = "geoImagen";
            // 
            // button_zoomIn
            // 
            this.button_zoomIn.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.button_zoomIn.Location = new System.Drawing.Point(70, 57);
            this.button_zoomIn.Name = "button_zoomIn";
            this.button_zoomIn.Size = new System.Drawing.Size(47, 20);
            this.button_zoomIn.TabIndex = 12;
            this.button_zoomIn.Text = "Zoom In";
            this.button_zoomIn.Click += new System.EventHandler(this.button_zoom_Click);
            // 
            // button_cargarMision
            // 
            this.button_cargarMision.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_cargarMision.Location = new System.Drawing.Point(6, 58);
            this.button_cargarMision.Name = "button_cargarMision";
            this.button_cargarMision.Size = new System.Drawing.Size(59, 20);
            this.button_cargarMision.TabIndex = 9;
            this.button_cargarMision.Text = "Mision";
            this.button_cargarMision.Click += new System.EventHandler(this.button_cargarMision_Click);
            // 
            // button_ocultarPanelHerramientas
            // 
            this.button_ocultarPanelHerramientas.Enabled = false;
            this.button_ocultarPanelHerramientas.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button_ocultarPanelHerramientas.Location = new System.Drawing.Point(119, 57);
            this.button_ocultarPanelHerramientas.Name = "button_ocultarPanelHerramientas";
            this.button_ocultarPanelHerramientas.Size = new System.Drawing.Size(57, 20);
            this.button_ocultarPanelHerramientas.TabIndex = 6;
            this.button_ocultarPanelHerramientas.Text = "Ocultar";
            this.button_ocultarPanelHerramientas.Click += new System.EventHandler(this.button_ocultarPanelHerramientas_Click);
            // 
            // timer_graficadoCanvas
            // 
            this.timer_graficadoCanvas.Interval = 1000;
            this.timer_graficadoCanvas.Tick += new System.EventHandler(this.timer_graficadoCanvas_Tick);
            // 
            // panel_barraHerramientas
            // 
            this.panel_barraHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_barraHerramientas.Location = new System.Drawing.Point(0, 141);
            this.panel_barraHerramientas.Name = "panel_barraHerramientas";
            this.panel_barraHerramientas.Size = new System.Drawing.Size(240, 23);
            this.panel_barraHerramientas.Visible = false;
            // 
            // CanvasMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel_herramientas);
            this.Controls.Add(this.panel_pictureBox);
            this.Name = "CanvasMapa";
            this.Size = new System.Drawing.Size(240, 268);
            this.panel_pictureBox.ResumeLayout(false);
            this.panel_herramientas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_abrirImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog_geoImagen;
        private System.Windows.Forms.Button button_cerrarCanvas;
        private System.Windows.Forms.PictureBox pictureBox_canvasMapa;
        private System.Windows.Forms.Panel panel_pictureBox;
        private System.Windows.Forms.Label label_latitud;
        private System.Windows.Forms.Label label_longitud;
        private System.Windows.Forms.CheckBox checkBox_seguirPosicion;
        private System.Windows.Forms.Panel panel_herramientas;
        private System.Windows.Forms.Button button_ocultarPanelHerramientas;
        private System.Windows.Forms.Button button_cargarMision;
        private System.Windows.Forms.Button button_zoomIn;
        private System.Windows.Forms.Label label_imagen;
        private System.Windows.Forms.CheckBox checkBox_verVector;
        private System.Windows.Forms.Timer timer_graficadoCanvas;
        private System.Windows.Forms.Button button_zoomOut;
        private System.Windows.Forms.Button button_fullExtent;
        private System.Windows.Forms.Panel panel_barraHerramientas;

    }
}
