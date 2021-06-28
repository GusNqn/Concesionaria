using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    public abstract class clsVehiculos
    {
        #region Atributos
        protected string _codigo;
        protected string _tipo;
        protected clsDistribuidores _distribuidor;
        #endregion

        #region Propiedades
        public string CODIGO
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != "")
                    _codigo = value;
            }
        }

        public string TIPO
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public clsDistribuidores DISTRIBUIDOR
        {
            get
            {
                return _distribuidor;
            }
            set
            {
                _distribuidor = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"Codigo: {_codigo} - Tipo: {_tipo}";
        }

        public override bool Equals(object vehiculoPedido)
        {
            bool igual;

            if (vehiculoPedido == null)
                igual = this == null;
            else if (this.GetType() != vehiculoPedido.GetType())
                igual = false;
            else
            {
                clsVehiculos vehiculo = (clsVehiculos)vehiculoPedido;
                igual = this._codigo == vehiculo.CODIGO;
            }
            return igual;
        }

        public override int GetHashCode()
        {
            return (Convert.ToInt32(_codigo) * 10);
        }

        public abstract int calculoDescuento(); //devolvemos un integer que determina los dias que pasaron desde la adqusicion hasta la venta - HACER EL REDEFINIDO. Cambiamos el porcentaje acorde al tipo de vehiculo

        #endregion

        #region Metodos Estaticos

        #endregion

        #region Constructores
        
        
        public clsVehiculos()
        {
            _codigo = "";
            _tipo = string.Empty;
            _distribuidor = null;
        }

        public clsVehiculos(string codigo)
        {
            //if (Math.Abs(codigo) > 0)
                _codigo = codigo;
            _tipo = string.Empty;
            _distribuidor = null;
        }


        public clsVehiculos(string codigo, string tipo, clsDistribuidores distribuidor)
        {
            //if (Math.Abs(codigo) > 0)
                _codigo = codigo;
            //else _codigo = 0;
            _tipo = tipo;
            _distribuidor = distribuidor;
        }
        #endregion
    }
}
