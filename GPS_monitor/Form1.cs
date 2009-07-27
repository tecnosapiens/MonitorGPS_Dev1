using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPS_monitor
{
    public partial class Form_ppal : Form
    {

        PuertoSerial puertoEntrada;
        VisorTramasNMEA visorNMEA;
        CanvasMapa canvas;
        string datoRecibido;
       // bool estadoVisor;


        //graficado rosa 
        System.Drawing.Graphics mem;
        System.Drawing.Bitmap bmMem;
        

        System.Drawing.Pen pluma;
        System.Drawing.SolidBrush brochaTexto;
        System.Drawing.Font fuenteTexto;

        int centroX;
        int centroY;
        int marcacion;
        int rumbo;
        int velocidad;

        double latitudActual;
        double longitudActual;

       


        public Form_ppal()
        {
            InitializeComponent();
            puertoEntrada = new PuertoSerial();
            visorNMEA = new VisorTramasNMEA();
            canvas = new CanvasMapa();
            datoRecibido = "No hay Dato";
           // estadoVisor = false;


            //graficado Rosa
            centroX = pictureBox_rosaManiobra.Width / 2;
            centroY = pictureBox_rosaManiobra.Height / 2;

            bmMem = new System.Drawing.Bitmap(pictureBox_rosaManiobra.Width, pictureBox_rosaManiobra.Height);
            mem = System.Drawing.Graphics.FromImage(bmMem);
            //g = pictureBox_pda.CreateGraphics();
            //imgBuque = System::Drawing::Bitmap::FromFile("californiaEscala70x500.jpg");


            pluma = new Pen(System.Drawing.Color.Red, 1);

            //variables para el graficado de Texto
            brochaTexto = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            fuenteTexto = new System.Drawing.Font("Arial", 6, FontStyle.Bold);
            marcacion = 0;
            rumbo = 0;
            velocidad = 0;
            timer_graficadoRosa.Enabled = true;

            latitudActual = 0.0;
            longitudActual = 0.0;

        }

        
        private void menuItem1_Click(object sender, EventArgs e)
        {
            ConfiguraPuerto configuracionSerial = new ConfiguraPuerto(puertoEntrada);
            this.Controls.Add(configuracionSerial);
            configuracionSerial.BringToFront();
            //configuracionSerial.Visible = true;
            configuracionSerial.Show();

        }

        private void timer_recepcionDatos_Tick(object sender, EventArgs e)
        {

            datoRecibido = puertoEntrada.recibirData();
            //label_latitud.Text = datoRecibido;
            if (puertoEntrada.IsDatosValidosSerial)
            {
                parsearRecepcionGPS(datoRecibido);

                
                    canvas.set_PosicionActual(latitudActual, longitudActual,  rumbo, velocidad);
                   
                
                    //ObtenerPuntoXMv_Dist(latitudActual, longitudActual, rumbo, 0.1, ref latitudFinVector, ref longitudFinVector);
                    //canvas.set_PosicionActual(latitudActual, longitudActual, latitudFinVector, longitudFinVector);
                    
               

                if (visorNMEA.get_estadoNMEAVisor())
                {
                    visorNMEA.set_DatosNMEAVisor(datoRecibido);
                }
            }

        }

        

        private void button_recibirGPS_Click(object sender, EventArgs e)
        {
            if (puertoEntrada.get_estadoPuertoSerial())
            {
                if (!puertoEntrada.get_estadoPuertoSerialAbierto())
                {
                    puertoEntrada.AbrirPuertoSerial();
                }
                timer_recepcionDatos.Interval = puertoEntrada.getTiempoTransmisionINT();
                timer_recepcionDatos.Enabled = true;
                button_recibirGPS.Enabled = false;
                button_pararRecepcionGPS.Enabled = true;
                menuItem_configurarPuertoSerial.Enabled = false;


               
            }
            else
            {
                MessageBox.Show("No has configurado Puerto Entrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void button_pararRecepcionGPS_Click(object sender, EventArgs e)
        {
            timer_recepcionDatos.Enabled = false;
            //timer_graficadoRosa.Enabled = false;
            if (puertoEntrada.get_estadoPuertoSerialAbierto())
            {
                puertoEntrada.CerrarPuertoSerial();
            }
            button_pararRecepcionGPS.Enabled = false;
            button_recibirGPS.Enabled = true;
            menuItem_configurarPuertoSerial.Enabled = true;
        }

        private void parsearRecepcionGPS(string dataGPS)
        {
             char[] separador = {'$',',','*'};
             string[] split = dataGPS.Split(separador);



             if (split.Length > 6)
             {
                 switch (split[1])
                 {
                     case "GPGGA": //$GPGGA,002048.548,3727.2131,S,07224.5627,W,0,0,,127.9,M,22.1,M,,*42
                         procesar_GGA(split);
                         break;
                     case "GPRMC":
                         procesar_RMC(split);
                         break;
                     //case "Ninguno":
                     //    puertoSerial.Parity = Parity.None;
                     //    break;
                     //case "Marca":
                     //    puertoSerial.Parity = Parity.Mark;
                     //    break;
                     //case "Espacio":
                     //    puertoSerial.Parity = Parity.Space;
                     //    break;
                     default:
                         break;

                 }
             }

      }


        private void procesar_GGA(string[] cadena)
        {

            label_latitud.Text = obtenerLatitud(cadena[3], cadena[4]);
         
            label_longitud.Text = obtenerLongitud(cadena[5],cadena[6]);

            label_numeroSatelites.Text = cadena[8];

            label_altitud.Text = cadena[10];
            
            latitudActual = obtenerLatitudN(cadena[3], cadena[4]);
            longitudActual = obtenerLongitudN(cadena[5], cadena[6]);

        }

        private void procesar_RMC(string[] cadena)
        {

            label_velocidad.Text = cadena[8];
            velocidad = (int)Convert.ToDouble(cadena[8]);
            label_rumbo.Text = cadena[9];
            rumbo = (int) Convert.ToDouble(cadena[9]);

        }


        private string obtenerLatitud(string Latitud, string dirLatitud)
        {
            string[] splitLatitud = Latitud.Split('.');

            //Latitude
            Double dLat = Convert.ToDouble(splitLatitud[0]);
            dLat = dLat / 100;
            string[] lat = dLat.ToString("00.00").Split('.');
            if (lat.Length > 1)
            {
                return lat[0] + "° " + lat[1] + "' " + (((Convert.ToDouble(splitLatitud[1]) / 10000) * 60)).ToString("##") + "'' " + dirLatitud;
            }
            else
            {
                return "Posicion Error";
            }
            


        }

        private string obtenerLongitud(string Longitud, string dirLongitud)
        {
            string[] splitLongitud = Longitud.Split('.');

            //Longitude
            Double dLo = Convert.ToDouble(splitLongitud[0]);
            dLo = dLo / 100;
            string[] longi = dLo.ToString("00.00").Split('.');
            if (longi.Length > 1)
            {
                return longi[0] + "° " + longi[1] + "' " + (((Convert.ToDouble(splitLongitud[1]) / 10000) * 60)).ToString("##") + "'' " + dirLongitud;
            }
            else
            {
                return "Posicion Error";
            }
          
           


        }


        private double obtenerLatitudN(string Latitud, string dirLatitud)
        {
            string[] splitLatitud = Latitud.Split('.');

            //Latitude
            Double dLat = Convert.ToDouble(splitLatitud[0]);
            dLat = dLat / 100;
            string[] lat = dLat.ToString("00.00").Split('.');

            if (lat.Length > 1)
            {
                dLat = Convert.ToDouble(lat[0]);
                double Min = Convert.ToDouble(lat[1]);
                double decMin = (Convert.ToDouble(splitLatitud[1])) / 10000;
                Min = (Min + decMin) / 60;
                dLat = dLat + Min;

                if (dirLatitud == "S")
                {
                    dLat = dLat * -1;
                }


                return dLat;
            }
            else
            {
                return 0.0;
            }

           


        }

        private double obtenerLongitudN(string Longitud, string dirLongitud)
        {
            string[] splitLongitud = Longitud.Split('.');

            //Longitude
            Double dLo = Convert.ToDouble(splitLongitud[0]);
            dLo = dLo / 100;
            string[] longi = dLo.ToString("00.00").Split('.');

            if (longi.Length > 1)
            {
                dLo = Convert.ToDouble(longi[0]);
                double Min = Convert.ToDouble(longi[1]);
                double decMin = (Convert.ToDouble(splitLongitud[1])) / 10000;
                Min = (Min + decMin) / 60;
                dLo = dLo + Min;

                if (dirLongitud == "W")
                {
                    dLo = dLo * -1;
                }


                return dLo;
            }
            else
            {
                return 0.0;

            }

        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            
            this.Controls.Add(visorNMEA);
            visorNMEA.BringToFront();
            visorNMEA.Show();
                       
        }

        

        #region Graficado del compas

        private void timer_graficadoRosa_Tick(object sender, EventArgs e)
        {
            LimpiarImagen();
            DibujarRosa();
            DibujarBarrido(rumbo);
            //DibujarBarrido(marcacion);
            
            //if (marcacion != rumbo)
            //{
            //    marcacion++;
            //    if (marcacion == 359)
            //    {
            //        marcacion = 0;
            //    }

            //}
            
            
            pictureBox_rosaManiobra.Image = bmMem;

        }
        void DibujarRosa()
        {

            int xText = 0;
            int yText = 0;

            pluma.Color = Color.Red;
            mem.DrawEllipse(pluma, 21, 12, 100, 100);

            //mem->DrawEllipse(pluma, centroX-3, centroY-5, 5, 5);


            brochaTexto.Color = Color.Red;
            for (int i = 0; i <= 315; i += 45)
            {

                ObtenerPuntoXMarcacionDistanciaPixel(centroX, centroY, i, 60, ref xText, ref yText);
                //ObtenerPuntoXMarcacionDistanciaPixel((this->pictureBox1->Width/2)-10,this->pictureBox1->Height/2, i, 115, xText, yText);
                mem.DrawString(i.ToString("000"), fuenteTexto, brochaTexto, xText-5, yText-5);
            }


        }

        void DibujarBarrido(int angulo)
        {
            int x = 10;
            int y = 10;
            //grafica la linea de demarcacion del Director de tiro y su leyenda
            ObtenerPuntoXMarcacionDistanciaPixel(centroX, centroY, angulo, 100, ref x, ref y);
            pluma.Color = Color.Blue;
            mem.DrawLine(pluma, centroX, centroY, x, y);
        }


        void ObtenerPuntoXMarcacionDistanciaPixel(int xinicio, int yinicio, double marcacion, double distancia, ref int xfinal, ref int yfinal)
        {
            double rad = System.Math.PI / 180;

            marcacion = transformacionAngular(marcacion) * rad;

            xfinal = (int)(xinicio + ((distancia) * (System.Math.Cos(marcacion))));
            yfinal = (int)(yinicio + ((distancia) * (System.Math.Sin(marcacion))));


        }

        public double transformacionAngular(double angulo)
        {
            double angTemp;

            angTemp = angulo - 90;

            return angTemp;
        }

        void LimpiarImagen()
        {
            mem.Clear(Color.Black);
        }
        #endregion 

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            menuItem4.Enabled = true;
            this.Controls.Add(canvas);
            canvas.BringToFront();
            canvas.Show();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            canvas.verPanelHerramientas();
        }


    }//fin de clase
}