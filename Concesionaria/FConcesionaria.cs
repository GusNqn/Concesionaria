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
            if (datos.cantidadDistribuidores() > 0)
            {
                msAutos.Enabled = true;
                msCamioneta.Enabled = true;
            }
            else
            {
                msAutos.Enabled = false;
                msCamioneta.Enabled = false;
            }
        }
        private void completarComboDistribuidores()
        {
            List<string> listaDistribuidores = datos.listarDistribuidores("");
            cbFiltroDistribuidor.Items.Clear();
            cbFiltroDistribuidor.Items.Add("Todos");
            foreach (string cadena in listaDistribuidores)
            {
                cbFiltroDistribuidor.Items.Add(cadena);
            }
            cbFiltroDistribuidor.SelectedIndex = 0;
        }
        private void actualizarVehiculos()
        {
            List<string> lista;
            string tipo_Vehiculo, marca, distribuidor, gama = string.Empty;
            bool Condicion, cuatroXcuatro = false;

            tipo_Vehiculo = cbFiltroTipo.Text;
            marca = cbFiltroMarca.Text;
            if (cbFiltroDistribuidor.Text != "Todos")
            {
                distribuidor = cbFiltroDistribuidor.Text.Substring(6, 11);
            }
            else
            {
                distribuidor = "Todos";
            }
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
            FAutos FormAuto = new FAutos(datos, ++codigoVehiculos); 

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
                        string codigo = lbFiltroVehiculos.SelectedItem.ToString().Substring(8, 4);
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
            FCamionetas FormCamioneta = new FCamionetas(datos, ++codigoVehiculos);

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
                        string codigo = lbFiltroVehiculos.SelectedItem.ToString().Substring(8, 4);
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

        private void miModificarDistribuidor_Click(object sender, EventArgs e)
        {
            if (lbFiltroDistribuidores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un distribuidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbFiltroDistribuidores.Focus();
            }
            else
            {
                string cuitDistribuidor = lbFiltroDistribuidores.SelectedItem.ToString().Substring(6,11);
                FDistribuidores FormDistribuidores = new FDistribuidores(datos, cuitDistribuidor);
                if (FormDistribuidores.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Se ha modificado el distribuidor correctamete", "Modificacion existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDistribuidores();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la modificacion", "Modificacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
            if (cbFiltroTipo.Text == "Camioneta")
            {
                checkFiltro4x4.Enabled = true;
            }
            else
            {
                checkFiltro4x4.Enabled = false;
                checkFiltro4x4.Checked = false;
            }
        }

        private void cbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void cbFiltroDistribuidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void checkFiltroUsado_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void checkFiltro4x4_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void rbGamaTodos_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void rbBase_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void rbMedia_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void rbFull_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void FConcesionaria_Load(object sender, EventArgs e)
        {
            cbFiltroDistribuidor.SelectedIndex = 0;
            cbFiltroMarca.SelectedIndex = 0;
            cbFiltroTipo.SelectedIndex = 0;
        }

        private void miEliminarAutos_Click(object sender, EventArgs e)
        {
            if (lbFiltroVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Vehiculo a Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((cbFiltroTipo.Text == "Todos") || (cbFiltroTipo.Text == "Camioneta"))
                {
                    bool esAuto = datos.esAuto(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    if (!esAuto)
                    {
                        DialogResult eliminarCamioneta;
                        eliminarCamioneta = MessageBox.Show("Usted selecciono una Camioneta, ¿queria eliminarla?", "¿Eliminar Camioneta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (eliminarCamioneta == DialogResult.Yes)
                        {
                            datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                            MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo el Eliminado", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                        MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarVehiculos();
                    }
                }
                else
                {
                    datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarVehiculos();
                }
            }
        }

        private void miEliminarCamioneta_Click(object sender, EventArgs e)
        {
            if (lbFiltroVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Vehiculo a Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((cbFiltroTipo.Text == "Todos") || (cbFiltroTipo.Text == "Auto"))
                {
                    bool esAuto = datos.esAuto(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    if (esAuto)
                    {
                        DialogResult eliminarAuto;
                        eliminarAuto = MessageBox.Show("Usted selecciono un Auto, ¿queria eliminarlo?", "¿Eliminar Auto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (eliminarAuto == DialogResult.Yes)
                        {
                            datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                            MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo el Eliminado", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                        MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarVehiculos();
                    }
                }
                else
                {
                    datos.eliminarVehiculos(datos.buscarIndice(cbFiltroTipo.Text, lbFiltroVehiculos.SelectedIndex));
                    MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarVehiculos();
                }
            }
        }

        private void miEliminarDistribuidor_Click(object sender, EventArgs e)
        {
            int cantidadVehiculos;
            DialogResult verVehiculos;
            if (lbFiltroDistribuidores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Distribuidor a Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cuitDistribuidor = lbFiltroDistribuidores.SelectedItem.ToString().Substring(6, 11);
                cantidadVehiculos = datos.cantidadVehiculosDelDistribuidor(cuitDistribuidor);
                if (cantidadVehiculos > 0)
                {
                    verVehiculos = MessageBox.Show($"No se puede eliminar porque tiene {cantidadVehiculos} vehiculos asociados. \n ¿Desea ver los vehiculos en la Lista?", "¿Listar Vehiculos?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (verVehiculos == DialogResult.Yes)
                    {
                        cbFiltroTipo.SelectedIndex = 0;
                        cbFiltroMarca.SelectedIndex = 0;
                        if (rbTodos.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbTodos.Text, cbFiltroDistribuidor.SelectedIndex);
                        }
                        else if (rbNacional.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbNacional.Text, cbFiltroDistribuidor.SelectedIndex);
                        }
                        else if (rbInternacional.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbInternacional.Text, cbFiltroDistribuidor.SelectedIndex);
                        }
                        checkFiltroUsado.Checked = false;
                        checkFiltro4x4.Checked = false;
                        rbGamaTodos.Checked = true;
                        List<string> vehiculosDelDistribuidor = new List<string>();
                        vehiculosDelDistribuidor = datos.mostrarVehiculosDist(lbFiltroDistribuidores.Text.Substring(6, 11));
                        lbFiltroVehiculos.Items.Clear();
                        foreach (string cadena in vehiculosDelDistribuidor)
                        {
                            lbFiltroVehiculos.Items.Add(cadena);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se elimino el Distribuidor.", "Eliminado Cancelado", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (rbTodos.Checked)
                    {
                        datos.eliminarDistribuidor(datos.buscarIndiceDist(rbTodos.Text, lbFiltroDistribuidores.SelectedIndex));
                    }
                    else if (rbNacional.Checked)
                    {
                        datos.eliminarDistribuidor(datos.buscarIndiceDist(rbNacional.Text, lbFiltroDistribuidores.SelectedIndex));
                    }
                    else if (rbInternacional.Checked)
                    {
                        datos.eliminarDistribuidor(datos.buscarIndiceDist(rbInternacional.Text, lbFiltroDistribuidores.SelectedIndex));
                    }
                    MessageBox.Show($"Se elimino el Distribuidor.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDistribuidores();
                }
            }
        }
    }
}
