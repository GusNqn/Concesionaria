using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    public class clsDistribuidores
    {
        #region Atributos
        private string _cuit;
        private string _razonSocial;
        private bool _internacional;
        #endregion

        #region Propiedades
        public string CUIT
        {
            get
            {
                return _cuit;
            }
            set
            {
                if ((value != string.Empty) && (value.Length != 11))
                    _cuit = value;
            }
        }

        public string RAZONSOCIAL
        {
            get
            {
                return _razonSocial;
            }
            set
            {
                if (value != string.Empty)
                    _razonSocial = value;
            }
        }

        public bool INTERNACIONAL
        {
            get
            {
                return _internacional;
            }
            set
            {
                _internacional = value;
            }
        }
        #endregion

        #region Metodos

        #endregion

        #region Metodos Estaticos

        #endregion

        #region Constructores
        public clsDistribuidores()
        {
            _cuit = "00000000000";
            _razonSocial = string.Empty;
            _internacional = false;
        }

        public clsDistribuidores(string cuit, string razonSocial, bool internacional)
        {
            if ((cuit != string.Empty) && (cuit.Length != 11))
                _cuit = cuit;
            else _cuit = "00000000000";
            if (razonSocial != string.Empty)
                _razonSocial = razonSocial;
            else _razonSocial = string.Empty;
            _internacional = internacional;
        }
        #endregion
    }
}
