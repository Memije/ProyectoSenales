using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSenales
{
    public static class Configuracion
    {
        public static int[] frecA = { 700, 1000, 1000, 1200};
        public static int[] frecE = { 500, 800, 1300, 1500};
        public static int[] frecI = { 200, 400, 1400, 1800};
        public static int[] frecO = { 700, 900, 1200, 1400 };
        public static int[] frecU = { 400, 500, 1600, 1900 };

        public static double amplitud = 15.0;

        public static string puertoCOM = "COM4";
    }
}
