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
        clsBase_Datos datos;
        bool agregarVehiculo;

        public FAutos(clsBase_Datos conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = true;
        }

        private void FAutos_Load(object sender, EventArgs e)
        {
            if (agregarVehiculo)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";


            }
            else
            {

            }
        }
    }
}
