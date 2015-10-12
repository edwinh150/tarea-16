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
    public partial class Capitulos11y12 : Form
    {
        public Capitulos11y12()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cap11e1Form Cap111 = new Cap11e1Form();

            Cap111.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cap11e2Form Cap112 = new Cap11e2Form();

            Cap112.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cap11e3Form Cap113 = new Cap11e3Form();

            Cap113.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cap11e4Form Cap114 = new Cap11e4Form();

            Cap114.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap11e5Form Cap115 = new Cap11e5Form();

            Cap115.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cap12e1Form Cap121 = new Cap12e1Form();

            Cap121.Show();
        }
    }
}
