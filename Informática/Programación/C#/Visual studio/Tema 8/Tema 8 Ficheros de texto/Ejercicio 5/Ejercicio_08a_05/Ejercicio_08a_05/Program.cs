/*
 * Programa que carga un fichero en una lista
 * y pide textos al usuario para buscar
 */
List<string> lineas = new List<string>();
string linea, textoABuscar;
int contador = 0;

using(StreamReader fichero =
    new StreamReader("datos.txt"))
{
    while((linea = fichero.ReadLine()) != null)
    {
        lineas.Add(linea);
    }
}

Console.WriteLine("Escribe textos. Cadena vacía para terminar");
do
{
    textoABuscar = Console.ReadLine();
    if (textoABuscar != "")
    {
        contador = 0;
        foreach (string l in lineas)
        {
            contador++;
            if (l.Contains(textoABuscar))
            {
                Console.WriteLine("{0}: {1}",
                    contador, l);
            }
        }
    }
}
while (textoABuscar != "");
