/*Este programa consiste en un menu que permite interactuar con un diccionario
 de coches definido previamente,este permite añadir mantenimientos a coches,
ver cual es el que tiene mayor gasto en mantenimientos y sus datos
,ver la lista de vehículos,eliminar un coche del diccionario y reemplazarlo
por otro y salir*/
class Principal
{
    static void Problematic(Dictionary<string, Coche> coches)
    {
        foreach (KeyValuePair<string, Coche> result in coches)
        {
            Console.WriteLine(result.Value);
        }
    }
    static void Replace(Dictionary<string, Coche> coches)
    {
        string mat;
        Console.WriteLine("Escriba la matrícula del coche a eliminar");
        mat = Console.ReadLine();
        if (coches.ContainsKey(mat))
        {
            coches.Remove(mat);
            Console.Clear();
            Console.WriteLine("Introduzca la matricula");
            string matricula = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca la marca");
            string marca = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca el modelo");
            string modelo = Console.ReadLine();
            coches.Add(matricula, new Coche(matricula, marca, modelo));
        }

    }
    static void Color()
    {
        if (Console.ForegroundColor == ConsoleColor.Red)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
    static void Menu(Dictionary<string, Coche> coches)
    {
        int eleccion;
        do
        {
            Console.Clear();

            Color();
            Console.WriteLine(">=>       >=> >=======> >==>    >=> >=>     >=>");
            Console.WriteLine(">> >=>   >>=> >=>       >> >=>  >=> >=>     >=>");
            Console.WriteLine(">=> >=> > >=> >=>       >=> >=> >=> >=>     >=>");
            Console.WriteLine(">=>  >=>  >=> >=====>   >=>  >=>>=> >=>     >=>");
            Console.WriteLine(">=>   >>  >=> >=>       >=>   > >=> >=>     >=>");
            Console.WriteLine(">=>       >=> >=>       >=>    >>=> >=>     >=>");
            Console.WriteLine(">=>       >=> >=======> >=>     >=>   >====>");
            Color();
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         Elija una opción del menú");
            Color();
            Console.WriteLine("          *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         1. Nuevo mantenimiento");
            Color();
            Console.WriteLine("             *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         2. Coche más problemático");
            Color();
            Console.WriteLine("          *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         3. Listar coches");
            Color();
            Console.WriteLine("                   *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         4. Reemplazar coche");
            Color();
            Console.WriteLine("                *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            Console.Write("* ");
            Color();
            Console.Write("         5. Salir");
            Color();
            Console.WriteLine("                           *");
            Console.WriteLine("^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^");
            eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.Clear();
                    Mantenimiento(coches);
                    break;
                case 2:
                    Problematic(coches);
                    break;
                case 3:
                    Console.Clear();
                    Lista(coches);
                    break;
                case 4:
                    Console.Clear();
                    Replace(coches);
                    break;
                case 5:
                    break;
            }
        }
        while (eleccion != 5);
    }
    static void Lista(Dictionary<string, Coche> coches)
    {

        foreach (KeyValuePair<string, Coche> result in coches)
        {
            Console.WriteLine(result.Value);
        }
        Console.WriteLine();
        Console.WriteLine("Pulse enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    static void Mantenimiento(Dictionary<string, Coche> coches)
    {
        string matricula;
        Console.WriteLine("Introduzca la matricula del coche");
        matricula = Console.ReadLine();
        if (coches.ContainsKey(matricula))
        {
            Console.Clear();
            Console.WriteLine("Introduzca la fecha del mantenimiento");
            string fech = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca la descripcion del mantenimiento");
            string desc = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca el precio del mantenimiento");
            float precio = Convert.ToSingle(Console.ReadLine());
            Mantenimiento mant = new Mantenimiento(fech, desc, precio);
            coches[matricula].AddMant(mant);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Coche no encontrado");
            Console.WriteLine();
            Console.WriteLine("Pulse enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
    static void Main()
    {
        Dictionary<string, Coche> coches = new Dictionary<string, Coche>();
        coches.Add("4999FTN", new Coche("4999FTN", "Fortune", "Zadquiel"));
        coches.Add("3114AMA", new Coche("3114AMA", "Comuwaifu", "Lolfu"));
        coches.Add("9010KIR", new Coche("9010KIR", "Kirby", "Poio"));
        Menu(coches);

    }
}
