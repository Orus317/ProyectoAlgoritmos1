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
                if (value.Length == 8)
                {
                    char[] StringDni = value.ToCharArray();
                    try
                    {
                        int[] IntsDni = StringDni.Select(k => int.Parse(k.ToString())).ToArray();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El DNI ingresado no es válido");
                        _id = "NE";
                    }
                    _id = value;
                }
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
            foreach (object cliente in Clientes)
            {
                if (((CCliente)cliente).Id == IDToProve)
                    return IDToProve;
            }
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
