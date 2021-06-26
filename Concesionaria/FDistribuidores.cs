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
        public FDistribuidores()
        {
            InitializeComponent();
        }

        private void mtCuit_Validating(object sender, CancelEventArgs e)
        {
            epCuit.Clear();
            if (!mtCuit.MaskCompleted)
                epCuit.SetError(mtCuit, "Debe completar el CUIT correctamente");
        }
    }
}
