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

        #region Conexion
        clsBase_Datos datos;
        #endregion

        #region Metodos
        private void acutualizarVehiculos()
        {
            List<string> lista;
            string tipo_Vehiculo, marca, distribuidor, gama = string.Empty;
            bool Condicion, cuatroXcuatro = false;

            tipo_Vehiculo = cbFiltroTipo.Text;
            marca = cbFiltroMarca.Text;
            distribuidor = cbFiltroDistribuidor.Text;
            if (rbBase.Checked)
            {
                gama = rbBase.Text;
            }
            else if (rbMedia.Checked)
            {
                gama = rbMedia.Text;
            }
            else if (rbFull.Checked)
            {
                gama = rbFull.Text;
            }
            if (checkFiltroUsado.Checked)
            {
                Condicion = true;
            }
            else
            {
                Condicion = false;
            }
            if (cbFiltroTipo.Text == "Camioneta")
            {
                if (checkFiltro4x4.Checked)
                    cuatroXcuatro = true;
            }
            lista = datos.listarVehiculos(tipo_Vehiculo, marca, distribuidor, Condicion, cuatroXcuatro, gama);
            lbFiltroVehiculos.Items.Clear();
            foreach (string cadena in lista)
            {
                lbFiltroVehiculos.Items.Add(cadena);
            }
            actualizarCantidades(lista);

        }

        private void actualizarCantidades(List<string> lista)
        {
            lCantListadaVehiculos.Text = $"Cantidad Listado: {lista.Count}";
            lCantTotalVehiculos.Text = $"Cantidad Total: {datos.cantidadVehiculos()}";
        }
        #endregion

        public FConcesionaria()
        {
            InitializeComponent();
            datos = new clsBase_Datos();
        }

        private void miAgregarAutos_Click(object sender, EventArgs e)
        {
            FAutos FormAuto = new FAutos(datos); //parametro base de datos?
            


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
    }
}
