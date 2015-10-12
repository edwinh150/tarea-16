using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea11y12
{
    public partial class Cap12e1Form : Form
    {
        double numero, resultado = 1;

        public Cap12e1Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {

            numero = Convert.ToDouble(NumerotextBox.Text);

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            ResultadolistBox.Items.Add(resultado);
        }
    }
}
