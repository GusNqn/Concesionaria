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
        #region InicializacionForm
        clsBase_Datos datos;
        int codigoVehiculos;
        #endregion
        #region Metodos

        private void actualizarDistribuidores()
        {
            List<string> lista;
            string procedencia = "";
            if (rbTodos.Checked)
            {
                procedencia = "Todos";
            }
            else if (rbNacional.Checked)
            {
                procedencia = "Nacional";
            }
            else if (rbInternacional.Checked)
            {
                procedencia = "Internacional";
            }

            lista = datos.listarDistribuidores(procedencia);
            lbFiltroDistribuidores.Items.Clear();
            foreach (string cadena in lista)
            {
                lbFiltroDistribuidores.Items.Add(cadena);
            }
            ActualizarCantidadesDistribuidores(lista);
        }
        private void ActualizarCantidadesDistribuidores(List<string> lista)
        {
            lCantListadoDistribuidores.Text = $"Cantidad Listado: {lista.Count}";
            lCantidadTotalDistribuidores.Text = $"Cantidad Total: {datos.cantidadDistribuidores()}";
        }
        private void completarComboDistribuidores()
        {
            List<string> listaDistribuidores = datos.listarDistribuidores("");
            cbFiltroDistribuidor.Items.Clear();
            foreach (string cadena in listaDistribuidores)
            {
                cbFiltroDistribuidor.Items.Add(cadena);
            }
        }
        private void actualizarVehiculos()
        {
            List<string> lista;
            string tipo_Vehiculo, marca, distribuidor, gama = string.Empty;
            bool Condicion, cuatroXcuatro = false;

            tipo_Vehiculo = cbFiltroTipo.Text;
            marca = cbFiltroMarca.Text;
            distribuidor = cbFiltroDistribuidor.Text.Substring(7,11);
            MessageBox.Show($"Mostarme el cuit {distribuidor}");
            if (rbGamaTodos.Checked)
            {
                gama = rbTodos.Text;
            }
            else if (rbBase.Checked)
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
            if (checkFiltroUsado.Checked) //NO PODEMOS PASAR EL CHECKBOX Y YA? En vez de crear booleanos(Lo mismo 4x4)
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
            actualizarCantidadesVehiculos(lista);

        }

        private void actualizarCantidadesVehiculos(List<string> lista)
        {
            lCantListadaVehiculos.Text = $"Cantidad Listado: {lista.Count}";
            lCantTotalVehiculos.Text = $"Cantidad Total: {datos.cantidadVehiculos()}";
        }
        #endregion

        public FConcesionaria()
        {
            InitializeComponent();
            datos = new clsBase_Datos();
            codigoVehiculos = -1;
        }

        private void miAgregarAutos_Click(object sender, EventArgs e)
        {
            FAutos FormAuto = new FAutos(datos, codigoVehiculos); 

            if (FormAuto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha cargado el auto correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarVehiculos();            
            }
            else
            {
                MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void miModificarAutos_Click(object sender, EventArgs e)
        {
            if (lbFiltroVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((cbFiltroTipo.Text == "Todos") || (cbFiltroTipo.Text == "Auto"))
                {
                    bool esAuto = datos.esAuto(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    if (esAuto)
                    {
                        int codigo = Convert.ToInt32(lbFiltroVehiculos.SelectedItem.ToString().Substring(9, 4));
                        FAutos FormAuto = new FAutos(datos, codigo, codigoVehiculos);
                        if (FormAuto.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Se ha modificado el auto correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted a seleccionado un auto de la lista pero intenta modificar una camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbFiltroVehiculos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usted a seleccionado un auto de la lista pero intenta modificar una camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbFiltroVehiculos.Focus();
                }
            }
        }

        private void miAgregarCamioneta_Click(object sender, EventArgs e)
        {
            FCamionetas FormCamioneta = new FCamionetas(datos, codigoVehiculos);

            if (FormCamioneta.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha cargado el auto correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarVehiculos();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void miModificarCamioneta_Click(object sender, EventArgs e)
        {
            if (lbFiltroVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((cbFiltroTipo.Text == "Todos") ||  (cbFiltroTipo.Text == "Camioneta"))
                {
                    bool esAuto = datos.esAuto(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    if (!esAuto)
                    {
                        int codigo = Convert.ToInt32(lbFiltroVehiculos.SelectedItem.ToString().Substring(9, 4));
                        FCamionetas FormCamioneta = new FCamionetas(datos, codigo, codigoVehiculos);
                        if (FormCamioneta.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Se ha modificado la camioneta correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted a seleccionado un auto de la lista pero intenta modificar una camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbFiltroVehiculos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usted a seleccionado un auto de la lista pero intenta modificar una camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbFiltroVehiculos.Focus();
                }
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

        private void miAgregarDistribuidor_Click(object sender, EventArgs e)
        {
            FDistribuidores FormDistri = new FDistribuidores(datos);

            if (FormDistri.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha cargado el distribuidor correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarDistribuidores();
                completarComboDistribuidores();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la carga", "Carga cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void rbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            actualizarDistribuidores();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            actualizarDistribuidores();
        }

        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {
            actualizarDistribuidores();
        }
    }
}
