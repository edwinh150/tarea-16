using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11y12
{
    public partial class Cap11e3Form : Form
    {
        public Cap11e3Form()
        {
            InitializeComponent();
        }

        private void Copiarbutton_Click(object sender, EventArgs e)
        {
            string Nombre, RutaNueva, RutaActual;

            Nombre = NombretextBox.Text + ".txt";
            RutaActual = @"" + RutatextBox.Text;
            RutaNueva = @"" + NuevaRutatextBox.Text;

            string rutaArchivo = RutaActual + "\\" + Nombre;

            string rutaNueva = RutaNueva + "\\" + Nombre;

            if (!Directory.Exists(RutaNueva))
            {
                Directory.CreateDirectory(RutaNueva);
            }

            File.Copy(rutaArchivo, rutaNueva, true);

            if (Directory.Exists(RutaActual))
            {
                string[] files = Directory.GetFiles(RutaActual);
                MessageBox.Show("Copiado...");
            }
            else
            {
                MessageBox.Show("la ruta no existe!");
            }
        }
    }
}
