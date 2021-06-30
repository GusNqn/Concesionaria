using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcLibreriaConsecionaria;

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
                double ganancia = auto.calcularGanancia(dtFechaVenta.Value);
                MessageBox.Show($"El vehiculo se vendio en: {auto.PRECIOCOSTO + ganancia} \nLa ganancia fue: {ganancia}", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                clsCamionetas camioneta = datos.datosCamionetas(pat);
                double ganancia = camioneta.calcularGanancia(dtFechaVenta.Value);
                MessageBox.Show($"El vehiculo se vendio en: {camioneta.PRECIOCOSTO + ganancia} \nLa ganancia fue: {ganancia}", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void dtFechaCompra_ValueChanged(object sender, EventArgs e)
        {
            dtFechaVenta.MinDate = dtFechaCompra.Value;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
