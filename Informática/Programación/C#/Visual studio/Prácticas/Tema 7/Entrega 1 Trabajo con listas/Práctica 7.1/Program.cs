/*Este programa se trata de una lista genérica con la que podemos interactuar
mediante un menú,el cual permite:
Crear personajes,eligiendo entre arquero,guerrero y mago,al final de la
creación mostrará el listado actualizado de personajes;

ordenar los personajes en base a su vida;

borrar personajes de la lista en base al nombre y mostrar el listado
actualizado, si hay varios con dicho nombre los borrará y si no hay ninguno
saltará un mensaje y no mostrará el listado;

Mostrar todos los personajes con menos de 10 de vida,si no hay ninguno con
menos de 10 saltará un mensaje;

Mostrar el personaje con más vida,si no hay ningún personaje en la lista
saltará un mnesaje;

Salir;
*/
class Principal
{
    static void Masvida(List<Personaje> Personajes)
    {
        if (Personajes.Count > 0)
        {
            Personajes.Sort();
            Console.WriteLine("Personaje con más vida");
            Console.WriteLine();
            Console.WriteLine(Personajes[Personajes.Count - 1]
                .ToString());
            Console.WriteLine();
            Console.WriteLine("Pulse enter para continuar");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("La lista está vacía");
            Console.WriteLine();
            Console.WriteLine("Pulse enter para continuar");
            Console.ReadLine();
        }
    }
    static void Pocavida(List<Personaje> Personajes)
    {
        int cont = 0;
        for (int i = 0; i < Personajes.Count; i++)
        {
            if (Personajes[i].Vida < 10)
            {
                cont++;
            }
        }
        if (cont == 0)
        {
            Console.WriteLine("Todos los personajes tienen vida suficiente");
            Console.WriteLine();
            Console.WriteLine("Pulse enter para continuar");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Personajes con poca vida");
            Console.WriteLine();

            for (int i = 0; i < Personajes.Count; i++)
            {
                if (Personajes[i].Vida < 10)
                {
                    Console.WriteLine(Personajes[i].ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pulse enter para continuar");
            Console.ReadLine();
        }
    }
    static void Quitar(List<Personaje> Personajes)
    {
        string nomborrar;
        int cont = 0;
        if (Personajes.Count > 0)
        {
            Console.WriteLine("Escriba el nombre del/los personaje/s que desea"
            + " Eliminar");
            nomborrar = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < Personajes.Count; i++)
            {
                if (Personajes[i].Nombre.Contains(nomborrar))
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("No se encuentra el personaje");
                Console.WriteLine();
                Console.WriteLine("Pulse enter para continuar");
                Console.ReadLine();
            }
            else
            {
                do
                {
                    cont = 0;
                    for (int i = 0; i < Personajes.Count; i++)
                    {
                        if (Personajes[i].Nombre.Contains(nomborrar))
                        {
                            Personajes.RemoveAt(i);
                            cont++;
                        }
                    }
                }
                while (cont > 0);

                if (Personajes.Count > 0)
                {
                    Mostrarlista(Personajes);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("La lista está vacía");
                    Console.WriteLine();
                    Console.WriteLine("Pulse enter para continuar");
                    Console.ReadLine();
                }
            }
        }
    }
    static void Mago(List<Personaje> Personajes, string nom, int vid)
    {
        int podmag;
        do
        {
            Console.Clear();
            Console.WriteLine("Escriba El Poder mágico");
            podmag = Convert.ToInt32(Console.ReadLine());
        }
        while (podmag > 10 || podmag < 0);
        Personajes.Add(new Magos(nom, vid, podmag));
    }

    static void Guerrero(List<Personaje> Personajes, string nom, int vid)
    {
        string matesp;
        Console.WriteLine("Escriba El material del que está hecha la espada");
        matesp = Console.ReadLine();
        Personajes.Add(new Guerreros(nom, vid, matesp));
    }

    static void Arquero(List<Personaje> Personajes, string nom, int vid)
    {
        int longarc;
        Console.WriteLine("Escriba la longitud del arco");
        longarc = Convert.ToInt32(Console.ReadLine());
        Personajes.Add(new Arqueros(nom, vid, longarc));
    }
    static void Nuevo(List<Personaje> Personajes)
    {
        string nom;
        int vid = 0, eleccion = 0;

        Console.WriteLine("Escriba el nombre del personaje");
        nom = Console.ReadLine();
        do
        {
            Console.Clear();
            Console.WriteLine("Escriba los puntos de vida del personaje");
            vid = Convert.ToInt32(Console.ReadLine());
        }
        while (vid > 100 || vid < 0);

        Console.Clear();
        Console.WriteLine("¿Cual es la clase del personaje?");
        Console.WriteLine();
        Console.WriteLine("1. Arquero");
        Console.WriteLine();
        Console.WriteLine("2. Guerrero");
        Console.WriteLine();
        Console.WriteLine("3. Mago");
        eleccion = Convert.ToInt32(Console.ReadLine());
        switch (eleccion)
        {
            case 1:
                Console.Clear();
                Arquero(Personajes, nom, vid);
                break;
            case 2:
                Console.Clear();
                Guerrero(Personajes, nom, vid);
                break;
            case 3:
                Console.Clear();
                Mago(Personajes, nom, vid);
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    static void Mostrarlista(List<Personaje> Personajes)
    {
        Console.Clear();
        Console.WriteLine("Personajes");
        Console.WriteLine();
        for (int i = 0; i < Personajes.Count; i++)
        {
            Console.WriteLine(Personajes[i].ToString());
        }

        Console.WriteLine();
        Console.WriteLine("Pulse enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    static void Menu(ref int eleccion, List<Personaje> Personajes)
    {
        Console.WriteLine("Elija una opción del menú");
        Console.WriteLine();
        Console.WriteLine("1. Nuevo personaje");
        Console.WriteLine();
        Console.WriteLine("2. Personajes por nivel de vida");
        Console.WriteLine();
        Console.WriteLine("3. Quitar personaje");
        Console.WriteLine();
        Console.WriteLine("4. Personajes con poca vida");
        Console.WriteLine();
        Console.WriteLine("5. Personaje con más vida");
        Console.WriteLine();
        Console.WriteLine("6. Salir");

        eleccion = Convert.ToInt32(Console.ReadLine());
        switch (eleccion)
        {
            case 1:
                Console.Clear();
                Nuevo(Personajes);
                if (Personajes.Count > 0)
                {
                    Mostrarlista(Personajes);
                }

                break;
            case 2:
                Console.Clear();
                if (Personajes.Count > 0)
                {
                    Personajes.Sort();
                    Mostrarlista(Personajes);
                }
                else
                {
                    Console.WriteLine("La lista está vacía");
                    Console.WriteLine();
                    Console.WriteLine("Pulse enter para continuar");
                    Console.ReadLine();
                }
                break;
            case 3:
                Console.Clear();
                if (Personajes.Count > 0)
                {
                    Quitar(Personajes);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("La lista está vacía");
                    Console.WriteLine();
                    Console.WriteLine("Pulse enter para continuar");
                    Console.ReadLine();
                }
                break;
            case 4:
                Console.Clear();
                Pocavida(Personajes);
                break;
            case 5:
                Console.Clear();
                Masvida(Personajes);
                break;
            case 6:
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opción inválida");
                Console.WriteLine();
                Console.WriteLine("Pulse enter para continuar");
                Console.ReadLine();
                break;
        }
    }
    static void Main()
    {
        List<Personaje> Personajes = new List<Personaje>();
        int eleccion = 0;

        do
        {
            Console.Clear();
            Menu(ref eleccion, Personajes);
        }
        while (eleccion != 6);
    }
}