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
    public partial class Cap11e2Form : Form
    {
        public Cap11e2Form()
        {
            InitializeComponent();
        }

        private async void Mostrarbutton_Click(object sender, EventArgs e)
        {
            string Nombre, Ruta;

            Ruta = RutatextBox.Text;
            Nombre = NombretextBox.Text;
            try
            {
                using (StreamReader sr = new StreamReader(@"" + Ruta + "\\" + Nombre + ".txt"))
                {
                    String Texto = await sr.ReadToEndAsync();
                    ResultadolistBox.Items.Add(Texto);
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer archivo",ex.Message);
            }
        }
    }
}
