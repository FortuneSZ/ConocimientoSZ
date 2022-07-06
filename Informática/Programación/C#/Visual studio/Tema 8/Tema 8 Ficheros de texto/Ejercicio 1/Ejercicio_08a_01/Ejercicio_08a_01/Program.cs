/*
 * Programa que guarda las líneas que escribe
 * el usuario en un fichero hasta que escriba
 * cadena vacía
 */
string linea;

Console.WriteLine("Escribe líneas. Cadena vacía para terminar");

using(StreamWriter fichero = 
    new StreamWriter("registroDeUsuario.txt"))
{
    do
    {
        linea = Console.ReadLine();
        if (linea != "")
        {
            fichero.WriteLine(linea);
        }
    }
    while (linea != "");
}