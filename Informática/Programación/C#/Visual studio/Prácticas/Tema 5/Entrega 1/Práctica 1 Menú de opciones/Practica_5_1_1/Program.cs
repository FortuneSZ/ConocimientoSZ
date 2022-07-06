/*Este programa mostrará un menú de opciones (situado en una función) y lo
mostrará repetidamente hasta que el usuario introduzca una opción correcta,
cuando lo haga mostrará un mensaje indicando que opción escogió*/

class Practica_5_1_1
{
    static int ImprimirMenu(string[] elecmenu, int min, int max)
    {
        int eleccion = 0;
        do
        {
            foreach (string opcion in elecmenu)
            {
                Console.WriteLine(opcion);
            }
            try
            {
                Console.WriteLine("Elije una opción");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (eleccion < min || eleccion > max);
        return eleccion;
    }



    static void Main()
    {
        int eleccion, min = 1, max = 5;
        string[] elecmenu = new string[] {"1.Insertar nuevo elemento",
                "2.Borrar elemento", "3.Mostrar elementos", "4.Buscar elemento",
                "5.Salir"};

        eleccion = ImprimirMenu(elecmenu, min, max);
        Console.WriteLine("has elegido la opción {0}", eleccion);
    }
}
