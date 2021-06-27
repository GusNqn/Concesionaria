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
        #endregion

        public FCamionetas(clsBase_Datos conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
        }

        public FCamionetas(clsBase_Datos conexion, int codigo)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            cod = codigo;
        }
    }
}
