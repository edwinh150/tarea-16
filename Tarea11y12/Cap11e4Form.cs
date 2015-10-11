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
    public partial class Cap11e4Form : Form
    {
        public Cap11e4Form()
        {
            InitializeComponent();
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            string Nombre, Ruta;

            Ruta = RutatextBox.Text;
            Nombre = NombretextBox.Text;

            if (File.Exists(@"" + Ruta + "\\" + Nombre + ".txt"))
            {
                if (MessageBox.Show("desea borrarlo?", "Borrar Archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    try
                    {
                        File.Delete(@"" + Ruta + "\\" + Nombre + ".txt");
                        MessageBox.Show("Eliminado Correctamente.");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Archivo no Encontrado.");
            }
        }
    }
}
