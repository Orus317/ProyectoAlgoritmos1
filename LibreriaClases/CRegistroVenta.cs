// using System;
using System.Collections;

namespace LibreriaClases
{
    public class CRegistroVentas
    {
        // Atributos
        private string _IdVenta;
        private string _NroDocVenta;
        private string _Fecha;
        private string _IdCliente;
        private string _IdProducto;
        private int _Cantidad;
        private double _PrecioUnitario;

        #region Getters and setters

        public string IdVenta
        {
            get => _IdVenta; set => _IdVenta = value;
        }

        public string NroDocVenta
        {
            get => _NroDocVenta; set => _NroDocVenta = value;
        }

        public string Fecha
        {
            get => _Fecha; set => _Fecha = value;
        }

        public string IdCliente
        {
            get => _IdCliente; set => _IdCliente = value;
        }

        public string IdProducto
        {
            get => _IdProducto; set => _IdProducto = value;
        }

        public int Cantidad
        {
            get => _Cantidad; set => _Cantidad = value;
        }


        public double PrecioUnitario
        {
            get => _PrecioUnitario; set => _PrecioUnitario = value;
        }
        #endregion

        // Constructor
        public CRegistroVentas(string id_venta, string nro_docventa, string fecha, string id_cliente, string id_producto, int cantidad, double precio_unitario, ArrayList Clientes)
        {
            IdVenta = id_venta;
            NroDocVenta = nro_docventa;
            Fecha = fecha;
            IdCliente = CCliente.ValidarCliente(Clientes, id_cliente);
            IdProducto = id_producto;
            Cantidad = cantidad;
            PrecioUnitario = precio_unitario;
        }

        // Listar 
        public static void ListarRegistroVentas(ArrayList arr)
        {
            foreach (object k in arr)
            {
                if (k is CRegistroVentas)
                    ((CProducto)k).Mostrar();
            }
        }
        // Verificar que exista un cliente
        
        public void Mostrar()
        {
            Console.WriteLine("Identificador de venta:" + IdVenta);
            Console.WriteLine("Número de venta: " + NroDocVenta);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("DNI del cliente: " + IdCliente);
            Console.WriteLine("Identificador del producto: " + IdProducto);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Precio Unitario: " + PrecioUnitario);
        }
    }
}

