using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ProyectoSenales
{
    class Muestra
    {
        public float numMuestra { get; set; }        
        public Complex complejo { get; set; }

        public Muestra(float numMuestra, Complex complejo)
        {
            this.numMuestra = numMuestra;
            this.complejo = complejo;            
        }

        public override string ToString()
        {
            return $"Muestra: {numMuestra}, Magnitud: {complejo.Magnitude}";
        }
    }    
}
