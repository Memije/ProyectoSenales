using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSenales
{
    public static class Configuracion
    {
        public static int[] frecA = { 100, 300, 1700, 1900};
        public static int[] frecE = { 150, 400, 600, 800};
        public static int[] frecI = { 200, 400, 2000, 2200 };
        public static int[] frecO = { 200, 400, 1000, 1100 };
        public static int[] frecU = { 300, 400, 1000, 1100 };

        public static double[] amplitud = { 0.0, 0.0 };

        public static string puertoCOM = "COM3";
    }
}
