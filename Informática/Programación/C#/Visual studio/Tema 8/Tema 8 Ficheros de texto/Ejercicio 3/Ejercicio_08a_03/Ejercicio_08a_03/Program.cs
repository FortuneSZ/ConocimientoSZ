/*
 * Programa que lee líneas de un fichero buscando 
 * el texto "programa"
 */

const string TEXTO_BUSCAR = "programa";
const string FICHERO = "datos.txt";
int contador = 0;
string linea;

using (StreamReader fichero =
    new StreamReader(FICHERO))
{
    while((linea = fichero.ReadLine()) != null)
    {
        contador++;
        if (linea.Contains(TEXTO_BUSCAR))
        {
            Console.WriteLine("{0}: {1}",
                contador, linea);
        }
    }
}
