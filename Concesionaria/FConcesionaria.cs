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

        private void completarFiltroModelo()
        {
            cbFiltroModelo.Items.Clear();

            if ((cbFiltroTipo.Text == string.Empty) || (cbFiltroMarca.Text == string.Empty))
            {
                cbFiltroModelo.Enabled = false;
            }
            else if (cbFiltroTipo.Text == "Todos" && cbFiltroMarca.Text == "Todos")
            {
                cbFiltroModelo.Enabled = false;
            }
            else if (cbFiltroTipo.Text == "Todos")
            {
                cbFiltroModelo.Enabled = true;

                if (cbFiltroMarca.Text == "Chevrolet")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Agile");
                    cbFiltroModelo.Items.Add("Aveo");
                    cbFiltroModelo.Items.Add("Camaro");
                    cbFiltroModelo.Items.Add("Corsa Classic");
                    cbFiltroModelo.Items.Add("Onix");
                    cbFiltroModelo.Items.Add("Avalanche");
                    cbFiltroModelo.Items.Add("Blazer");
                    cbFiltroModelo.Items.Add("Montana");

                }
                else if (cbFiltroMarca.Text == "Renault")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Clio");
                    cbFiltroModelo.Items.Add("Fluence");
                    cbFiltroModelo.Items.Add("Kwid");
                    cbFiltroModelo.Items.Add("Logan");
                    cbFiltroModelo.Items.Add("Sandero");
                    cbFiltroModelo.Items.Add("Alaskan");
                    cbFiltroModelo.Items.Add("Oroch");
                }
                else if (cbFiltroMarca.Text == "Ford")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Fiesta");
                    cbFiltroModelo.Items.Add("Focus");
                    cbFiltroModelo.Items.Add("Ka");
                    cbFiltroModelo.Items.Add("Mondeo");
                    cbFiltroModelo.Items.Add("Mustang");
                    cbFiltroModelo.Items.Add("Bronco");
                    cbFiltroModelo.Items.Add("F-100");
                    cbFiltroModelo.Items.Add("F-150");

                }
                else if (cbFiltroMarca.Text == "Volskwagen")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Fox");
                    cbFiltroModelo.Items.Add("Gol");
                    cbFiltroModelo.Items.Add("Golf");
                    cbFiltroModelo.Items.Add("Passat");
                    cbFiltroModelo.Items.Add("Polo");
                    cbFiltroModelo.Items.Add("Amarok");
                }

                cbFiltroModelo.SelectedIndex = 0;

            }
            else if (cbFiltroMarca.Text == "Todos")
            {
                cbFiltroModelo.Enabled = true;

                if (cbFiltroTipo.Text == "Auto")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Agile");
                    cbFiltroModelo.Items.Add("Aveo");
                    cbFiltroModelo.Items.Add("Camaro");
                    cbFiltroModelo.Items.Add("Corsa Classic");
                    cbFiltroModelo.Items.Add("Onix");
                    cbFiltroModelo.Items.Add("Clio");
                    cbFiltroModelo.Items.Add("Fluence");
                    cbFiltroModelo.Items.Add("Kwid");
                    cbFiltroModelo.Items.Add("Logan");
                    cbFiltroModelo.Items.Add("Sandero");
                    cbFiltroModelo.Items.Add("Fiesta");
                    cbFiltroModelo.Items.Add("Focus");
                    cbFiltroModelo.Items.Add("Ka");
                    cbFiltroModelo.Items.Add("Mondeo");
                    cbFiltroModelo.Items.Add("Mustang");
                    cbFiltroModelo.Items.Add("Fox");
                    cbFiltroModelo.Items.Add("Gol");
                    cbFiltroModelo.Items.Add("Golf");
                    cbFiltroModelo.Items.Add("Passat");
                    cbFiltroModelo.Items.Add("Polo");
                }
                else if (cbFiltroTipo.Text == "Camioneta")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Avalanche");
                    cbFiltroModelo.Items.Add("Blazer");
                    cbFiltroModelo.Items.Add("Montana");
                    cbFiltroModelo.Items.Add("Alaskan");
                    cbFiltroModelo.Items.Add("Oroch");
                    cbFiltroModelo.Items.Add("Bronco");
                    cbFiltroModelo.Items.Add("F-100");
                    cbFiltroModelo.Items.Add("F-150");
                    cbFiltroModelo.Items.Add("Amarok");
                }

                cbFiltroModelo.SelectedIndex = 0;
            }
            else
            {
                cbFiltroModelo.Enabled = true;

                if (cbFiltroMarca.Text == "Chevrolet" && cbFiltroTipo.Text == "Auto")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Agile");
                    cbFiltroModelo.Items.Add("Aveo");
                    cbFiltroModelo.Items.Add("Camaro");
                    cbFiltroModelo.Items.Add("Corsa Classic");
                    cbFiltroModelo.Items.Add("Onix");
                }
                else if (cbFiltroMarca.Text == "Chevrolet" && cbFiltroTipo.Text == "Camioneta")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Avalanche");
                    cbFiltroModelo.Items.Add("Blazer");
                    cbFiltroModelo.Items.Add("Montana");
                }
                else if (cbFiltroMarca.Text == "Renault" && cbFiltroTipo.Text == "Auto")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Clio");
                    cbFiltroModelo.Items.Add("Fluence");
                    cbFiltroModelo.Items.Add("Kwid");
                    cbFiltroModelo.Items.Add("Logan");
                    cbFiltroModelo.Items.Add("Sandero");
                }
                else if (cbFiltroMarca.Text == "Renault" && cbFiltroTipo.Text == "Camioneta")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Alaskan");
                    cbFiltroModelo.Items.Add("Oroch");
                }
                if (cbFiltroMarca.Text == "Ford" && cbFiltroTipo.Text == "Auto")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Fiesta");
                    cbFiltroModelo.Items.Add("Focus");
                    cbFiltroModelo.Items.Add("Ka");
                    cbFiltroModelo.Items.Add("Mondeo");
                    cbFiltroModelo.Items.Add("Mustang");
                }
                else if (cbFiltroMarca.Text == "Ford" && cbFiltroTipo.Text == "Camioneta")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Bronco");
                    cbFiltroModelo.Items.Add("F-100");
                    cbFiltroModelo.Items.Add("F-150");
                }
                if (cbFiltroMarca.Text == "Volskwagen" && cbFiltroTipo.Text == "Auto")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Fox");
                    cbFiltroModelo.Items.Add("Gol");
                    cbFiltroModelo.Items.Add("Golf");
                    cbFiltroModelo.Items.Add("Passat");
                    cbFiltroModelo.Items.Add("Polo");
                }
                else if (cbFiltroMarca.Text == "Volskwagen" && cbFiltroTipo.Text == "Camioneta")
                {
                    cbFiltroModelo.Items.Add("Todos");
                    cbFiltroModelo.Items.Add("Amarok");
                }

                cbFiltroModelo.SelectedIndex = 0;
            }
        }
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
            string tipo_Vehiculo, marca, distribuidor, modelo, gama = string.Empty;
            bool usado, nuevo;
            bool cuatroXcuatro = false;
            bool tracSimple = false;

            tipo_Vehiculo = cbFiltroTipo.Text;
            marca = cbFiltroMarca.Text;
            modelo = cbFiltroModelo.Text;
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
            usado = checkFiltroUsado.Checked;
            nuevo = checkFiltroNuevo.Checked;
            if (cbFiltroTipo.Text == "Camioneta")
            {
                cuatroXcuatro = checkFiltro4x4.Checked;
                tracSimple = checkFiltroTraccionSimple.Checked;
            }
            lista = datos.listarVehiculos(tipo_Vehiculo, marca, modelo, distribuidor, usado, nuevo, cuatroXcuatro, tracSimple, gama);
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

        private void FConcesionaria_Load(object sender, EventArgs e)
        {
            cbFiltroDistribuidor.SelectedIndex = 0;
            cbFiltroTipo.SelectedIndex = 0;
            cbFiltroMarca.SelectedIndex = 0;
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
                    bool esAuto = datos.esAuto(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(15, 7)));
                    if (esAuto)
                    {
                        string patente = lbFiltroVehiculos.SelectedItem.ToString().Substring(15, 7);
                        FAutos FormAuto = new FAutos(datos, patente, codigoVehiculos);
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
                MessageBox.Show("Se ha cargado la camioneta correctamete", "Carga existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    bool esAuto = datos.esAuto(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(15, 7)));
                    if (!esAuto)
                    {
                        string patente = lbFiltroVehiculos.SelectedItem.ToString().Substring(15, 7);
                        FCamionetas FormCamioneta = new FCamionetas(datos, patente, codigoVehiculos);
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
                    bool esAuto = datos.esAuto(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                    if (!esAuto)
                    {
                        DialogResult eliminarCamioneta;
                        eliminarCamioneta = MessageBox.Show("Usted selecciono una Camioneta, ¿queria eliminarla?", "¿Eliminar Camioneta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (eliminarCamioneta == DialogResult.Yes)
                        {
                            datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                            MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo el proceso de eliminación", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                        MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarVehiculos();
                    }
                }
                else
                {
                    datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
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
                    bool esAuto = datos.esAuto(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                    if (esAuto)
                    {
                        DialogResult eliminarAuto;
                        eliminarAuto = MessageBox.Show("Usted selecciono un Auto, ¿queria eliminarlo?", "¿Eliminar Auto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (eliminarAuto == DialogResult.Yes)
                        {
                            datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                            MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actualizarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show("Se ha cancelado el proceso de eliminación", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(13, 7)));
                        MessageBox.Show("Se elimino el Vehiculo", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarVehiculos();
                    }
                }
                else
                {
                    
                    datos.eliminarVehiculos(datos.buscarIndice(lbFiltroVehiculos.SelectedItem.ToString().Substring(8,4)));
                    
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
                    verVehiculos = MessageBox.Show($"No se puede eliminar \"{datos.getRazonSocial(cuitDistribuidor)}\" porque tiene {cantidadVehiculos} vehiculos asociados. \n ¿Desea ver los vehiculos en la Lista?", "¿Listar Vehiculos?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (verVehiculos == DialogResult.Yes)
                    {
                        cbFiltroTipo.SelectedIndex = 0;
                        cbFiltroMarca.SelectedIndex = 0;
                        if (rbTodos.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbTodos.Text, cbFiltroDistribuidor.SelectedIndex) + 1;
                        }
                        else if (rbNacional.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbNacional.Text, cbFiltroDistribuidor.SelectedIndex) + 1;
                        }
                        else if (rbInternacional.Checked)
                        {
                            cbFiltroDistribuidor.SelectedIndex = datos.buscarIndiceDist(rbInternacional.Text, cbFiltroDistribuidor.SelectedIndex) + 1;
                        }
                        checkFiltroUsado.Checked = true;
                        checkFiltroNuevo.Checked = true;
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
                        MessageBox.Show($"No se elimino el Distribuidor", "Eliminar Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Se elimino el Distribuidor", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDistribuidores();
                    completarComboDistribuidores();
                }
            }
        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
            if (cbFiltroTipo.Text == "Camioneta")
            {
                checkFiltro4x4.Enabled = true;
                checkFiltro4x4.Checked = true;
                checkFiltroTraccionSimple.Enabled = true;
                checkFiltroTraccionSimple.Checked = true;
            }
            else
            {
                checkFiltro4x4.Enabled = false;
                checkFiltro4x4.Checked = false;
                checkFiltroTraccionSimple.Enabled = false;
                checkFiltroTraccionSimple.Checked = false;
            }
            completarFiltroModelo();
        }

        private void checkFiltroNuevo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
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

        private void cbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
            completarFiltroModelo();
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

        private void checkFiltroTraccionSimple_CheckedChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }

        private void cbFiltroModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVehiculos();
        }
    }
}
