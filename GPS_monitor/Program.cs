using System;

using System.Collections.Generic;
using System.Windows.Forms;

namespace GPS_monitor
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new Form_ppal());
        }
    }
}