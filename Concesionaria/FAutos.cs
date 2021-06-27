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
    public partial class FAutos : Form
    {
        #region Inicializacion Form
        clsBase_Datos datos;
        bool agregarVehiculo;
        int codigoVehiculos;
        int cod;
        #endregion

        public FAutos(clsBase_Datos conexion, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            codigoVehiculos = codVehiculo;
            agregarVehiculo = true;
        }

        public FAutos(clsBase_Datos conexion, int codigo, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
            codigoVehiculos = codVehiculo;
        }

        private void FAutos_Load(object sender, EventArgs e)
        {
            cbDistribuidores.Items.Clear();
            cbDistribuidores.Items.Add(datos.listarDistribuidores(""));
            if (agregarVehiculo)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                cbMarca.SelectedIndex = 0;
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
                clsAutos auto = datos.datosAuto(cod);
                cbMarca.Text = auto.MARCA;
                cbModelo.Text = auto.MODELO;
                dtFechaFabricacion.Value = auto.FECHAFABRICACION;
                mtPrecioCosto.Text = Convert.ToString(auto.PRECIOCOSTO);
                checkUsado.Checked = auto.USADO;
                cbDistribuidores.Text = auto.DISTRIBUIDOR.ToString();
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = cbMarca.SelectedIndex != -1 ? cbMarca.Text : "";
            string nuevoModelo = cbModelo.SelectedIndex != -1 ? cbModelo.Text : "";
            DateTime nuevaFechaFab = dtFechaFabricacion.Value.Date;
            double nuevoPrecio = mtPrecioCosto.MaskCompleted ? Convert.ToDouble(mtPrecioCosto.Text) : 0;
            bool usado = checkUsado.Checked;
            string cuitDist = cbDistribuidores.SelectedItem.ToString().Substring(7, 11);
            clsDistribuidores distribuidor = new clsDistribuidores(cuitDist, datos.getRazonSocial(cuitDist), datos.esDistribuidorInternacional(cuitDist));
            
            if (nuevaMarca == "")
            {
                MessageBox.Show("Complete la Marca", "Marca Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoModelo == "")
            {
                MessageBox.Show("Complete el Modelo", "Modelo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoPrecio == 0)
            {
                MessageBox.Show("Complete el Precio", "Precio Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (agregarVehiculo)
            {
                datos.insertarAuto(nuevaMarca, nuevoModelo, nuevaFechaFab, usado, nuevoPrecio, 25, ++codigoVehiculos, "Auto", distribuidor);
                DialogResult = DialogResult.OK;
            }
            else
            {
                datos.modificarAuto(nuevaMarca, nuevoModelo, nuevaFechaFab, usado, nuevoPrecio, 25, codigoVehiculos, "Auto", distribuidor);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
