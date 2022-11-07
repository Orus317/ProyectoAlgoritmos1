using System.Collections;
namespace LibreriaClases
{
    public class CCliente
    {
        #region Campos privados
        private string _id;
        private string _nombre;
        private string _direccion;
        #endregion
        #region Getters & Setters
        public string Id { 
            get => _id; 
            set
            {
                // Para poder hacer set de Id se debe verificar que el dato ingresado tenga 8 dígitos y que estos sean números enteros
                // Verificar que hay 8 caracteres
                char[] StringDni = value.ToCharArray();
                if (StringDni.Length == 8)
                {
                    // Verificar que cada uno de estos caracteres realmente es un digito
                    try
                    {
                        //Se usa una función de funcionamiento análogo a "Map"
                        int[] IntsDni = StringDni.Select(k => int.Parse(k.ToString())).ToArray();
                    }
                    catch (Exception)
                    {
                        //Si se detecta un error se indica que el DNI no es válido y se reemplaza por No Existe (NE)
                        Console.WriteLine("El DNI ingresado no es válido");
                        _id = "NE";
                    }
                    _id = value;
                }
                // Por si el DNI no está compuesto por 8 dígitos
                else
                    Console.WriteLine("El DNI está compuesto por 8 digitos");
            }
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        #endregion
        #region Constructor
        public CCliente(string id, string nombre, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
        }
        #endregion
        #region Métodos
        public void Mostrar()
        {
            Console.WriteLine("DNI: " + Id +"\tNombre: " + Nombre + "\tDireccion: " + Direccion);
        }
        public static void ListarClientes(ArrayList arr)
        {
            foreach (object k in arr)
            {
                if (k is CCliente)
                    // Usando casting para tomar "k" como una instancia de CCliente en vez de un Obejct
                    ((CCliente)k).Mostrar();
            }
        }
        public static string ValidarCliente(ArrayList Clientes, string IDToProve)
        {
            // Modulo para validar DNIs que ya existan en el arreglo de Cientes
            foreach (object cliente in Clientes)
            {
                // Usando casting para tomar "k" como una instancia de CCliente en vez de un Obejct
                if (((CCliente)cliente).Id == IDToProve)
                    return IDToProve;
            }
            // Si no se encuentra al cliente
            Console.WriteLine("Este cliente no existe");
            return "NE";
        }
        public override string ToString()
        {
            return Id;
        }
        #endregion

    }
}
