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
        string codigoVehiculos;
        string formato = "0000";
        string cod;
        #endregion

        public FAutos(clsBase_Datos conexion, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            codigoVehiculos = codVehiculo.ToString(formato);
            agregarVehiculo = true;
        }

        public FAutos(clsBase_Datos conexion, string codigo, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
            codigoVehiculos = codVehiculo.ToString(formato);
        }

        private void FAutos_Load(object sender, EventArgs e)
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
                cbGama.SelectedIndex = 0;
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
                cbGama.Text = auto.GAMA;
                dtFechaFabricacion.Value = auto.FECHAFABRICACION;
                string formatoPrecio = "000000000";
                mtPrecioCosto.Text = Convert.ToString(auto.PRECIOCOSTO.ToString(formatoPrecio));
                checkUsado.Checked = auto.USADO;
                cbDistribuidores.Text = auto.DISTRIBUIDOR.ToString();
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = cbMarca.SelectedIndex != -1 ? cbMarca.Text : "";
            string nuevaGama = cbGama.SelectedIndex != -1 ? cbGama.Text : "";
            string nuevoModelo = cbModelo.SelectedIndex != -1 ? cbModelo.Text : "";
            DateTime nuevaFechaFab = dtFechaFabricacion.Value.Date;
            double nuevoPrecio = mtPrecioCosto.MaskCompleted ? Convert.ToDouble(mtPrecioCosto.Text) : 0;
            bool usado = checkUsado.Checked;
            string tipoAuto = "Auto";
            int ganancia = 25;
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

                datos.insertarAuto(nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, usado, nuevoPrecio, ganancia, codigoVehiculos, tipoAuto, distribuidor);
                DialogResult = DialogResult.OK;
            }
            else
            {
                datos.modificarAuto(nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, usado, nuevoPrecio, 25, codigoVehiculos, "Auto", distribuidor);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
