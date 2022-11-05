// using System;
using System.Collections;

namespace LibreriaClases
{
    public class CProducto{
        private int _IdProducto;
        private string _Descripcion;
        private string _Tipo;
        private string _UnidadMedida;
        private int _Stock;
        private float _PrecioUnitario;

        // Getters and setters
        public int IdProducto{
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

        public float PrecioUnitario{
            get => _PrecioUnitario; set => _PrecioUnitario = value;
        }
        
        // Constructor
        public CProducto(int idproducto, string descripcion, string tipo, string unidadmedida, int stock, float preciounitario){
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
                    ((CProducto)k).Mostrar();
            }
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

