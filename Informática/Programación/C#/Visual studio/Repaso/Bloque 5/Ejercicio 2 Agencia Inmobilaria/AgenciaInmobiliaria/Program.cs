using System;

/*
 * Programa principal para gestionar las propiedades inmobiliarias
 */
class Program
{
    static void Main()
    {
        Propiedad[] propiedades = new Propiedad[10];
        List<Agente> agentes = new List<Agente>();
        agentes.Add(new Agente("Juan Pérez", "61223344"));
        agentes.Add(new Agente("Margarita López", "699887766"));
        agentes.Add(new Agente("Raquel Fuentes", "610203040"));

        int cantidad = rellenarPropiedades(propiedades, agentes);
        int opcion;

        do
        {
            Console.WriteLine("Elige una opción del menú:");
            Console.WriteLine("1. Buscar por tipo");
            Console.WriteLine("2. Ordenar por precio");
            Console.WriteLine("3. Buscar por superficie");
            Console.WriteLine("4. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    buscarPorTipo(propiedades, cantidad);
                    break;
                case 2:
                    ordenarPorPrecio(propiedades, cantidad);
                    break;
                case 3:
                    buscarPorSuperficie(propiedades, cantidad);
                    break;
            }
        }
        while (opcion != 4);
    }

    private static int rellenarPropiedades(Propiedad[] propiedades,
        List<Agente> agentes)
    {
        int cantidad = 0, tipoPropiedad = -1;
        string descripcion;
        int superficie, precio, habitaciones, planta, terraza;
        Agente agente;
        bool aseo;

        while (cantidad < propiedades.Length && tipoPropiedad != 0)
        {
            Console.WriteLine("Elige el tipo de propiedad:");
            Console.WriteLine("1. Piso / 2. Bungalow / 3. Tienda / 0. Terminar");
            tipoPropiedad = Convert.ToInt32(Console.ReadLine());
            if (tipoPropiedad != 0)
            {
                Console.WriteLine("Descripción: ");
                descripcion = Console.ReadLine();
                Console.WriteLine("Superficie en m2:");
                superficie = Convert.ToInt32(Console.ReadLine());
                precio = pedirPrecio();
                agente = seleccionarAgente(agentes);
                if (tipoPropiedad == 1)
                {
                    Console.WriteLine("Habitaciones:");
                    habitaciones = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Número de planta:");
                    planta = Convert.ToInt32(Console.ReadLine());
                    propiedades[cantidad] =
                        new Piso(descripcion, superficie, precio, agente,
                            habitaciones, planta);
                    cantidad++;
                }
                else if (tipoPropiedad == 2)
                {
                    Console.WriteLine("Superficie de terraza en m2:");
                    terraza = Convert.ToInt32(Console.ReadLine());
                    propiedades[cantidad] =
                        new Bungalow(descripcion, superficie, precio, agente,
                            terraza);
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("Aseo? (1. SI / 2. NO):");
                    aseo = Convert.ToInt32(Console.ReadLine()) == 1;
                    propiedades[cantidad] =
                        new Tienda(descripcion, superficie, precio, agente, aseo);
                    cantidad++;
                }
            }
        }

        return cantidad;
    }

    private static int pedirPrecio()
    {
        int precio;
        do
        {
            Console.WriteLine("Precio en euros:");
        }
        while (!Int32.TryParse(Console.ReadLine(), out precio) || precio <= 0);

        return precio;
    }

    private static Agente seleccionarAgente(List<Agente> agentes)
    {
        Console.WriteLine("Elige un agente:");
        int seleccionado;
        for (int i = 0; i < agentes.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + agentes[i]);
        }
        seleccionado = Convert.ToInt32(Console.ReadLine());
        return agentes[seleccionado-1];
    }

    private static void buscarPorTipo(Propiedad[] propiedades, int cantidad)
    {
        int tipoPropiedad;

        Console.WriteLine("1. Piso / 2. Bungalow / 3. Tienda");
        tipoPropiedad = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cantidad; i++)
        {
            if (propiedades[i] is Piso && tipoPropiedad == 1 ||
                propiedades[i] is Bungalow && tipoPropiedad == 2 ||
                propiedades[i] is Tienda && tipoPropiedad == 3)
            {
            Console.WriteLine(propiedades[i]);
        }
    }
}

    private static void ordenarPorPrecio(Propiedad[] propiedades, int cantidad)
    {
        Array.Sort(propiedades, 0, cantidad);
        for (int i = 0; i < cantidad; i++)
            Console.WriteLine(propiedades[i]);
    }

    private static void buscarPorSuperficie(Propiedad[] propiedades,
        int cantidad)
    {
        int superficie;

        Console.WriteLine("Superficie mínima:");
        superficie = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            if (propiedades[i].GetSuperficie() >= superficie)
            {
                Console.WriteLine(propiedades[i]);
            }
        }
    }
}