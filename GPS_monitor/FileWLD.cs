using System;

using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;



namespace GPS_monitor
{

    public class FileWLD : IComparable<FileWLD>

    {
        string rutaWLD;
        string rutaImg;
        string nombreGeoImagen;

        double lat1;
        double lon1;

        double lat2;
        double lon2;

        double lat3;
        double lon3;

        double lat4;
        double lon4;

        int anchoIMG;
        int altoIMG;

        //variables del world file
        double deltaLongitud;
        double deltaLatitud;
        double rotacionX;
        double rotacionY;
        double longitudEsquina;
        double latitudEsquina;

        double factorTamaño; //((altoImagen * delta lat) * (anchoImagen * deltaLong))

         public double get_deltaLongitud()
        {
            return deltaLongitud;
        }

        public double get_deltaLatitud()
        {
            return deltaLatitud;
        }

        public double get_rotacionX()
        {
            return rotacionX;
        }

        public double get_rotacionY()
        {
            return rotacionY;
        }

        public double get_longitudEsquina()
        {
            return longitudEsquina;
        }

        public double get_latitudEsquina()
        {
            return latitudEsquina;
        }
        public double get_factorEscala()
        {
            return factorTamaño;
        }



        public int CompareTo(FileWLD other)
        {
            // The temperature comparison depends on the comparison of the
            // the underlying Double values. Because the CompareTo method is
            // strongly typed, it is not necessary to test for the correct
            // object type.
            return factorTamaño.CompareTo(other.factorTamaño);
        }




       public FileWLD()
        {
            rutaWLD = "";
            rutaImg = "";

            lat1 = 0.0;
            lon1 = 0.0;

            lat2 = 0.0;
            lon2 = 0.0;

            lat3 = 0.0;
            lon3 = 0.0;

            lat4 = 0.0;
            lon4 = 0.0;


            anchoIMG = 0;
            altoIMG = 0; 

            //double extencionLatitud;
            //double extensionLongitud;

            deltaLongitud = 0.0;
            deltaLatitud = 0.0;
            rotacionX = 0.0;
            rotacionY = 0.0;
            longitudEsquina = 0.0;
            latitudEsquina = 0.0;

          
        }

      public FileWLD(string rutawdl, string rutaimg, double deltalat, double deltalon, double rotx, double roty, double longitudesquina, double latitudesquina, int imgAlto, int imgAncho)
        {

            rutaWLD = rutawdl;
            rutaImg = rutaimg;


            deltaLongitud = deltalon;
            deltaLatitud = deltalat;
            rotacionX = rotx;
            rotacionY = roty;
            longitudEsquina = longitudesquina;
            latitudEsquina = latitudesquina;

            anchoIMG = imgAncho;
            altoIMG = imgAlto;

            obtenerBoundingBox();
            obtenerFactorTamaño();
            obtenerNombreImagen();



        }


        private void obtenerBoundingBox()
        {
            lat4 = latitudEsquina;
            lon4 = longitudEsquina;

            lat1 = latitudEsquina + (altoIMG * deltaLatitud);
            lon1 = lon4;

            lat2 = lat1;
            lon2 = longitudEsquina + (anchoIMG * deltaLongitud);

            lat3 = latitudEsquina;
            lon3 = lon2;


        }

        private void obtenerFactorTamaño()
        {
            factorTamaño = (Math.Abs(lat1) - Math.Abs(lat4)) * 60;
        }

        public bool ConsultaEspacial_dentroDe(double latitud, double longitud)
        {
            double latActual = Math.Abs(latitud);
            double lonActual = Math.Abs(longitud);

            double latInferior = Math.Abs(lat4);
            double latSuperior = Math.Abs(lat1);

            double lonInferior = Math.Abs(lon3);
            double lonSuperior = Math.Abs(lon4);



            if (latActual > latInferior && latActual < latSuperior)
            {
                if (lonActual > lonInferior && lonActual < lonSuperior)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string get_rutaImagenWDL()
        {
            return rutaImg;
        }

        private void obtenerNombreImagen()
        {
            string[] splitRutaImg = rutaImg.Split('\\');
            nombreGeoImagen = splitRutaImg[splitRutaImg.Length - 1];

        }

        public string get_nombreGeoImagen()
        {
            return nombreGeoImagen;
        }



    }//fin de clase
}
