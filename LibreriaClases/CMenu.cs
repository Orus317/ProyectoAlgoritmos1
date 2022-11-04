namespace LibreriaClases
{
    public class CMenu
    {
        private static int ValidarEntero(string message, int low, int high)
        {
            // Modulo para validar un entero entre dos límites
            string _opcion = Console.ReadLine();
            int opcion = 0;
            // Usar una estructura try-catch para poder poder manejar errores de tipo, generalmente cuando
            // se ingresan letras u otros caracteres 
            try
            {
                // Intentar parsear el string ingresado
                opcion = int.Parse(_opcion);
                // si el string es parseado se verifica que esté entre los límites
                while (opcion > high || opcion < low)
                {
                    // mostrar el mensaje de warning en consola
                    Console.WriteLine(message);
                    // recibir nuevamente la opcion
                    _opcion = Console.ReadLine();
                    // intentar parsear
                    opcion = int.Parse(_opcion);
                }
            }
            catch (Exception)
            {
                // En caso de que el parseo no funcione inmediatamente se mostrará el warn message y se ejecutará el validador nuevamente
                Console.WriteLine(message);
                ValidarEntero(message, low, high);
            }
            return opcion;
        }
        public static int MostrarMenu()
        {
            Console.WriteLine("APP CENTRO COMERCIAL - SUPERMERCADO");
            // Ejecutar constructor de un producto
            Console.WriteLine("1. Ingreso de nuevos productos");
            // Ejecutar constructor de cliente
            Console.WriteLine("2. Ingreso de nuevos clientes");
            // Validar cliente, producto y stock enough -> update stock
            // Las ventas tmb se registrarán en un arrayList, que 
            Console.WriteLine("3. Registrar venta");
            // Los clientes se almacenarán en un arrayList. Un foreach que despliegue Mostrar() de cada cliente
            Console.WriteLine("4. Lista general de clientes");
            Console.WriteLine("5. Lista general de productos");
            Console.WriteLine("6. Lista general de ventas");
            // Esta app debe tener por los menos los sig datos: NroDocVenta, ClientName, ProductName, Cantidad, PrecioUnitario, Subtotal 
            Console.WriteLine("7. Lista de ventas de una fecha determinada");
            // NroDocVenta, Fecha, NombreProducto, Cantidad, PrecioUnitario, Subtotal
            Console.WriteLine("8. Lista de ventas de un cliente determinado");
            Console.WriteLine(" -- Ingrese la opción: ");
            int Opcion = ValidarEntero("Debe ingresar un número, entre 1 y 8", 1, 8);
            return Opcion;
        }
    }
}