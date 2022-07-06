/*
 * Programa que lee las tres primeras
 * líneas de un fichero
 */

string linea;

using (StreamReader fichero =
    new StreamReader("registroDeUsuario.txt"))
{
    for (int i = 0; i < 3; i++)
    {
        linea = fichero.ReadLine();
        Console.WriteLine(linea);
    }
}