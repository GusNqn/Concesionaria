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
        bool agregarDistribuidor;
        string cuitDistribuidor;
        public FDistribuidores(clsBase_Datos conexion)
        {
            InitializeComponent();
            datos = conexion;
            agregarDistribuidor = true;
        }
        public FDistribuidores(clsBase_Datos conexion, string cuit)
        {
            InitializeComponent();
            datos = conexion;
            agregarDistribuidor = false;
            cuitDistribuidor = cuit;

        }

        private void mtCuit_Validating(object sender, CancelEventArgs e)
        {
            epCuit.Clear();
            if (!clsDistribuidores.esCuitValido(mtCuit.Text))
                epCuit.SetError(mtCuit, "Debe completar el CUIT correctamente");
        }
        private void FDistribuidores_Load(object sender, EventArgs e)
        {
            if (agregarDistribuidor)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                mtCuit.Focus();
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
            string nuevoCuit = mtCuit.MaskCompleted ? mtCuit.Text : string.Empty;
            string nuevaRazSocial = tRazonSocial.Text.Trim() != string.Empty ? tRazonSocial.Text : string.Empty;
            bool internacional = checkInternacional.Checked;
           
            if (nuevoCuit == string.Empty)
            {
                MessageBox.Show("Complete el CUIT", "CUIT Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!clsDistribuidores.esCuitValido(nuevoCuit))
            {
                MessageBox.Show("El CUIT ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtCuit.Clear();
                mtCuit.Focus();
            }
            else if (nuevaRazSocial == string.Empty)
            {
                MessageBox.Show("Complete la Razon Social", "Razon Social Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (agregarDistribuidor)
            {
                if (datos.existeCuitDistribuidor(nuevoCuit))
                {
                    MessageBox.Show("El CUIT ya Existe", "CUIT Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtCuit.Focus();
                }
                else if (datos.existeRazonDistribuidor(nuevaRazSocial))
                {
                    MessageBox.Show("La Razon Social ya Existe", "Razon Social Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tRazonSocial.Focus();
                }
                else
                { 
                    datos.insertarDistribuidor(nuevoCuit, nuevaRazSocial, internacional);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string razonModificada = datos.getRazonSocial(cuitDistribuidor);
                if ((nuevaRazSocial != razonModificada) && (datos.existeRazonDistribuidor(nuevaRazSocial)))
                {
                    MessageBox.Show("La Razon Social ya Existe", "Razon Social Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tRazonSocial.Focus();
                }
                else
                {
                    datos.modificarDistribuidor(cuitDistribuidor, nuevaRazSocial, internacional);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
