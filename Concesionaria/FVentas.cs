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
    public partial class FVentas : Form
    {
        #region Inicializacion Form
        clsBase_Datos datos;
        string pat;
        bool esAuto;
        #endregion
        public FVentas(clsBase_Datos conexion, string patente, bool esAut)
        {
            InitializeComponent();
            datos = conexion;
            pat = patente;
            esAuto = esAut;
        }
        private void FVentas_Load(object sender, EventArgs e)
        {
            if (esAuto)
            {
                clsAutos auto = datos.datosAuto(pat);
                lVehiculo.Text = auto.ToString();
                dtFechaCompra.Value = auto.FECHACOMPRA;
                dtFechaCompra.Enabled = false;
            }
            else 
            {
                clsCamionetas camioneta = datos.datosCamionetas(pat);
                lVehiculo.Text = camioneta.ToString();
                dtFechaCompra.Value = camioneta.FECHACOMPRA;
                dtFechaCompra.Enabled = false;
            }
        
        }

        private void bVender_Click(object sender, EventArgs e)
        {
            if (esAuto)
            {
                clsAutos auto = datos.datosAuto(pat);
                MessageBox.Show($"La ganacia de la venta de este vehiculo fue {auto.calcularGanancia(dtFechaVenta.Value)}");
                DialogResult = DialogResult.OK;
            }
            else
            {
                clsCamionetas camioneta = datos.datosCamionetas(pat);
                MessageBox.Show($"La ganacia de la venta de este vehiculo fue {camioneta.calcularGanancia(dtFechaVenta.Value)}");
                DialogResult = DialogResult.OK;
            }
        }

        private void dtFechaCompra_ValueChanged(object sender, EventArgs e)
        {
            dtFechaVenta.MinDate = dtFechaCompra.Value;
        }
    }
}
