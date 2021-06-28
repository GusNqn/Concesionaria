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
    public partial class FDistribuidores : Form
    {
        clsBase_Datos datos;
        bool agregarProveedor;
        string cuitDistribuidor;
        public FDistribuidores(clsBase_Datos conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarProveedor = true;
        }
        public FDistribuidores(clsBase_Datos conexion, string cuit)
        {
            InitializeComponent();
            datos = conexion;
            agregarProveedor = false;
            cuitDistribuidor = cuit;

        }

        private void mtCuit_Validating(object sender, CancelEventArgs e)
        {
            epCuit.Clear();
            if (!mtCuit.MaskCompleted)
                epCuit.SetError(mtCuit, "Debe completar el CUIT correctamente");
        }
        private void FDistribuidores_Load(object sender, EventArgs e)
        {
            if (agregarProveedor)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                mtCuit.Clear();
                tRazonSocial.Text = "";
                checkInternacional.Checked = false;
            }
            else
            {
                Text = "Modificar";
                bAceptar.Text = "Modificar";
                mtCuit.Text = cuitDistribuidor;
                mtCuit.Enabled = false;
                tRazonSocial.Text = datos.getRazonSocial(cuitDistribuidor);
                checkInternacional.Checked = datos.esDistribuidorInternacional(cuitDistribuidor);
                
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevoCuit = mtCuit.MaskCompleted ? mtCuit.Text : "";
            string nuevaRazSocial = tRazonSocial.Text.Trim() != "" ? tRazonSocial.Text : "";
            bool internacional = checkInternacional.Checked;

            if (nuevoCuit == "")
            {
                MessageBox.Show("Complete el Cuit", "Cuit Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevaRazSocial == "")
            {
                MessageBox.Show("Complete la Razon Social", "Razon Social Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (agregarProveedor)
            {
                if (datos.existeCuitDistribuidor(nuevoCuit))
                {
                    MessageBox.Show("El Cuit ya Existe", "Cuit Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (datos.existeRazonDistribuidor(nuevaRazSocial))
                {
                    MessageBox.Show("La Razon Social ya Existe", "Razon Social Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    datos.insertarDistribuidor(nuevoCuit, nuevaRazSocial, internacional);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            { 
                
            }
        }


    }
}
