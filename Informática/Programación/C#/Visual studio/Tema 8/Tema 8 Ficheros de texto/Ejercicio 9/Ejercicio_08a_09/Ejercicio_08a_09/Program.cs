/*
 * Programa que lee las líneas de un fichero, las
 * almacena en un array, las ordena y las guarda
 * en un fichero de salida quitando las duplicadas
 */

string[] lineas = File.ReadAllLines("entrada.txt");
Array.Sort(lineas);

using (StreamWriter fichero =
    new StreamWriter("salida.txt"))
{
    for(int i = 0; i < lineas.Length; i++)
    {
        if (i == 0 || lineas[i] != lineas[i-1])
        {
            fichero.WriteLine(lineas[i]);
        }
    }
}