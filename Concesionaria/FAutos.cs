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
        int cod;
        #endregion

        public FAutos(clsBase_Datos conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
        }

        public FAutos(clsBase_Datos conexion, int codigo)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
        }

        private void FAutos_Load(object sender, EventArgs e)
        {
            if (agregarVehiculo)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                cbMarca.SelectedIndex = 0;
                cbModelo.SelectedIndex = 0;
                dtFechaFabricacion.Value = DateTime.Today;
                mtPrecioCosto.Clear();
                checkUsado.Checked = false;
            }
            else
            {
                Text = "Modificar";
                bAceptar.Text = "Modificar";

            }
        }
    }
}
