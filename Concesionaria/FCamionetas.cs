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
        int cod;
        int codigoVehiculo;
        #endregion

        public FCamionetas(clsBase_Datos conexion, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
            codigoVehiculo = codVehiculos;
        }

        public FCamionetas(clsBase_Datos conexion, int codigo, int codVehiculos)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
            codigoVehiculo = codVehiculos;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
