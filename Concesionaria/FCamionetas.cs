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
        string cod;
        string codigoVehiculos;
        #endregion

        public FCamionetas(clsBase_Datos conexion, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
            codigoVehiculos = codVehiculos.ToString(formato);
        }

        public FCamionetas(clsBase_Datos conexion, string codigo, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
            codigoVehiculos = codVehiculos.ToString(formato);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = cbMarca.SelectedIndex != -1 ? cbMarca.Text : "";
            string nuevoModelo = cbModelo.SelectedIndex != -1 ? cbModelo.Text : "";
            DateTime nuevaFechaFab = dtFechaFabricacion.Value.Date;
            double nuevoPrecio = mtPrecioCosto.MaskCompleted ? Convert.ToDouble(mtPrecioCosto.Text) : 0;
            bool usado = checkUsado.Checked;
            bool cuatroXcuatro = rbCuatroXCuatro.Checked;
            string cuitDist = cbDistribuidores.SelectedItem.ToString().Substring(6, 11);
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
                datos.insertarCamioneta(nuevaMarca, nuevoModelo, nuevaFechaFab, usado, nuevoPrecio, 35,cuatroXcuatro, codigoVehiculos, "Camioneta", distribuidor);
                DialogResult = DialogResult.OK;
            }
            else
            {
                datos.modificarCamioneta(nuevaMarca, nuevoModelo, nuevaFechaFab, usado, nuevoPrecio, 35,cuatroXcuatro, codigoVehiculos, "Camioneta", distribuidor);
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
                clsCamionetas camioneta = datos.datosCamionetas(cod);
                cbMarca.Text = camioneta.MARCA;
                cbModelo.Text = camioneta.MODELO;
                dtFechaFabricacion.Value = camioneta.FECHAFABRICACION;
                string formatoPrecio = "000000000";
                mtPrecioCosto.Text = Convert.ToString(camioneta.PRECIOCOSTO.ToString(formatoPrecio));
                checkUsado.Checked = camioneta.USADO;
                cbDistribuidores.Text = camioneta.DISTRIBUIDOR.ToString();
            }
        }
    }
}
