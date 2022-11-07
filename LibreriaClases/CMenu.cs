using System.Collections;
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
        public static void MostrarMenu(ArrayList Clientes, ArrayList Productos, ArrayList RegistroVentas)
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
            EjecutarOpcion(Opcion, Clientes, Productos, RegistroVentas);
        }
        private static void EjecutarOpcion(int opcion, ArrayList Clientes, ArrayList Productos, ArrayList RegistroVentas)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("--------");
                    Console.Write("Ingrese el codigo del producto: ");
                    string idProducto = Console.ReadLine();
                    Console.Write("Ingrese la descripción del producto: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Ingrese el tipo del producto: ");
                    string tipo = Console.ReadLine();
                    Console.Write("Ingrese la unidad de medida del producto: ");
                    string unidadMedida = Console.ReadLine();
                    Console.Write("Ingrese el stock del producto: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio unitario del producto: ");
                    double precioUnitario = double.Parse(Console.ReadLine());
                    CProducto _ = new(idProducto, descripcion, tipo, unidadMedida, stock, precioUnitario);
                    Clientes.Add(_);
                    Console.WriteLine("--------");
                    break;
                case 2:
                    Console.WriteLine("--------");
                    Console.Write("Ingresar código de cliente");
                    string id = Console.ReadLine();
                    Console.Write("Ingresar nombre del cliente");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingresar la dirección del cliente");
                    string direccion = Console.ReadLine();
                    CCliente _p = new(id, nombre, direccion);
                    Console.WriteLine("--------");
                    break;
                case 3:
                    Console.WriteLine("--------");
                    Console.Write("Ingresar registro de venta: ");
                    string _id = Console.ReadLine();
                    Console.Write("Ingresar el número del documento de venta: ");
                    string nro_venta = Console.ReadLine();
                    Console.Write("Ingresar la fecha");
                    string fecha = Console.ReadLine();
                    Console.Write("Ingresar el id del cliente");
                    string id_cliente = CCliente.ValidarCliente(Clientes, Console.ReadLine());
                    Console.Write("Ingresar el id del producto");
                    string id_producto = CProducto.ValidarProducto(Productos, Console.ReadLine());
                    Console.Write("Ingresar la cantidad de productos adquiridos");
                    int cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingresar el precio unitario");
                    double _precioUnitario = double.Parse(Console.ReadLine());
                    CRegistroVentas nuevoRegistro = new(_id, nro_venta, fecha, id_cliente, id_producto, cantidad, _precioUnitario, Clientes);
                    Console.WriteLine("--------");
                    break;
                case 4:
                    CCliente.ListarClientes(Clientes);
                    break;
                case 5:
                    CProducto.ListarProductos(Productos);
                    break;
                case 6:
                    CRegistroVentas.ListarRegistroVentas(RegistroVentas);
                    break;
                case 7:
                    Console.WriteLine("--------");
                    Console.Write("Escribir la fecha");
                    string __fecha = Console.ReadLine();
                    CRegistroVentas.listarVentasPorFecha(RegistroVentas, __fecha);
                    Console.WriteLine("--------");
                    break;
                case 8:
                    Console.WriteLine("--------");
                    Console.Write("Escribir el DNI del cliente");
                    string _id_cliente = CCliente.ValidarCliente(Clientes, Console.ReadLine());
                    CRegistroVentas.listarVentasCliente(RegistroVentas, _id_cliente);
                    Console.WriteLine("--------");
                    break;
                case 9:
                    Console.WriteLine("--------");
                    Console.Write("Ingresa la fecha: (ejemplo: 12/02/12) --> ");
                    string _fecha = Console.ReadLine();
                    CRegistroVentas.fecha_vendida(RegistroVentas, _fecha);
                    Console.WriteLine("--------");
                    break;
                case 10:
                    CRegistroVentas.producto_mas_vendido(RegistroVentas, Productos);
                    break;
                default:
                    break;


            }
        }
    }
}