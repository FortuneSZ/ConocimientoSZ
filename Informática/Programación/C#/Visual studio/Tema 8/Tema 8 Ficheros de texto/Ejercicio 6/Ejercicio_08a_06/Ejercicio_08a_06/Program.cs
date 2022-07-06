/*
 * Programa que lee las líneas de un fichero, las
 * almacena en una lista, las ordena y las guarda
 * en un fichero de salida quitando las duplicadas
 */
List<string> lineas = new List<string>();
string linea;

using(StreamReader fichero =
    new StreamReader("entrada.txt"))
{
    while((linea = fichero.ReadLine()) != null)
    {
        if(!lineas.Contains(linea))
        {
            lineas.Add(linea);
        }
    }
}

lineas.Sort();

using(StreamWriter fichero = 
    new StreamWriter("salida.txt"))
{
    foreach(string l in lineas)
    {
        fichero.WriteLine(l);
    }
}