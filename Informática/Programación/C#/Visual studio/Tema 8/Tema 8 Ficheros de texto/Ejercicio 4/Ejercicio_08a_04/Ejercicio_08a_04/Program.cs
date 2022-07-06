/*
 * Programa que lee el fichero que diga el usuario
 * haciendo una pausa cada 24 líneas
 */
int contador = 0;
string nombreFichero;
string linea;

Console.WriteLine("Indica el nombre de fichero:");
nombreFichero = Console.ReadLine();
Console.Clear();

using(StreamReader fichero =
    new StreamReader(nombreFichero))
{
    while((linea = fichero.ReadLine()) != null)
    {
        contador++;
        Console.WriteLine(linea);
        if (contador == 24)
        {
            Console.ReadLine();
            contador = 0;
            Console.Clear();
        }
    }
}