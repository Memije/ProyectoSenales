using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSenales
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
            letraAPrimerInf.Text = Configuracion.frecA[0].ToString();
            letraAPrimerSup.Text = Configuracion.frecA[1].ToString();
            letraASegundoInf.Text = Configuracion.frecA[2].ToString();
            letraASegundoSup.Text = Configuracion.frecA[3].ToString();

            puertoTextBox.Text = Configuracion.puertoCOM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuracion.frecA[0] = int.Parse(letraAPrimerInf.Text);
            Configuracion.frecA[1] = int.Parse(letraAPrimerSup.Text);
            Configuracion.frecA[2] = int.Parse(letraASegundoInf.Text);
            Configuracion.frecA[3] = int.Parse(letraASegundoSup.Text);            
        }
    }
}
