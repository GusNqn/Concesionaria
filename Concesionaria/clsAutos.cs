using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcFechas;

namespace Concesionaria
{
    public class clsAutos : clsVehiculos
    {
        #region Atributos
        private string _marca;
        private string _modelo;
        private string _gama;
        private DateTime _fechaFabricacion;
        private bool _usado;
        private double _precioCosto;
        private int _porcentajeGanancia;
        #endregion

        #region Propiedades
        public string MARCA
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public string MODELO
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }
        public string GAMA
        {
            get
            {
                return _gama;
            }
            set
            {
                _gama = value;
            }
        }

        public DateTime FECHAFABRICACION
        {
            get
            {
                return _fechaFabricacion;
            }
            set
            {
                if (clsFecha.esFechaValida(Convert.ToInt32(value.Day), Convert.ToInt32(value.Month), Convert.ToInt32(value.Year)))
                    _fechaFabricacion = value;
            }
        }

        public bool USADO
        {
            get
            {
                return _usado;
            }
            set
            {
                _usado = value;
            }
        }

        public double PRECIOCOSTO   
        {
            get
            {
                return _precioCosto;
            }
            set
            {
                if (Math.Abs(value) > 0)
                    _precioCosto = value;
            }
        }

        public int PORCENTAJEGANANCIA
        {
            get
            {
                return _porcentajeGanancia;
            }
            set
            {   
                if (Math.Abs(value) > 0)
                    _porcentajeGanancia = value;
            }
        }

       
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"{base.ToString()} - {_marca} - {_modelo} - Año: {_fechaFabricacion.Year}";
        }

        public override int calculoDescuento() //FALTA HACER
        {
            return 1;
        }
        #endregion

        #region Metodos Estaticos

        #endregion

        #region Constructores
        public clsAutos()
        {
            _marca = string.Empty;
            _modelo = string.Empty;
            _gama = string.Empty;
            _fechaFabricacion = new DateTime(1900,01,01);
            _usado = false;
            _precioCosto = 0;
            _porcentajeGanancia = 0;
        }
        public clsAutos(string patente): base(patente)
        {
            _marca = string.Empty;
            _modelo = string.Empty;
            _gama = string.Empty;
            _fechaFabricacion = new DateTime(1900, 01, 01);
            _usado = false;
            _precioCosto = 0;
            _porcentajeGanancia = 0;
        }

        public clsAutos(string marca, string modelo, string gama, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, string codigo, string tipo, string patente, clsDistribuidores distribuidor): base(codigo, tipo, patente, distribuidor)
        {
            _marca = marca;
            _modelo = modelo;
            _gama = gama;
            _fechaFabricacion = fechaFabricacion;
            _usado = usado;
            if (Math.Abs(precioCosto) > 0)
                _precioCosto = precioCosto;
            else _precioCosto = 0;
            if (Math.Abs(porcentajeGanancia) > 0)
                _porcentajeGanancia = porcentajeGanancia;
            else porcentajeGanancia = 0;
        }

        #endregion
    }
}
