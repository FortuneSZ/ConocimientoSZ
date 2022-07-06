/*Este programa consiste en un menú que permite anyadir tenistas a una base de
datos,borrarlos de ella,ordenador,ya sea por nombre,pais o por sus estadisticas
*/

class Ejercicio1
{
    enum menu { Nuevo = 1, Borrar, Ordenar, porpais, mascompleto, salir }
    struct estadisticas
    {
        public float PorcAciertDer;
        public float PorcAciertRev;

    }

    struct Tenista
    {
        public string nombre;
        public string pais;
        public int anyonaci;
        public estadisticas estadistica;
    }

    static void lista(Tenista[] tenistas, ref int numtenista)
    {
        if (numtenista > 0)
        {
            Console.WriteLine("listado de tenistas");
            Console.WriteLine("");
            Console.WriteLine("Nombre del tenista (País,"
            + "Año de nacimiento): X% derecha, Y% revés");
            Console.WriteLine("");
            for (int i = 0; i < numtenista; i++)
            {
                Console.Write(tenistas[i].nombre + " (");
                Console.Write(tenistas[i].pais + ",");
                Console.Write(tenistas[i].anyonaci + "): ");
                Console.Write(tenistas[i].estadistica.
                PorcAciertDer + "% derecha, ");
                Console.WriteLine(tenistas[i].estadistica.
                PorcAciertRev + "% reves");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }

    static int anyadir(Tenista[] tenistas, ref int numtenista)
    {
        if (numtenista < tenistas.Length)
        {
            try
            {
                Console.WriteLine("introduzca el nombre del tenista");
                tenistas[numtenista].nombre = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("pais al que pertenece");
                tenistas[numtenista].pais = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("año de nacimiento del tenista");
                tenistas[numtenista].anyonaci =
                Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("porcentaje deaciertos" +
                "golpe de derecha");
                tenistas[numtenista].estadistica.PorcAciertDer
                = Convert.ToSingle(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("porcentaje deaciertos" +
                "golpe de reves");
                tenistas[numtenista].estadistica.PorcAciertRev =
                Convert.ToSingle(Console.ReadLine());

                if (tenistas[numtenista].estadistica.
                PorcAciertDer < 0 || tenistas[numtenista].
                estadistica.PorcAciertDer > 100 ||
                tenistas[numtenista].estadistica.
                PorcAciertRev < 0 || tenistas[numtenista].
                estadistica.PorcAciertRev > 100)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error al introducir los datos");
                    tenistas[numtenista].nombre = "";
                    tenistas[numtenista].pais = "";
                    tenistas[numtenista].anyonaci = 0;
                    tenistas[numtenista].estadistica.
                    PorcAciertDer = 0;
                    tenistas[numtenista].estadistica.
                    PorcAciertRev = 0;
                    Console.ReadLine();
                    Console.Clear();
                }

                else
                {
                    Console.Clear();
                    numtenista++;
                    lista(tenistas, ref numtenista);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error al introducir los datos");
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("la lista esta llena");
        }
        return numtenista;
    }

    static int borrar(Tenista[] tenistas, ref int numtenista, int seleccion)
    {
        Console.WriteLine("elije el tenista que quieres borrar");
        seleccion = Convert.ToInt32(Console.ReadLine());
        if (seleccion <= 0 || seleccion > numtenista)
        {
            Console.WriteLine("seleccion no valida");
            Console.Clear();
        }
        else
        {
            for (int i = seleccion; i <= numtenista; i++)
            {
                tenistas[i - 1] = tenistas[i];
            }
            numtenista--;
            Console.Clear();
            lista(tenistas, ref numtenista);
        }
        return numtenista;
    }

    static void ordenar(Tenista[] tenistas, int numtenista)
    {
        if (numtenista > 0)
        {
            for (int i = 0; i < numtenista - 1; i++)
            {
                for (int j = i + 1; j < numtenista; j++)
                {
                    if (tenistas[i].nombre.CompareTo(tenistas[j].
                    nombre) > 0)
                    {
                        Tenista auxiliar = tenistas[i];
                        tenistas[i] = tenistas[j];
                        tenistas[j] = auxiliar;
                    }
                }

            }
            lista(tenistas, ref numtenista);
        }
    }

    static void porpais(Tenista[] tenistas, int numtenista)
    {
        string paiss;
        bool encontrado = false;
        Console.WriteLine("Introduzca el país que quiere buscar");
        paiss = Console.ReadLine();
        Console.Clear();

        for (int i = 0; i < numtenista; i++)
        {
            if (tenistas[i].pais.ToUpper().Contains(paiss.ToUpper()))
            {
                encontrado = true;
            }
        }
        if (encontrado == true)
        {
            Console.WriteLine("listado de tenistas");
            Console.WriteLine("");
            Console.WriteLine("Nombre del tenista (País,"
            + "Año de nacimiento): X% derecha, Y% revés");
            Console.WriteLine("");

            for (int i = 0; i < numtenista; i++)
            {
                if (tenistas[i].pais.ToUpper().Contains(paiss.ToUpper()))
                {
                    Console.Write(tenistas[i].nombre + " (");
                    Console.Write(tenistas[i].pais + ",");
                    Console.Write(tenistas[i].anyonaci + "): ");
                    Console.Write(tenistas[i].estadistica.
                    PorcAciertDer + "% derecha, ");
                    Console.WriteLine(tenistas[i].estadistica.
                    PorcAciertRev + "% reves");
                }
            }
        }
        else
        {
            Console.WriteLine("No se han encontrado resultados");
        }
        Console.ReadLine();
        Console.Clear();
    }

    static void mascompleto(Tenista[] tenistas, int numtenista)
    {
        if (numtenista > 0)
        {
            for (int i = 0; i < numtenista - 1; i++)
            {
                for (int j = i + 1; j < numtenista; j++)
                {
                    if (tenistas[i].estadistica.PorcAciertDer +
                    tenistas[i].estadistica.PorcAciertRev / 2 <
                    tenistas[j].estadistica.PorcAciertDer +
                    tenistas[j].estadistica.PorcAciertRev / 2)
                    {
                        Tenista auxiliar = tenistas[i];
                        tenistas[i] = tenistas[j];
                        tenistas[j] = auxiliar;
                    }
                }

            }
            Console.WriteLine("Tenista más completo");
            Console.WriteLine("");
            Console.WriteLine("Nombre del tenista (País,"
            + "Año de nacimiento): X% derecha, Y% revés");
            Console.WriteLine("");

            Console.Write(tenistas[0].nombre + " (");
            Console.Write(tenistas[0].pais + ",");
            Console.Write(tenistas[0].anyonaci + "): ");
            Console.Write(tenistas[0].estadistica.
            PorcAciertDer + "% derecha, ");
            Console.WriteLine(tenistas[0].estadistica.
            PorcAciertRev + "% reves");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void salir()
    {
        Console.WriteLine("ha seleccionado salir");
    }
    static void Main()
    {
        Tenista[] tenistas = new Tenista[60];
        int eleccion, seleccion = 0, numtenista = 0;
        do
        {
            Console.WriteLine((int)menu.Nuevo + " nuevo tenista");
            Console.WriteLine((int)menu.Borrar + " borrar tenista");
            Console.WriteLine((int)menu.Ordenar + " ordenar tenistas");
            Console.WriteLine((int)menu.porpais + " tenistas por pais");
            Console.WriteLine((int)menu.mascompleto + " tenista mas completo");
            Console.WriteLine((int)menu.salir + " salir");
            Console.WriteLine("");
            Console.WriteLine("elija la opcion que desea");
            eleccion = Convert.ToInt32(Console.ReadLine());

            switch ((menu)eleccion)
            {
                case menu.salir:
                    Console.Clear();
                    salir();
                    break;

                case menu.Nuevo:
                    Console.Clear();
                    anyadir(tenistas, ref numtenista);
                    break;

                case menu.Borrar:
                    Console.Clear();
                    borrar(tenistas, ref numtenista, seleccion);
                    break;

                case menu.Ordenar:
                    Console.Clear();
                    ordenar(tenistas, numtenista);
                    break;

                case menu.porpais:
                    Console.Clear();
                    porpais(tenistas, numtenista);
                    break;

                case menu.mascompleto:
                    Console.Clear();
                    mascompleto(tenistas, numtenista);
                    break;
            }
        }
        while (eleccion != (int)menu.salir);
    }
}
