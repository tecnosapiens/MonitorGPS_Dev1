using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace GPS_monitor
{

    public partial class ConfiguraPuerto : UserControl
    {
        PuertoSerial puerto;

        public ConfiguraPuerto(PuertoSerial port)
        {
            InitializeComponent();
            inicializarCombos();
            inicializarPuertos();
            puerto = port;
        }

        void inicializarCombos()
        {
            comboBox_bitParada.Text = "1";
            comboBox_bitsDatos.Text = "8";
            comboBox_paridad.Text = "Ninguno";
            comboBox_ptoComunicaciones.Text = "COM1";
            comboBox_velocidadPuerto.Text = "4800";
            comboBox_tiempo.Text = "1000";
        }


        void inicializarPuertos()
        {


            try
            {
                // Se obtiene la lista de los puertos disponibles en el equipo
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();


                // se borra la lista del comboBox
                 comboBox_ptoComunicaciones.Items.Clear();  


                // Agrega los nombres de los puertos disponibles al comboBox del dialogo
                foreach (string port in ports)
                {
                    comboBox_ptoComunicaciones.Items.Add(port);


                }
                comboBox_ptoComunicaciones.Text = "COM1";


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }


        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            puerto.setPuertoSerial(comboBox_ptoComunicaciones.Text,
                                                        comboBox_bitParada.Text,
                                                        comboBox_bitsDatos.Text,
                                                        comboBox_paridad.Text,
                                                        comboBox_velocidadPuerto.Text,
                                                        comboBox_tiempo.Text);
            this.Dispose();

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        

    }//fin de clase
}
