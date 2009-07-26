using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GPS_monitor
{
    public partial class VisorTramasNMEA : UserControl
    {
        bool estadoVisor;
      

        public VisorTramasNMEA()
        {
            InitializeComponent();
            estadoVisor = false;
            
            

           
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            estadoVisor = true;
            listBox_visorTramasNMEA0183.Items.Clear();

        }

        private void button_parar_Click(object sender, EventArgs e)
        {
            estadoVisor = false;

        }
        public void set_DatosNMEAVisor(string dato)
        {
            listBox_visorTramasNMEA0183.Items.Add(dato);
            if (listBox_visorTramasNMEA0183.Items.Count > 10)
            {
                listBox_visorTramasNMEA0183.TopIndex = listBox_visorTramasNMEA0183.Items.Count - 4;
            }
        }

        public bool get_estadoNMEAVisor()
        {
            return estadoVisor;
        }





    }//fin de clase
}
