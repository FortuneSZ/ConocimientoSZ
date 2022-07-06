/*Este programa le pedirá al usuario que rellene un array de nombres del tamaño
10,posteriormente le pedirá al usuario que escriba una palabra o letra,y si esta
se encuentra en alguna palabra del array le dirá en cuales y su posición,esto
se repetirá hasta que el usuario escriba fin*/
class Ejercicio_04c_06
{
    static void Main()
    {
        bool encontrado = false;
        int contador = 1;
        string palabraabuscar = "";
        string[] palabras = new string[10];
        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine("escriba la {0} palabras", contador);
            palabras[i] = Console.ReadLine();
            contador++;
        }
        Console.Clear();
        do
        {
            encontrado = false;
            Console.WriteLine("Escribe el texto a buscar:");
            palabraabuscar = Console.ReadLine();
            if (palabraabuscar != "fin")
            {
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i].Contains(palabraabuscar))
                    {
                        encontrado = true;
                        Console.WriteLine("Encontrado en posicion {0}", i + 1);
                        Console.WriteLine("");
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("No se ha encontrado");
                    Console.WriteLine("");
                }
            }
        }
        while (palabraabuscar != "fin");
    }
}
