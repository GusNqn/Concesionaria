using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcFechas;

namespace Concesionaria
{
    public partial class FConcesionaria : Form
    {
        public FConcesionaria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea cerrar la aplicacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto diseñado por: \n\n - Lucas Boccaccini \n - Juan Esteban Schmidt \n - Gustavo Seguín ", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miAgregarAutoNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
