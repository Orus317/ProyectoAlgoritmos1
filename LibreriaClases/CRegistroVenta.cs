// using System;
using System.Collections;

namespace LibreriaClases
{
    public class CRegistroVentas
    {
        // Atributos
        private int _IdVenta;
        private int _NroDocVenta;
        private string _Fecha;
        private string _IdCliente;
        private int _IdProducto;
        private int _Cantidad;
        private float _PrecioUnitario;

        // Getters and setters

        public int IdVenta
        {
            get => _IdVenta; set => _IdVenta = value;
        }

        public int NroDocVenta
        {
            get => _NroDocVenta; set => _NroDocVenta = value;
        }

        public string Fecha
        {
            get => _Fecha; set => _Fecha = value;
        }

        public string IdCliente
        {
            get => _IdCliente; set
            {
                if (value.Length == 6)
                {
                    string[] StringDni = value.Split("");
                    int[] IntsDni = StringDni.Select(k => int.Parse(k)).ToArray();
                    _IdCliente = value;
                }
                else
                    Console.WriteLine("El DNI está compuesto por 8 digitos");
            }
        }

        public int IdProducto
        {
            get => _IdProducto; set => _IdProducto = value;
        }

        public int Cantidad
        {
            get => _Cantidad; set => _Cantidad = value;
        }


        public float PrecioUnitario
        {
            get => _PrecioUnitario; set => _PrecioUnitario = value;
        }

        // Constructor
        public CRegistroVentas(int id_venta, int nro_docventa, string fecha, string id_cliente, int id_producto, int cantidad, float precio_unitario)
        {
            IdVenta = id_venta;
            NroDocVenta = nro_docventa;
            Fecha = fecha;
            IdCliente = id_cliente;
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

