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
    public partial class Cap11e1Form : Form
    {
        MemoryStream ms = new MemoryStream(30);
        byte[] buffer = new byte[30];
        string Datos;

        public Cap11e1Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            Datos = DatostextBox.Text;

            ms.Write(ASCIIEncoding.ASCII.GetBytes(Datos), 0, Datos.Length);
            ms.Seek(0, SeekOrigin.Begin);

            ms.Read(buffer, 0, Datos.Length);

            ResultadolistBox.Items.Add(ASCIIEncoding.ASCII.GetString(buffer));
            ms.Close();
        }
    }
}
