/*Este programa consiste e una tabla hash de trabajadores,el usuario
introducirá el número de la seguridad social,el nombre y el teléfono del
trabajador,el programa parará cuando el usuario introduzca un número vacío,
posteriormente los mostrará todos por pantalla*/
class Hash
{
    static void Main()
    {
        string nom, numseg, tel;
        Dictionary<string, Trabajador> Trabajadores =
            new Dictionary<string, Trabajador>();

        do
        {
            Console.WriteLine("Escriba el número de la seguridad social del" +
                " trabajador");
            numseg = Console.ReadLine();
            Console.Clear();
            if (numseg != "")
            {
                Console.WriteLine("Escribe el nombre del trabajador");
                nom = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Escriba el teléfono del trabajador");
                tel = Console.ReadLine();
                Trabajadores.Add(numseg, new Trabajador(numseg, nom, tel));
            }

        }
        while (numseg != "");
        Console.Clear();

        foreach (KeyValuePair<string, Trabajador> t in Trabajadores)
        {
            Console.WriteLine(t);
        }
    }
}
