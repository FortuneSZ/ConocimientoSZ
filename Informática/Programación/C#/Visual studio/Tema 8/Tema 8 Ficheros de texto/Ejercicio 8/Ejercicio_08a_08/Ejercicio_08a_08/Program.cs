/*
 * Programa que acumula en un fichero las
 * frases introducidas por el usuario
 */
string linea;

using(StreamWriter fichero =
    new StreamWriter("log.txt", true))
{
    Console.WriteLine("Escribe líneas. Cadena vacía para terminar");
    do
    {
        linea = Console.ReadLine();
        if (linea != "")
            fichero.WriteLine(linea);
    }
    while (linea != "");
}