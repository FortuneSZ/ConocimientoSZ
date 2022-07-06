/*
 * Programa que copia el fichero de texto que diga
 * el usuario en otro con el mismo nombre y con el
 * prefijo "copia_de_"
 */
string nombreFichero;

Console.WriteLine("Elige un fichero:");
nombreFichero = Console.ReadLine();

try
{
    /*
    string[] lineas = 
        File.ReadAllLines(nombreFichero);
    File.WriteAllLines("copia_de_" +nombreFichero, 
        lineas);
    */

    using (StreamReader lectura =
        new StreamReader(nombreFichero))
    using (StreamWriter escritura =
        new StreamWriter("copia_de_" + nombreFichero))
    {
        string linea;
        while ((linea = lectura.ReadLine()) != null)
        {
            escritura.WriteLine(linea);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}