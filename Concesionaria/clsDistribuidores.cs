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
        public override string ToString()
        {
            return $"CUIT: {_cuit} - Razón Social: {_razonSocial}";
        }

        public override bool Equals(object distribuidorPedido)
        {
            bool igual;

            if (distribuidorPedido == null)
                igual = this == null;
            else if (this.GetType() != distribuidorPedido.GetType())
                igual = false;
            else
            {
                clsDistribuidores distribuidor = (clsDistribuidores)distribuidorPedido;
                igual = this._cuit == distribuidor.CUIT;
            }
            return igual;
        }

        public override int GetHashCode()
        {
            return (Convert.ToInt32(_cuit) * 2);
        }
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
            if ((cuit != string.Empty) && (cuit.Length == 11))
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
