class Principal
{
    static void Comprobar(string linea, string linea2, StreamReader fichero1b,
        StreamReader fichero2b)
    {
        int igual = 0;
        string lineaPrueba;
        do
        {
            lineaPrueba = fichero2b.ReadLine();
            if (linea == lineaPrueba)
            {
                igual++;
            }
        }
        while (lineaPrueba != null);
        if (igual > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        igual = 0;
    }
    static void Main()
    {
        int num = 1, num2 = 1;
        string ruta = "D:\\Escritorio\\DAM\\Programación\\Programación\\" +
            "Ejercicios y apuntes\\C#\\Visual studio\\Examen" +
            "\\Examen archivos\\" + "ComprobarDiferencias\\diferencias\\";
        string ruta2 = ruta, linea, linea2;
        string archivo1, archivo2;
        Console.WriteLine("Elija el primer archivo que quiere comprobar");
        archivo1 = Console.ReadLine();

        Console.WriteLine("Elija el segundo archivo que quiere comprobar");
        archivo2 = Console.ReadLine();

        ruta = ruta + archivo1;
        ruta2 = ruta2 + archivo2;

        if (File.Exists(ruta) && File.Exists(ruta2))
        {
            Console.Clear();
            Console.WindowWidth = 80;
            Console.WindowHeight = 25;
            StreamReader fichero = File.OpenText(ruta);
            StreamReader fichero1b = File.OpenText(ruta);
            StreamReader fichero2 = File.OpenText(ruta2);
            StreamReader fichero2b = File.OpenText(ruta2);
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(num.ToString("000."));
                Console.ResetColor();
                linea = fichero.ReadLine();
                if (linea != null && linea.Length > 39)
                {
                    linea = linea.Substring(0, 39);
                }
                Console.Write(linea);
                Console.ResetColor();
                num++;

                Console.SetCursorPosition(40, num2);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(num2.ToString("000."));
                Console.ResetColor();
                linea2 = fichero2.ReadLine();
                if (linea2 != null && linea2.Length > 36)
                {
                    linea2 = linea2.Substring(0, 36);
                }
                Console.WriteLine(linea2);
                num2++;
            }
            while (linea != null);
        }
    }
}
