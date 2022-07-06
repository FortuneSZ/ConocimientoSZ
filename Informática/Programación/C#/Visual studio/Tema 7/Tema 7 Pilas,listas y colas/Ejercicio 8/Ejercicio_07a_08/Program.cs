/*Este programa pide al usuario que introduzca libros en un formato específico
 con esos datos creará libros que añadirá a una lista,una vez el usuario 
introduzca una cadena vacía la lista se ordenará por título y se mostrará
por pantalla*/
class Principal
{
    static void Main()
    {
        int numpag;
        string texto;
        string[] partes;
        List<Libro> lista = new List<Libro>();

        do
        {
            Console.WriteLine("Introduzca libros,formato " + "titulo;paginas");
            texto = Console.ReadLine();
            if (texto != "")
            {
                partes = texto.Split(';');
                numpag = Convert.ToInt32(partes[1]);
                lista.Add(new Libro(partes[0], numpag));
            }
            Console.Clear();
        }
        while (texto != "");

        lista.Sort();
        Console.Clear();
        Console.WriteLine("Lista ordenada");
        Console.WriteLine("");
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}
