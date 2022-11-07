﻿// using System;
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
                {
                    Console.WriteLine("--------------------");
                    ((CRegistroVentas)k).Mostrar();
                    Console.WriteLine("--------------------");
                }
            }
        }
        // Calcular el dinero recaudado en una determinada fecha
        public static void fecha_vendida(ArrayList Lista, string fecha)
        {
            double a = 0;
             // Recorrer la Lista
            for (int i = 0; i < Lista.Count; i++)
            {
                if ((Lista[i] as CRegistroVentas).Fecha == fecha)
                {
                    // Calcular el dinero recaudaddo
                    a += (Lista[i] as CRegistroVentas).Cantidad * (Lista[i] as CRegistroVentas).PrecioUnitario;
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dinero recaudado de " + fecha);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(a);
        }
        
        // Hallar el producto más vendido
        public static void producto_mas_vendido(ArrayList Lista, ArrayList Lista2)
        {
            // Variables auxiliares
            int mas_vendido = 0;
            string id_mas_vendido = "";
            string descripcion_mas_vendido = ""; 
            // Recorremos la lista
            for (int i = 0; i < Lista.Count; i++)
            {
                int contador = 0;
                string producto = (Lista[i] as CRegistroVentas).IdProducto;
                // Encontramos la repetición del producto
                for (int k = 0; k < Lista.Count; k++)
                {
                    if ((Lista[k] as CRegistroVentas).IdProducto == producto)
                    {
                        // Sumamos la cantidad unidades vendidas 
                        contador += (Lista[k] as CRegistroVentas).Cantidad;
                    }

                    // Establecer el el ID del producto más vendido
                    if (contador > mas_vendido)
                    {
                        mas_vendido = contador;
                        id_mas_vendido = (Lista[i] as CRegistroVentas).IdProducto;
                    }
                }
            }
            // Hallar la descripción de el producto más vendido
            for (int k = 0; k < Lista2.Count; k++)
            {
                if ((Lista2[k] as CProducto).IdProducto == id_mas_vendido)
                    descripcion_mas_vendido = (Lista2[k] as CProducto).Descripcion;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Producto más vendido");
            Console.WriteLine("------------------------");
            Console.WriteLine("ID del producto: " + id_mas_vendido);
            Console.WriteLine("Descripción: " + descripcion_mas_vendido);
            Console.WriteLine("Unidades vendidas: " + mas_vendido);
        }
        
        // Listado de las ventas de una determinada fecha
        public static void listarVentasPorFecha(ArrayList RegistroVentas, string fecha)
        {
            fecha = ValidarFecha(fecha);
            foreach (object Venta in RegistroVentas)
            {
                if (((CRegistroVentas)Venta).Fecha == fecha)
                    ((CRegistroVentas)Venta).Mostrar();
            }
        }
        // Validar fecha  
        private static string ValidarFecha(string fecha)
        {
            // Separar el día mes y año 
            string[] digitosFechaStr = fecha.Split("/");
            int[] digitosFechaInt = digitosFechaStr.Select(k => int.Parse(k)).ToArray();
            // Verificar que sea un día correcto
            if (digitosFechaInt[0] > 0 && digitosFechaInt[0] < 32)
            {
                // Verificar que sea un mes correcto
                if (digitosFechaInt[1] > 0 && digitosFechaInt[1] < 13)
                {
                    // Verificar que sea un año correcto
                    if (digitosFechaInt[2] > 0)
                    {
                        return fecha;
                    }
                }
            }
            Console.WriteLine("La fecha no es válida");
            return "NE";
        }
        
        // Lista de ventas de un determinado cliente 
        public static void listarVentasCliente(ArrayList Lista, string DNICliente)
        {
            int a = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                // Hallamos al cliente
                if ((Lista[i] as CRegistroVentas).IdCliente == DNICliente)
                {
                    Console.WriteLine("\n------------------------");
                    Console.WriteLine("   Venta número " + ++a);
                    Console.WriteLine("------------------------");
                    (Lista[i] as CRegistroVentas).Mostrar();
                    // Calculamos el subtotal
                    double subtotal = (Lista[i] as CRegistroVentas).Cantidad * (Lista[i] as CRegistroVentas).PrecioUnitario;
                    Console.WriteLine("Subtotal: " + subtotal);
                }
            }
            if (a == 0) // Si es igual a cero significa que al cliente no se le registro ninguna venta
                Console.WriteLine("No se encontraron ventas a " + DNICliente);
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

