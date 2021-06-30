using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class FCamionetas : Form
    {
        #region Inicializacion Form
        clsBase_Datos datos;
        bool agregarVehiculo;
        string formato = "0000";
        string pat;
        string codigoVehiculos;
        #endregion

        #region Metodos
        private void completarFiltroModelo()
        {
            cbModelo.Items.Clear();

            if (cbMarca.Text == "Todos")
            {
                cbModelo.Enabled = false;

                cbModelo.Items.Add("Todos");
                cbModelo.Items.Add("Avalanche");
                cbModelo.Items.Add("Blazer");
                cbModelo.Items.Add("Montana");
                cbModelo.Items.Add("Alaskan");
                cbModelo.Items.Add("Oroch");
                cbModelo.Items.Add("Bronco");
                cbModelo.Items.Add("F-100");
                cbModelo.Items.Add("F-150");
                cbModelo.Items.Add("Amarok");

            }
            else if (cbMarca.Text == "Chevrolet")
            {
                cbModelo.Items.Add("Avalanche");
                cbModelo.Items.Add("Blazer");
                cbModelo.Items.Add("Montana");
            }

            else if (cbMarca.Text == "Renault")
            {
                cbModelo.Items.Add("Alaskan");
                cbModelo.Items.Add("Oroch");
            }
            else if (cbMarca.Text == "Ford")
            {
                cbModelo.Items.Add("Bronco");
                cbModelo.Items.Add("F-100");
                cbModelo.Items.Add("F-150");
            }
            else if (cbMarca.Text == "Volskwagen")
            {
                cbModelo.Items.Add("Amarok");
            }

            cbModelo.SelectedIndex = 0;
        }
        #endregion
        public FCamionetas(clsBase_Datos conexion, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
            codigoVehiculos = codVehiculos.ToString(formato);
        }

        public FCamionetas(clsBase_Datos conexion, string patente, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            pat = patente;
            codigoVehiculos = codVehiculos.ToString(formato);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = cbMarca.SelectedIndex != -1 ? cbMarca.Text : "";
            string nuevoModelo = cbModelo.SelectedIndex != -1 ? cbModelo.Text : "";
            string nuevaGama = cbGama.SelectedIndex != -1 ? cbGama.Text : "";
            DateTime nuevaFechaFab = dtFechaFabricacion.Value.Date;
            DateTime nuevafechaCompra = dtFechaCompra.Value.Date;
            double nuevoPrecio = mtPrecioCosto.MaskCompleted ? Convert.ToDouble(mtPrecioCosto.Text) : 0;
            bool usado = checkUsado.Checked;
            bool cuatroXcuatro = rbCuatroXCuatro.Checked;
            string cuitDist = cbDistribuidores.SelectedItem.ToString().Substring(6, 11);
            string nuevaPatente = tPatente.Text.Trim().ToUpper();
            clsDistribuidores distribuidor = new clsDistribuidores(cuitDist, datos.getRazonSocial(cuitDist), datos.esDistribuidorInternacional(cuitDist));

            if (!clsVehiculos.patenteValida(nuevaPatente))
            {
                MessageBox.Show("Ingrese una patente valida", "Marca Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tPatente.Focus();
            }
            else if (nuevaMarca == "")
            {
                MessageBox.Show("Seleccione la Marca", "Marca Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoModelo == "")
            {
                MessageBox.Show("Seleccione un Modelo", "Modelo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevaGama == "")
            {
                MessageBox.Show("Seleccione una Gama", "Modelo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoPrecio == 0)
            {
                MessageBox.Show("Complete el Precio", "Precio Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtPrecioCosto.Focus();
            }
            else if (agregarVehiculo)
            {
                if (datos.existePatenteVehiculo(nuevaPatente))
                {
                    MessageBox.Show("La patente ingresada ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tPatente.Focus();
                }
                else
                {
                    datos.insertarCamioneta(nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, nuevafechaCompra, usado, nuevoPrecio, 45, cuatroXcuatro, codigoVehiculos, "Camioneta", nuevaPatente, distribuidor);
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                datos.modificarCamioneta(nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, nuevafechaCompra, usado, nuevoPrecio, 45, cuatroXcuatro, codigoVehiculos, "Camioneta",  nuevaPatente, distribuidor);
                DialogResult = DialogResult.OK;
            }
        }

        private void FCamionetas_Load(object sender, EventArgs e)
        {
            List<string> listaDistribuidores = datos.listarDistribuidores("");
            cbDistribuidores.Items.Clear();
            foreach (string cadena in listaDistribuidores)
            {
                cbDistribuidores.Items.Add(cadena);
            }
            if (agregarVehiculo)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                tPatente.Focus();
                tPatente.Text = "Ingrese patente...";
                cbMarca.SelectedIndex = 0;
                cbGama.SelectedIndex = 0;
                cbModelo.SelectedIndex = 0;
                dtFechaFabricacion.Value = DateTime.Today;
                mtPrecioCosto.Clear();
                checkUsado.Checked = false;
                cbDistribuidores.SelectedIndex = 0;
            }
            else
            {
                Text = "Modificar";
                bAceptar.Text = "Modificar";
                clsCamionetas camioneta = datos.datosCamionetas(pat);
                tPatente.Text = camioneta.PATENTE;
                tPatente.Enabled = false;
                cbMarca.Text = camioneta.MARCA;
                cbGama.Text = camioneta.GAMA;
                cbModelo.Text = camioneta.MODELO;
                dtFechaFabricacion.Value = camioneta.FECHAFABRICACION;
                dtFechaCompra.Value = camioneta.FECHACOMPRA;
                string formatoPrecio = "0000000.00";
                mtPrecioCosto.Text = Convert.ToString(camioneta.PRECIOCOSTO.ToString(formatoPrecio));
                checkUsado.Checked = camioneta.USADO;
                cbDistribuidores.Text = camioneta.DISTRIBUIDOR.ToString();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tPatente_Validating(object sender, CancelEventArgs e)
        {
            epPatente.Clear();
            if (!clsVehiculos.patenteValida(tPatente.Text.Trim()))
                epPatente.SetError(tPatente, "La patente no es valida. Complete correctamente la misma");
        }

        private void tPatente_MouseClick(object sender, MouseEventArgs e)
        {
            tPatente.Clear();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            completarFiltroModelo();
        }

        private void tPatente_MouseHover(object sender, EventArgs e)
        {
            ttipPatente.SetToolTip(tPatente, "Formato de patente: <AA123AA>");
        }

        private void mtPrecioCosto_MouseHover(object sender, EventArgs e)
        {
            ttipPrecio.SetToolTip(mtPrecioCosto, "Debe ingresar un precio mínimo de $1,00");
        }

        private void dtFechaFabricacion_ValueChanged(object sender, EventArgs e)
        {
            dtFechaCompra.MinDate = dtFechaFabricacion.Value;
        }
    }
}
