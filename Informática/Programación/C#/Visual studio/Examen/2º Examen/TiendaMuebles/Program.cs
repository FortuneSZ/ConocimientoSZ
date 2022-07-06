class programa
{
    static void Datosmuebles(Muebles nuevomueble, int opcion,
        Muebles[] muebles, int i)
    {
        Console.Clear();
        Console.WriteLine("Escriba el código del mueble");
        string codigo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba el nombre del mueble");
        string nombre = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Escriba el precio del mueble");
        int precio = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (opcion == 1)
        {
            Console.WriteLine("Escriba las puertas del armario");
            int puertas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (puertas >= 1 && puertas <= 4)
            {
                nuevomueble = new Armario(codigo, nombre, precio, puertas);
                muebles[i] = nuevomueble;
            }

        }
        else if (opcion == 2)
        {
            Console.WriteLine("Escriba El tipo de colchón de la cama");
            string colchon = Console.ReadLine();
            Console.Clear();
            nuevomueble = new Cama(codigo, nombre, precio, colchon);
            muebles[i] = nuevomueble;

        }
        else if (opcion == 3)
        {
            Console.WriteLine("Escriba El color del escritorio");
            string color = Console.ReadLine();
            Console.Clear();
            nuevomueble = new Escritorio(codigo, nombre, precio, color);
            muebles[i] = nuevomueble;
        }
    }
    static void Main()
    {
        string codigo;
        Muebles[] muebles = new Muebles[4];
        Muebles nuevomueble = null;
        for (int i = 0; i < muebles.Length; i++)
        {
            int opcion = 0;
            Console.WriteLine("Elija su " + (i + 1) + " opción");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Armario");
            Console.WriteLine(" 2 - Cama");
            Console.WriteLine(" 3 - Escritorio");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ha seleccionado Armario");
                    Datosmuebles(nuevomueble, opcion, muebles, i);
                    Console.WriteLine("");


                    break;
                case 2:
                    Console.WriteLine("ha seleccionado Cama");
                    Datosmuebles(nuevomueble, opcion, muebles, i);
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("ha seleccionado Escritorio");
                    Datosmuebles(nuevomueble, opcion, muebles, i);
                    Console.WriteLine("");
                    break;
            }
        }
        Pack[] paquete = new Pack[3];
        paquete[0] = new Pack(muebles, "12345", "salón");
        paquete[1] = new Pack(muebles, "75395", "Cocina");
        paquete[2] = new Pack(muebles, "15975", "Comedor");

        Console.WriteLine("Elija una opción de este menú");
        int eleccion = 0;
        do
        {
            Console.WriteLine(" 1 - Comprar mueble suelto");
            Console.WriteLine(" 2 - Comprar pack");
            Console.WriteLine(" 3 - Salir");
            eleccion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (eleccion)
            {
                case 1:
                    for (int i = 0; i < muebles.Length; i++)
                    {
                        Console.WriteLine(muebles[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Escriba el código del mueble");
                    codigo = Console.ReadLine();
                    break;
                case 2:
                    for (int i = 0; i < paquete.Length; i++)
                    {
                        Console.WriteLine(paquete[i]);
                        Console.WriteLine("");
                        Console.WriteLine("Escriba el código del mueble");
                        codigo = Console.ReadLine();
                    }
                    break;
            }
        }
        while (eleccion != 3);


    }
}
