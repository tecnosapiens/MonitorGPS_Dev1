using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GPS_monitor
{
    public partial class CanvasMapa : UserControl
    {
      
        Bitmap bmMem;//bitmap del control que se trabajara
        Bitmap geoImagen;
        Graphics mem;
       
        Pen pluma;
        Font fuente;
        SolidBrush brochaTexto;

        int imgAncho;
        int imgAlto;

        int panelCanvasAnchoIni;
        int panelCanvasAltoIni;
        
        bool imagenAbierta;

        //variables del world file
        double deltaLongitud;
        double deltaLatitud;
        double rotacionX;
        double rotacionY;
        double longitudEsquina;
        double latitudEsquina;
        double factorEscala;

        double latitudActual;
        double longitudActual;
        double rumboActual;
        double velocidadActual;

        int pictureXAnt;
        int pictureYAnt;

        int zoomAncho;
        int zoomAlto;


        List<FileWLD> listaFileWLD;

        

        //variables de barrar se dezplazamiento para el picturebox del control
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;

        public CanvasMapa()
        {
            InitializeComponent();

            panelCanvasAnchoIni = panel_pictureBox.Width;
            panelCanvasAltoIni = panel_pictureBox.Height;

            pictureBox_canvasMapa.Width = panel_pictureBox.Width;
            pictureBox_canvasMapa.Height = panel_pictureBox.Height;

            

            this.vScrollBar1.BringToFront();
            this.hScrollBar1.BringToFront();


            //bmMem = new Bitmap(pictureBox_canvasMapa.Width, pictureBox_canvasMapa.Height);
            bmMem = new Bitmap(this.Width, this.Height);
            mem = System.Drawing.Graphics.FromImage(bmMem);
            

            pluma = new Pen(Color.Red, 2);

            //variables para el graficado de Texto
            brochaTexto = new SolidBrush(Color.Red);
            fuente = new Font("Arial", 8, FontStyle.Bold);

            imgAlto = 0;
            imgAncho = 0;

            imagenAbierta = false;

            deltaLongitud = 0.0;
            deltaLatitud = 0.0;
            rotacionX = 0.0;
            rotacionY = 0.0;
            longitudEsquina = 0.0;
            latitudEsquina = 0.0;
            factorEscala = 0.0;

            listaFileWLD = new List<FileWLD>();

            latitudActual = 0.0;
            longitudActual = 0.0;

            pictureXAnt = 1000;
            pictureYAnt = 1000;

            zoomAncho = 0;
            zoomAlto = 0;
        
         
        }

        private void button_abrirImagen_Click(object sender, EventArgs e)
        {
            string path;
            string nfileImageExtension;
            string nWorldFile;

            if (openFileDialog_geoImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (geoImagen != null)
                    {
                        geoImagen.Dispose();
                    }
                    path = System.IO.Path.GetDirectoryName(openFileDialog_geoImagen.FileName);
                    nfileImageExtension = System.IO.Path.GetFileNameWithoutExtension(openFileDialog_geoImagen.FileName);

                    geoImagen = new Bitmap(openFileDialog_geoImagen.FileName); //System.IO.Path.GetFullPath(openFileDialog_geoImagen.FileName);

                    imgAncho = geoImagen.Width;
                    imgAlto = geoImagen.Height;
                    //label_anchoImagen.Text = imgAncho.ToString();
                    //label_altoImagen.Text = imgAlto.ToString();


                    mem.DrawImage(geoImagen, 0, 0);
                    pictureBox_canvasMapa.Image = bmMem;

                    nWorldFile = path + "\\" + nfileImageExtension + ".wld";

                    try
                    {
                        System.IO.StreamReader srFile = new System.IO.StreamReader(nWorldFile);
                        deltaLongitud = Convert.ToDouble(srFile.ReadLine());
                        rotacionX = Convert.ToDouble(srFile.ReadLine());
                        rotacionY = Convert.ToDouble(srFile.ReadLine());
                        deltaLatitud = Convert.ToDouble(srFile.ReadLine());
                        longitudEsquina = Convert.ToDouble(srFile.ReadLine());
                        latitudEsquina = Convert.ToDouble(srFile.ReadLine());
                        srFile.Close();
                        imagenAbierta = true;
                    }
                    catch
                    {

                        MessageBox.Show("La Imagen no es una GeoImagen", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    }


                    this.DisplayScrollBars();
                    this.SetScrollBarValues();
                    this.Refresh();
                    button_ocultarPanelHerramientas.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("No se pudo abrir la Imagen (Posible Problema de Memoria)", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                }
               
               
            }
            else
            {
                MessageBox.Show("Debes elejir un Archivo", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }





        }

        private void button_cerrarCanvas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        #region Funcion de Control de Barras de Desplazamiento del PictureBox

        public void DisplayScrollBars()
        {
            // If the image is wider than the PictureBox, show the HScrollBar.
            if (pictureBox_canvasMapa.Width > this.geoImagen.Width - this.vScrollBar1.Width)
            {
                hScrollBar1.Visible = false;
            }
            else
            {
                hScrollBar1.Visible = true;
            }

            // If the image is taller than the PictureBox, show the VScrollBar.
            if (pictureBox_canvasMapa.Height > this.geoImagen.Height - this.hScrollBar1.Height)
            {
                vScrollBar1.Visible = false;
            }
            else
            {
                vScrollBar1.Visible = true;
            }
        }

        private void HandleScroll(Object sender, System.EventArgs se)
        {
            /* Create a graphics object and draw a portion
               of the image in the PictureBox. */


            mem.DrawImage(this.geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
                          pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                          new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                          pictureBox_canvasMapa.Right - vScrollBar1.Width,
                          pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                          GraphicsUnit.Pixel);

            mem.DrawImage(bmMem, 0, 0);
            this.pictureBox_canvasMapa.Image = bmMem;
        }

        public void SetScrollBarValues()
        {
            // Set the Maximum, Minimum, LargeChange and SmallChange properties.
            this.vScrollBar1.Minimum = 0;
            this.hScrollBar1.Minimum = 0;

            // If the offset does not make the Maximum less than zero, set its value.
            if ((this.geoImagen.Size.Width - pictureBox_canvasMapa.ClientSize.Width) > 0)
            {
                this.hScrollBar1.Maximum =  this.geoImagen.Size.Width - pictureBox_canvasMapa.ClientSize.Width;
            }
            // If the VScrollBar is visible, adjust the Maximum of the
            // HSCrollBar to account for the width of the VScrollBar. 
            if (this.vScrollBar1.Visible)
            {
                this.hScrollBar1.Maximum += this.vScrollBar1.Width;
            }
            this.hScrollBar1.LargeChange = this.hScrollBar1.Maximum / 10;
            this.hScrollBar1.SmallChange = this.hScrollBar1.Maximum / 20;

            // Adjust the Maximum value to make the raw Maximum value
            // attainable by user interaction.
            this.hScrollBar1.Maximum += this.hScrollBar1.LargeChange;

            // If the offset does not make the Maximum less than zero, set its value.   
            if ((this.geoImagen.Size.Height - pictureBox_canvasMapa.ClientSize.Height) > 0)
            {
                this.vScrollBar1.Maximum =
                    this.geoImagen.Size.Height - pictureBox_canvasMapa.ClientSize.Height;
            }

            // If the HScrollBar is visible, adjust the Maximum of the
            // VSCrollBar to account for the width of the HScrollBar.
            if (this.hScrollBar1.Visible)
            {
                this.vScrollBar1.Maximum += this.hScrollBar1.Height;
            }
            this.vScrollBar1.LargeChange = this.vScrollBar1.Maximum / 10;
            this.vScrollBar1.SmallChange = this.vScrollBar1.Maximum / 20;

            // Adjust the Maximum value to make the raw Maximum value
            // attainable by user interaction.
            this.vScrollBar1.Maximum += this.vScrollBar1.LargeChange;
        }




        #endregion 

             

        private void pictureBox_canvasMapa_MouseMove(object sender, MouseEventArgs e)
        {
            if (imagenAbierta)
            {
                double lat = 0.0;
                double lon = 0.0;

                int pixelX = 0;
                int pixelY = 0;

                int posX = 0;
                int posY = 0;

                LimpiarImagen();
                //mem.DrawImage(imagen, 0, 0);
                mem.DrawImage(geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
                         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                         new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                         pictureBox_canvasMapa.Right - vScrollBar1.Width,
                         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                         GraphicsUnit.Pixel);

                pixelX = e.X + hScrollBar1.Value;
                pixelY = e.Y + vScrollBar1.Value;

                pixelToGeo(pixelX, pixelY, ref lon, ref lat);
                posX = e.X;
                posY = e.Y;
                obtenerPosicionEtiquetasLat(e.X, e.Y, ref posX, ref posY);
                mem.DrawString(lat.ToString("00.00"), fuente, brochaTexto, posX, posY);
                obtenerPosicionEtiquetasLon(e.X, e.Y, ref posX, ref posY);
                mem.DrawString(lon.ToString("000.00"), fuente, brochaTexto, posX, posY);

                //mem.DrawString(lat.ToString("00.00"), fuente, brochaTexto, e.X + 10, e.Y);
                //mem.DrawString(lon.ToString("000.00"), fuente, brochaTexto, e.X + 10, e.Y - 10);


                
                //label_latitud.Text = lat.ToString("00.000000");
                //label_longitud.Text = lon.ToString("000.000000");





                //g.DrawImage(bmMem, 0, 0);
                pictureBox_canvasMapa.Image = bmMem;
            }
        }

        void LimpiarImagen()
        {
            mem.Clear(Color.White);
        }

        private void obtenerPosicionEtiquetasLat(int pX, int pY, ref int newPX, ref int newPY)
        {
            if(pX > (pictureBox_canvasMapa.Width-50))
            {
                newPX = pX - 40;
                newPY = pY;
            }
            else
            {
                newPX = pX + 10;
                newPY = pY;
            }

        }

        private void obtenerPosicionEtiquetasLon(int pX, int pY, ref int newPX, ref int newPY)
        {
            if (pX > (pictureBox_canvasMapa.Width - 50))
            {
                newPX = pX - 40;
                newPY = pY - 10;
            }
            else
            {
                newPX = pX + 10;
                newPY = pY - 10;
            }

        }


        void pixelToGeo(int x, int y, ref double longitud, ref double latitud)
        {
            latitud = latitudEsquina + (deltaLatitud * y);
            longitud = longitudEsquina + (deltaLongitud * x);

        }

        void geoToPixel(double longitud, double latitud, ref int x, ref int y)
        {
            y = Math.Abs(Convert.ToInt32((latitudEsquina - latitud)/deltaLatitud));
            x = Math.Abs(Convert.ToInt32((longitudEsquina - longitud)/deltaLongitud));

        }


        public void iniciarGraficado()
        {
            timer_graficadoCanvas.Enabled = true;
        }

        public void set_PosicionActual(double latitud, double longitud, double rumbo, double velocidad)
        {
            latitudActual = latitud;
            longitudActual = longitud;
            rumboActual = rumbo;
            velocidadActual = velocidad;
            this.label_latitud.Text = latitudActual.ToString("00.00000");
            this.label_longitud.Text = longitudActual.ToString("000.0000");

            //if (imagenAbierta)
            //{
            //    int pixelX = 0;
            //    int pixelY = 0;
            //    int pixelXvector = 0;
            //    int pixelYvector = 0;
            //    int pictureX = 1000;
            //    int pictureY = 1000;
            //    int pictureXvector = 1000;
            //    int pictureYvector = 1000;
               

            //    geoToPixel(longitud, latitud, ref pixelX, ref pixelY);
               
            //    if (pixelX > imgAncho || pixelY > imgAlto)
            //    {
            //        if (!abrirImagenMision())
            //        {
            //            //imagenAbierta = false;
            //            //MessageBox.Show("No se encontro GeoImagen para la Posicion Actual", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //            LimpiarImagen();

            //            mem.DrawImage(geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
            //                     pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
            //                     new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
            //                     pictureBox_canvasMapa.Right - vScrollBar1.Width,
            //                     pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
            //                     GraphicsUnit.Pixel);


            //            pluma.Color = Color.BlueViolet;
            //            mem.DrawRectangle(pluma, pictureXAnt, pictureYAnt, 5, 5);
            //            pictureBox_canvasMapa.Image = bmMem;
            //        }
            //    }
            //    else
            //    {
            //        obtenerPosPixelPictureBox(pixelX, pixelY, ref pictureX, ref pictureY);

            //        if (checkBox_seguirPosicion.Checked)
            //        {
            //            reposisionarImagen(pixelX, pixelY);
            //        }

            //        label_latitud.Text = latitud.ToString("00.0000");
            //        label_longitud.Text = longitud.ToString("000.0000");


            //        LimpiarImagen();

            //        mem.DrawImage(geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
            //                 pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
            //                 new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
            //                 pictureBox_canvasMapa.Right - vScrollBar1.Width,
            //                 pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
            //                 GraphicsUnit.Pixel);

            //        pictureXAnt = pictureX;
            //        pictureYAnt = pictureY;
            //        pluma.Color = Color.Red;
            //        mem.DrawRectangle(pluma, pictureX, pictureY, 5, 5);


            //        // calculos para el vector
            //        if (velocidad != 0 && checkBox_verVector.Checked)
            //        {
            //            double latitudFinVector = 0.0;
            //            double longitudFinVector = 0.0;
            //            ObtenerPuntoXMv_Dist(latitud, longitud, rumbo,factorEscala/10, ref latitudFinVector, ref longitudFinVector);
            //            geoToPixel(longitudFinVector, latitudFinVector, ref pixelXvector, ref pixelYvector);
            //            if (pixelXvector < imgAncho || pixelYvector < imgAlto)
            //            {
            //                obtenerPosPixelPictureBox(pixelXvector, pixelYvector, ref pictureXvector, ref pictureYvector);
            //                mem.DrawLine(pluma, pictureX + 3, pictureY + 3, pictureXvector, pictureYvector);
            //            }
                
                        
            //        }



                   
                    
            //        pictureBox_canvasMapa.Image = bmMem;
            //    }


            //}
            
        }

        private void obtenerPosPixelPictureBox(int geoImgPixelX, int geoImgPixelY, ref int pictureBoxPixelX, ref int pictureBoxPixelY)
        {
            if ((geoImgPixelX > hScrollBar1.Value && geoImgPixelX < (pictureBox_canvasMapa.Size.Width + hScrollBar1.Value)) &&
                (geoImgPixelY > vScrollBar1.Value && geoImgPixelY < (pictureBox_canvasMapa.Size.Height + vScrollBar1.Value)))
            {
                if (zoomAlto < 0 && zoomAncho < 0)
                {

                    pictureBoxPixelX = Math.Abs((geoImgPixelX - hScrollBar1.Value) - zoomAncho);
                    pictureBoxPixelY = Math.Abs((geoImgPixelY - vScrollBar1.Value) - zoomAlto);
                }
                else
                {
                    if (zoomAncho > 0 && zoomAlto > 0)
                    {
                        pictureBoxPixelX = Math.Abs((geoImgPixelX - hScrollBar1.Value)-5);
                        pictureBoxPixelY = Math.Abs((geoImgPixelY - vScrollBar1.Value)-5);

                    }
                    else
                    {
                        pictureBoxPixelX = Math.Abs(geoImgPixelX - hScrollBar1.Value);
                        pictureBoxPixelY = Math.Abs(geoImgPixelY - vScrollBar1.Value);

                    }
                }

                //pictureBoxPixelX = Math.Abs(geoImgPixelX - hScrollBar1.Value);
                //pictureBoxPixelY = Math.Abs(geoImgPixelY - vScrollBar1.Value);


            }
            
            
        }

        

        private void reposisionarImagen(int deltaX, int deltaY)
        {
            int valorHorizontal = deltaX - (pictureBox_canvasMapa.Width / 2);
            if (valorHorizontal < 0) valorHorizontal = 0;
            int valorVertical = deltaY - (pictureBox_canvasMapa.Height / 2);
            if (valorVertical < 0) valorVertical = 0;

            hScrollBar1.Value = valorHorizontal;
            vScrollBar1.Value = valorVertical;

            
            

        }

        public void ObtenerPuntoXMv_Dist(double lat1, double lon1, double rumboActual, double distancia, ref double lat2, ref double lon2)
        {
            double rad = Math.PI / 180;

            rumboActual = rumboActual * rad;
            //rumboActual = transformacionAngular(rumboActual) * rad;
            lon2 = (lon1 + ((distancia / 60) * (Math.Sin(rumboActual))));
            lat2 = (lat1 + ((distancia / 60) * (Math.Cos(rumboActual))));
        }
                        
        public void verPanelHerramientas()
        {
            if (imagenAbierta)
            {
                panel_herramientas.Visible = true;

                panel_pictureBox.Width = panelCanvasAnchoIni;
                panel_pictureBox.Height = panelCanvasAltoIni;
                pictureBox_canvasMapa.Width = panel_pictureBox.Width;
                pictureBox_canvasMapa.Height = panel_pictureBox.Height;

                imgAncho = geoImagen.Width;
                imgAlto = geoImagen.Height;


                this.DisplayScrollBars();
                this.SetScrollBarValues();
                this.Refresh();

                mem.DrawImage(this.geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
                             pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                             new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                             pictureBox_canvasMapa.Right - vScrollBar1.Width,
                             pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                             GraphicsUnit.Pixel);

                mem.DrawImage(bmMem, 0, 0);
                this.pictureBox_canvasMapa.Image = bmMem;
            }
        }

        private void button_ocultarPanelHerramientas_Click(object sender, EventArgs e)
        {
            if (imagenAbierta)
            {
                panel_herramientas.Visible = false;
                panel_pictureBox.Width = this.Width;
                panel_pictureBox.Height = this.Height;
                pictureBox_canvasMapa.Width = panel_pictureBox.Width;
                pictureBox_canvasMapa.Height = panel_pictureBox.Height;
                
                
                mem.DrawImage(this.geoImagen, 
                              new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width, pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                              new Rectangle(hScrollBar1.Value, vScrollBar1.Value,pictureBox_canvasMapa.Right - vScrollBar1.Width,pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                           GraphicsUnit.Pixel);

                mem.DrawImage(bmMem, 0, 0);
                this.pictureBox_canvasMapa.Image = bmMem;

                this.DisplayScrollBars();
                this.SetScrollBarValues();
                this.Refresh();

               
            }

        }

        private void cargarMision()
        {
            string path;
            
            string nWorldFile;
            string nImagenFile;
            int cantFile = 0;

            Bitmap geoImagenTemp;
            listaFileWLD.Clear();

            if (openFileDialog_geoImagen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    path = System.IO.Path.GetDirectoryName(openFileDialog_geoImagen.FileName)+ "\\";
                    string[] archivosEncontrados = System.IO.Directory.GetFiles(path,"*.wld");
                    string[] imagenEncontradas = System.IO.Directory.GetFiles(path, "*.jpg");
                    cantFile = archivosEncontrados.Length;

                    if (cantFile != 0)
                    {
                        for (int j = 0; j < cantFile; j++)
                        {
                            nWorldFile = archivosEncontrados[j];

                            string[] SplitFile = archivosEncontrados[j].Split('.');

                            nImagenFile = SplitFile[0] + ".jpg";
                             try
                             {
                                 System.IO.StreamReader srFile = new System.IO.StreamReader(nWorldFile);
                                 deltaLongitud = Convert.ToDouble(srFile.ReadLine());
                                 rotacionX = Convert.ToDouble(srFile.ReadLine());
                                 rotacionY = Convert.ToDouble(srFile.ReadLine());
                                 deltaLatitud = Convert.ToDouble(srFile.ReadLine());
                                 longitudEsquina = Convert.ToDouble(srFile.ReadLine());
                                 latitudEsquina = Convert.ToDouble(srFile.ReadLine());

                                 geoImagenTemp = new Bitmap(nImagenFile); //System.IO.Path.GetFullPath(openFileDialog_geoImagen.FileName);

                                 
                                 FileWLD filewdl = new FileWLD(nWorldFile,nImagenFile, deltaLatitud, deltaLongitud, rotacionX, rotacionY, longitudEsquina, latitudEsquina,geoImagenTemp.Height,geoImagenTemp.Width);
                                 listaFileWLD.Add(filewdl);
                                 
                                                                  
                                 srFile.Close();
                                 geoImagenTemp.Dispose();
                                 
                                 
                             }
                             catch
                             {

                                 MessageBox.Show("No se pudo prosesar la GeoImagen", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                             }

                        }
				  
                    }
                    else
                    {
                        MessageBox.Show("No se pudo procesar ningun archivo *.WLD", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    }

               }
               catch
               {
                   MessageBox.Show("No se puede cargar la Mision (????)", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
               }


            }
            else
            {
                MessageBox.Show("Debes elejir un Archivo", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }

            listaFileWLD.Sort();

            if (!abrirImagenMision())
            {
                this.label_latitud.Text = latitudActual.ToString();
                this.label_longitud.Text = latitudActual.ToString();
                MessageBox.Show("No se puede cargar la Mision (????)", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }



    }

        private void button_cargarMision_Click(object sender, EventArgs e)
        {
            cargarMision();
        }

        private bool abrirImagenMision()
        {
            bool estaDentro = false;
            if (IsPosicionGeoCorrecta())
            {
                for (int i = 0; i < listaFileWLD.Count; i++)
                {
                    estaDentro = listaFileWLD[i].ConsultaEspacial_dentroDe(latitudActual, longitudActual);
                    if (estaDentro)
                    {
                        if (geoImagen != null)
                        {
                            geoImagen.Dispose();
                        }

                        geoImagen = new Bitmap(listaFileWLD[i].get_rutaImagenWDL()); //System.IO.Path.GetFullPath(openFileDialog_geoImagen.FileName);

                        imgAncho = geoImagen.Width;
                        imgAlto = geoImagen.Height;

                        label_imagen.Text = listaFileWLD[i].get_nombreGeoImagen();

                        deltaLongitud = listaFileWLD[i].get_deltaLongitud();
                        rotacionX = listaFileWLD[i].get_rotacionX();
                        rotacionY = listaFileWLD[i].get_rotacionY();
                        deltaLatitud = listaFileWLD[i].get_deltaLatitud();
                        longitudEsquina = listaFileWLD[i].get_longitudEsquina();
                        latitudEsquina = listaFileWLD[i].get_latitudEsquina();
                        factorEscala = listaFileWLD[i].get_factorEscala();
                        

                        mem.DrawImage(geoImagen, 0, 0);
                        pictureBox_canvasMapa.Image = bmMem;

                        this.DisplayScrollBars();
                        this.SetScrollBarValues();
                        this.Refresh();
                        imagenAbierta = true;
                        button_ocultarPanelHerramientas.Enabled = true;
                        iniciarGraficado();

                        return true;

                    }
                    

                }
                return false;


            }
            else
            {
                return false;
            }
 
        }

        private bool IsPosicionGeoCorrecta()
        {
            for (int i = 0; i < 50000; i++)
            {
                if (latitudActual != 0 || longitudActual != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void ZoomOut()
        {
            //if (imagenAbierta)
            //{
            //}
            zoomAlto = zoomAlto + 5;
            zoomAncho = zoomAncho + 5;

            mem.DrawImage(geoImagen,
                          new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width, pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                          new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox_canvasMapa.Right - vScrollBar1.Width + zoomAncho, pictureBox_canvasMapa.Bottom - hScrollBar1.Height + zoomAlto),
                          GraphicsUnit.Pixel);

            pictureBox_canvasMapa.Image = bmMem;
            

            

        }

        private void ZoomIn()
        {
            //if (imagenAbierta)
            //{
            //}
            zoomAlto = zoomAlto - 5;
            zoomAncho = zoomAncho - 5;

            mem.DrawImage(geoImagen,
                          new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width, pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                          new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox_canvasMapa.Right - vScrollBar1.Width + zoomAncho, pictureBox_canvasMapa.Bottom - hScrollBar1.Height + zoomAlto),
                          GraphicsUnit.Pixel);

            pictureBox_canvasMapa.Image = bmMem;

        }

        private void button_fullExtent_Click(object sender, EventArgs e)
        {

            zoomAlto = 0;
            zoomAncho = 0;

            mem.DrawImage(geoImagen,
                          new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width, pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                          new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox_canvasMapa.Right - vScrollBar1.Width + zoomAncho, pictureBox_canvasMapa.Bottom - hScrollBar1.Height + zoomAlto),
                          GraphicsUnit.Pixel);

            pictureBox_canvasMapa.Image = bmMem;

        }


        private void button_zoom_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void button_zoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();

        }


        private int obtenerImagenMenorEscala(int escala, double latActual, double lonActual)
        {
            bool estaDentro = false;
                for (int i = 0; i < listaFileWLD.Count; i++)
                {
                    estaDentro = listaFileWLD[i].ConsultaEspacial_dentroDe(latActual, lonActual);
                    if (estaDentro)
                    {
                        return 0;
                    }
                }

                return 0;
           
        }

        private void timer_graficadoCanvas_Tick(object sender, EventArgs e)
        {

            if (imagenAbierta)
            {
                int pixelX = 0;
                int pixelY = 0;
                int pixelXvector = 0;
                int pixelYvector = 0;
                int pictureX = 1000;
                int pictureY = 1000;
                int pictureXvector = 1000;
                int pictureYvector = 1000;


                geoToPixel(longitudActual, latitudActual, ref pixelX, ref pixelY);

                if (pixelX > imgAncho || pixelY > imgAlto)
                {
                    if (!abrirImagenMision())
                    {
                        //imagenAbierta = false;
                        //MessageBox.Show("No se encontro GeoImagen para la Posicion Actual", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        LimpiarImagen();

                        mem.DrawImage(geoImagen,
                                 new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width, pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                            new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox_canvasMapa.Right - vScrollBar1.Width + zoomAncho, pictureBox_canvasMapa.Bottom - hScrollBar1.Height + zoomAlto),
                            GraphicsUnit.Pixel);
                        //mem.DrawImage(geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
                        //         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                        //         new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                        //         pictureBox_canvasMapa.Right - vScrollBar1.Width,
                        //         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                        //         GraphicsUnit.Pixel);


                        pluma.Color = Color.BlueViolet;
                        mem.DrawRectangle(pluma, pictureXAnt, pictureYAnt, 5, 5);
                        pictureBox_canvasMapa.Image = bmMem;
                    }
                }
                else
                {
                    obtenerPosPixelPictureBox(pixelX, pixelY, ref pictureX, ref pictureY);

                    if (checkBox_seguirPosicion.Checked)
                    {
                        reposisionarImagen(pixelX, pixelY);
                    }

                    //label_latitud.Text = latitud.ToString("00.0000");
                    //label_longitud.Text = longitud.ToString("000.0000");


                    LimpiarImagen();

                    mem.DrawImage(geoImagen, 
                                  new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                             new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox_canvasMapa.Right - vScrollBar1.Width + zoomAncho,pictureBox_canvasMapa.Bottom - hScrollBar1.Height + zoomAlto),
                             GraphicsUnit.Pixel);

                

                    //mem.DrawImage(geoImagen, new Rectangle(0, 0, pictureBox_canvasMapa.Right - vScrollBar1.Width,
                    //         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                    //         new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                    //         pictureBox_canvasMapa.Right - vScrollBar1.Width,
                    //         pictureBox_canvasMapa.Bottom - hScrollBar1.Height),
                    //         GraphicsUnit.Pixel);

                    pictureXAnt = pictureX;
                    pictureYAnt = pictureY;
                    pluma.Color = Color.Red;
                    mem.DrawRectangle(pluma, pictureX, pictureY, 5, 5);


                    // calculos para el vector
                    if (velocidadActual != 0 && checkBox_verVector.Checked)
                    {
                        double latitudFinVector = 0.0;
                        double longitudFinVector = 0.0;
                        ObtenerPuntoXMv_Dist(latitudActual, longitudActual, rumboActual, factorEscala / 10, ref latitudFinVector, ref longitudFinVector);
                        geoToPixel(longitudFinVector, latitudFinVector, ref pixelXvector, ref pixelYvector);
                        if (pixelXvector < imgAncho || pixelYvector < imgAlto)
                        {
                            obtenerPosPixelPictureBox(pixelXvector, pixelYvector, ref pictureXvector, ref pictureYvector);
                            mem.DrawLine(pluma, pictureX + 3, pictureY + 3, pictureXvector, pictureYvector);
                        }


                    }





                    pictureBox_canvasMapa.Image = bmMem;
                }


            }


        }

        
      

       


    }//fin de clase
}
