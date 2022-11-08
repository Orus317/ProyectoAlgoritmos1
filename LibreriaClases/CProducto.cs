// using System;
using System.Collections;

namespace LibreriaClases
{
    public class CProducto{
        private string _IdProducto;
        private string _Descripcion;
        private string _Tipo;
        private string _UnidadMedida;
        private int _Stock; 
        private double _PrecioUnitario;

        // Getters and setters
        public string IdProducto{
            get => _IdProducto; set => _IdProducto = value;
        }

        public string Descripcion{
            get => _Descripcion; set => _Descripcion = value;
        }

        public string Tipo{
            get => _Tipo; set => _Tipo = value;
        }

        public string UnidadMedida{
            get => _UnidadMedida; set => _UnidadMedida= value;
        }


        public int Stock{
            get => _Stock; set => _Stock = value;
        }

        public double PrecioUnitario{
            get => _PrecioUnitario; set => _PrecioUnitario = value;
        }
        
        // Constructor
        public CProducto(string idproducto, string descripcion, string tipo, string unidadmedida, int stock, double preciounitario){
            IdProducto = idproducto;
            Descripcion = descripcion;
            Tipo = tipo;
            UnidadMedida = unidadmedida;
            Stock = stock;
            PrecioUnitario = preciounitario;
        }
        
        public static void ListarProductos(ArrayList arr){
            foreach (object k in arr){
                if (k is CProducto)
                {
                    Console.WriteLine("--------------------");
                    ((CProducto)k).Mostrar();
                    Console.WriteLine("--------------------");
                }
            }
        }

        public static string ValidarProducto(ArrayList Productos, string IDToProve)
        {
            foreach (object producto in Productos)
            {
                if (((CProducto)producto).IdProducto == IDToProve)
                    // Si existe el producto lo devolvemos
                    return IDToProve;
            }
            // Si no se encontró el producto
            Console.WriteLine("Este producto no existe");
            return "NE";
        }
        public static CProducto RetornarProductoPorID(ArrayList Productos, string id)
        {
            foreach (object producto in Productos)
            {
                if (((CProducto)producto).IdProducto == id)
                {
                    return (CProducto)producto;
                }
            }
            return new CProducto("NE", "NE", "NE", "NE", 0, 0);
        }
        public void Mostrar(){
            Console.WriteLine("Identificardor: " + IdProducto);
            Console.WriteLine("Descripcción: " + Descripcion);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("UnidadMedida: " + UnidadMedida);
            Console.WriteLine("Precio unitario: " + PrecioUnitario);
        }
    }
}

