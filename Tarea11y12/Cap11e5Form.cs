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
    public partial class Cap11e5Form : Form
    {
        public Cap11e5Form()
        {
            InitializeComponent();
        }

        private void Copiarbutton_Click(object sender, EventArgs e)
        {
            string Nombre, Ruta, NuevoNombre;

            Nombre = NombretextBox.Text;
            Ruta = RutatextBox.Text;
            NuevoNombre = NuevoNombretextBox.Text;
            File.Move(@"" + Ruta + "\\" + Nombre + ".txt", @"" + Ruta + "\\" + NuevoNombre + ".txt");
            MessageBox.Show("Nombre Cambiado Correctamente.");
        }
    }
}
