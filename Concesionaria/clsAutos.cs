using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcFechas;

namespace Concesionaria
{
    class clsAutos : clsVehiculos
    {
        #region Atributos
        private string _marca;
        private string _modelo;
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
            return $"Marca: {_marca} - Modelo: {_modelo} - Año: {_fechaFabricacion.Year}";
        }

        public override int calculoDescuento() //FALTA HACER
        {
            return 1;
        }

        //public override bool Equals(object autoPedido) //podemos usar el equals con el atributo de la clase padre?
        //{
        //    bool igual;

        //    if (autoPedido == null)
        //        igual = this == null;
        //    else if (this.GetType() != autoPedido.GetType())
        //        igual = false;
        //    else
        //    {
        //        clsAutos auto = (clsAutos)autoPedido;
        //        igual = this._codigo == auto._codigo;
        //    }
        //    return igual;
        //}

        //public override int GetHashCode()
        //{
        //    return (_codigo * 2);
        //}
        #endregion

        #region Metodos Estaticos

        #endregion

        #region Constructores
        public clsAutos()
        {
            _marca = string.Empty;
            _modelo = string.Empty;
            _fechaFabricacion = new DateTime(1900,01,01);
            _usado = false;
            _precioCosto = 0;
            _porcentajeGanancia = 0;
        }
        public clsAutos(int codigo): base(codigo)
        {
            _marca = string.Empty;
            _modelo = string.Empty;
            _fechaFabricacion = new DateTime(1900, 01, 01);
            _usado = false;
            _precioCosto = 0;
            _porcentajeGanancia = 0;
        }

        public clsAutos(string marca, string modelo, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, int codigo, string tipo, clsDistribuidores distribuidor): base(codigo, tipo, distribuidor)
        {
            _marca = marca;
            _modelo = modelo;
            if (clsFecha.esFechaValida(Convert.ToInt32(fechaFabricacion.Day), Convert.ToInt32(fechaFabricacion.Month), Convert.ToInt32(fechaFabricacion.Year)))
                _fechaFabricacion = fechaFabricacion;
            else _fechaFabricacion = new DateTime(1900, 01, 01);
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
