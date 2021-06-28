using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Concesionaria
{
    //Domingo :
    // - Comprension de trabajo de sabado
    // - Redefinicion de Equals - GetHash - ToString de Distribuidores.
    // - Chequeo de esDistribuidorInternacional. Por que no se utiliza el Equals y se usa un indice?
    // - Correcion de Equals en clsVehiculos. Segundo argumento con parametro en vez de propiedad.
    // - Emprolijado de codigo
    // - Listar vehiculo. Ver comentarios en el codigo. Por que estamos listando en una clase? El listar deberia ir en el form.
    // - Insertar distribuidor hecho
    // - Insertar y modificar autos y camionetas hecho
    // - Actualizar vehiculos hecho
    // - Actualizar cantidades hecho
    // - metodo cantidad de vehiculos añadida a clsbase
    // - metodo cantidad de proveedores añadida a clsbase
    // - los botones...no son MSI??!?!?!?!?!

    // A entender de la funcionalidad del ejemplo de la profesora:
    // - CantidadVehiculos y CantidadDistribuidores...por que son propiedades?
    // - En la linea 195...si permitiera agregar mas en el combo...como lo controlo?

    public class clsBase_Datos 
    {
        List<clsVehiculos> listaVehiculos;
        List<clsDistribuidores> listaDistribuidores;
        public clsBase_Datos()
        {
            listaVehiculos = new List<clsVehiculos>();
            listaDistribuidores = new List<clsDistribuidores>();
        }
        #region Propiedades

        public int CantidadVehiculos
        {
            get
            {
                return listaVehiculos.Count;
            }
        }
        public int CantidadDistribuidores
        {
            get
            {
                return listaDistribuidores.Count;
            }
        }
        #endregion

        #region Metodos

        public bool existeCuitDistribuidor(string cuit)
        {
            clsDistribuidores distribuidor;
            bool existe = false;

            distribuidor = new clsDistribuidores(cuit, "", false);
            if (listaDistribuidores.Contains(distribuidor))
            {
                existe = true;
            }
            return existe;
        }

        public bool existeRazonDistribuidor(string razon)
        {
            bool existe = false;
            List<string> razonSocial;

            razonSocial = listaRazonDistribuidores();

            if (razonSocial.Contains(razon))
            {
                existe = true;
            }
            return existe;
        }
        public bool existeAuto(int codigo)
        {
            clsAutos auto;
            bool existe = false;

            auto = new clsAutos(codigo);
            if (listaVehiculos.Contains(auto))
            {
                existe = true;
            }
            return existe;
        }
        public bool existeCamioneta(int codigo)
        {
            clsCamionetas camioneta;
            bool existe = false;

            camioneta = new clsCamionetas(codigo);
            if (listaVehiculos.Contains(camioneta))
            {
                existe = true;
            }
            return existe;
        }

        public bool esDistribuidorInternacional(string cuit)
        {
            clsDistribuidores distribuidor = new clsDistribuidores(cuit, "", false);
            int indice = listaDistribuidores.IndexOf(distribuidor);
            if (indice >= 0)
            {
                distribuidor = listaDistribuidores[indice];
            }
            return distribuidor.INTERNACIONAL;
        }
        public string getRazonSocial(string cuit)
        {
            clsDistribuidores distribuidor = new clsDistribuidores(cuit, "", false);
            int indice = listaDistribuidores.IndexOf(distribuidor);
            if (indice >= 0)
            {
                distribuidor = listaDistribuidores[indice];
            }
            return distribuidor.RAZONSOCIAL;
        }
        public List<string> listaRazonDistribuidores()
        {
            List<string> lista;
            
            lista = new List<string>();

            foreach (clsDistribuidores distribuidor in listaDistribuidores)
            {
                lista.Add(distribuidor.RAZONSOCIAL);
            }

            return lista;
        }

        public int buscarIndice(string valorFiltro, int indiceFiltro)
        {
            int contador = -1;
            int indice = -1;
            int i = 0;
            bool encontrado = false;

            if (valorFiltro == "Auto")
            {
                while ((i <= listaVehiculos.Count && (!encontrado)))
                {
                    if (listaVehiculos[i].GetType() == typeof(clsAutos))
                    {
                        contador++;
                        if (contador == indiceFiltro)
                        {
                            encontrado = true;
                            indice = i;
                        }
                    }
                    i++;
                }
            }
            else if (valorFiltro == "Camioneta")
            {
                while ((i <= listaVehiculos.Count && (!encontrado)))
                {
                    if (listaVehiculos[i].GetType() == typeof(clsCamionetas))
                    {
                        contador++;
                        if (contador == indiceFiltro)
                        {
                            encontrado = true;
                            indice = i;
                        }
                    }
                    i++;
                }
            }
            else
            {
                indice = indiceFiltro;
            }
            return indice;
        }

        public bool esAuto(int indice)
        {
            return listaVehiculos[indice].GetType() == typeof(clsAutos); 
        }

        public clsAutos datosAuto(int codigo)
        {
            clsAutos autoBuscado = new clsAutos();
        
           foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                if (vehiculo.CODIGO == codigo)
                {
                    if (vehiculo.GetType() == typeof(clsAutos))
                    {
                        autoBuscado = (clsAutos)vehiculo;
                    }
                }
            }
            return autoBuscado;
        }
        public clsCamionetas datosCamionetas(int codigo)
        {
            clsCamionetas camionetaBuscada = new clsCamionetas();
            foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                if (vehiculo.CODIGO == codigo)
                {
                    if (vehiculo.GetType() == typeof(clsCamionetas))
                    {
                        camionetaBuscada = (clsCamionetas)vehiculo;
                    }
                }
            }
            return camionetaBuscada;
        }
        public List<string> listarDistribuidores(string procedencia)
        {
            List<string> lista;

            lista = new List<string>();

            if (procedencia == "Internacional")
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    if (distribuidor.INTERNACIONAL)
                    {
                        lista.Add(distribuidor.ToString());
                    }
                }
            }
            else if (procedencia == "Nacional")
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    if (!distribuidor.INTERNACIONAL)
                    {
                        lista.Add(distribuidor.ToString());
                    }
                }
            }
            else
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    lista.Add(distribuidor.ToString());
                }
            }

            return lista;
        }
        public List<string> listarVehiculos(string tipo_Vehiculo, string marca, string cuitDistribuidor, bool Condicion, bool cuatroXcuatro, string gama)
        {
            List<string> lista;
            bool controlTipoVehiculo, controlMarca, controlDistribuidor, controlCondicion, controlCuaXcua, controlGama;

            lista = new List<string>();
            foreach (clsVehiculos vehiculos in listaVehiculos)
            {
                controlTipoVehiculo = false;
                controlMarca = false;
                controlDistribuidor = false;
                controlCondicion = false;
                controlCuaXcua = false;
                controlGama = false;

                if (tipo_Vehiculo == "Todos") //control vehiculo
                {
                    controlTipoVehiculo = true;
                }
                else if (tipo_Vehiculo == "Auto")
                {
                    controlTipoVehiculo = vehiculos.GetType() == typeof(clsAutos);
                }
                else if (tipo_Vehiculo == "Camioneta")
                {
                    controlTipoVehiculo = vehiculos.GetType() == typeof(clsCamionetas);
                }

                switch (marca) //control marca
                {
                    case "Todos": controlMarca = true; break;
                    case "Chevrolet": controlMarca = marca == "Chevrolet"; break;
                    case "Ford": controlMarca = marca == "Ford"; break;
                    case "Renault": controlMarca = marca == "Renault"; break;
                    case "Volskwagen": controlMarca = marca == "Volskwagen"; break;
                }

                if (cuitDistribuidor == "Todos") //control distribuidor
                {
                    controlDistribuidor = true;
                }
                else
                {
                    clsDistribuidores dist = new clsDistribuidores(cuitDistribuidor,"",false); 
                    controlDistribuidor = vehiculos.DISTRIBUIDOR.Equals(dist);
                }

                if (vehiculos.GetType() == typeof(clsAutos)) //control condicion y 4x4
                {
                    clsAutos auto = (clsAutos)vehiculos;
                    controlCondicion = auto.USADO == Condicion;
                    controlCuaXcua = true;                      
                }
                else
                {
                    clsCamionetas camionetas = (clsCamionetas)vehiculos;
                    controlCondicion = camionetas.USADO == Condicion;
                    controlCuaXcua = camionetas.CUATROXCUATRO == cuatroXcuatro;
                }

                if(gama == "Todos") //control gama
                {
                    controlGama = true;
                }
                else if (gama == "Base")
                {
                    controlGama = true;
                }
                else if (gama == "Media")
                {
                    controlGama = true;
                }
                else if (gama == "Full")
                {
                    controlGama = true;
                }

                if (controlDistribuidor && controlMarca && controlTipoVehiculo && controlCondicion && controlCuaXcua && controlGama)
                {
                    lista.Add(vehiculos.ToString());
                }
            }
            return lista;
        }

        public void insertarDistribuidor(string cuit, string razon, bool internacional)
        {
            clsDistribuidores distribuidor = new clsDistribuidores(cuit, razon, internacional);

            if (!listaDistribuidores.Contains(distribuidor))
            {
                listaDistribuidores.Add(distribuidor);
            }
        }

        public void modificarProveedor(string cuit, string razon, bool internacional)
        {
            clsDistribuidores distribuidor = new clsDistribuidores(cuit, razon, internacional);
            int posicion;

            posicion = listaDistribuidores.IndexOf(distribuidor);
            if (posicion >=0)
            {
                listaDistribuidores.RemoveAt(posicion);
                listaDistribuidores.Insert(posicion, distribuidor);
            }
        }

        public void insertarAuto(string marca, string modelo, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, int codigo, string tipo, clsDistribuidores distribuidor)
        { 
            clsAutos auto = new clsAutos(marca, modelo, fechaFabricacion, usado, precioCosto, porcentajeGanancia, codigo, tipo, distribuidor);

            if (!listaVehiculos.Contains(auto))
            {
                listaVehiculos.Add(auto);
            }
        }

        public void modificarAuto(string marca, string modelo, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, int codigo, string tipo, clsDistribuidores distribuidor)
        {
            clsAutos auto = new clsAutos(marca, modelo, fechaFabricacion, usado, precioCosto, porcentajeGanancia, codigo, tipo, distribuidor);
            int posicion;

            posicion = listaVehiculos.IndexOf(auto);
            if (posicion >= 0)
            {
                listaVehiculos.RemoveAt(posicion);
                listaVehiculos.Insert(posicion, auto);
            }
        }

        public void insertarCamioneta(string marca, string modelo, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, bool cuatroXcuatro, int codigo, string tipo, clsDistribuidores distribuidor)
        {
            clsCamionetas camioneta = new clsCamionetas(marca, modelo, fechaFabricacion, usado, precioCosto, porcentajeGanancia, cuatroXcuatro, codigo, tipo, distribuidor);

            if (!listaVehiculos.Contains(camioneta))
            {
                listaVehiculos.Add(camioneta);
            }
        }

        public void modificarCamioneta(string marca, string modelo, DateTime fechaFabricacion, bool usado, double precioCosto, int porcentajeGanancia, bool cuatroXcuatro, int codigo, string tipo, clsDistribuidores distribuidor)
        {
            clsCamionetas camioneta = new clsCamionetas(marca, modelo, fechaFabricacion, usado, precioCosto, porcentajeGanancia, cuatroXcuatro, codigo, tipo, distribuidor);
            int posicion;

            posicion = listaVehiculos.IndexOf(camioneta);
            if (posicion >= 0)
            {
                listaVehiculos.RemoveAt(posicion);
                listaVehiculos.Insert(posicion, camioneta);
            }
        }

        public int cantidadVehiculos()
        {
            int cantidad;

            cantidad = listaVehiculos.Count;

            return cantidad;
        }

        public int cantidadDistribuidores()
        {
            int cantidad;

            cantidad = listaDistribuidores.Count;

            return cantidad;
        }
        #endregion
    }




}
