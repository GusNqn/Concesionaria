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
        clsBase_Datos Datos;
        public FConcesionaria()
        {
            InitializeComponent();
            Datos = new clsBase_Datos();
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

        private void miAgregarAutos_Click(object sender, EventArgs e)
        {
            FAutos FormAuto = new FAutos(); //parametro base de datos?
            
            if (FormAuto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha cargado el auto correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void miModificarAutos_Click(object sender, EventArgs e)
        {
            FAutos FormAutos = new FAutos(); //parametro base de datos?

            if (FormAutos.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha modificado los datos del auto correctamente", "Modificacion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha cacelado la modificacion", "Modificacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
