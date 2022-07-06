/*
 * Programa que lee los 3 primeros bytes de un GIF
 * para ver si es correcto
 */

char letra1, letra2, letra3;

using (FileStream fichero =
    new FileStream("ejemplo.gif", FileMode.Open))
{
    letra1 = (char)fichero.ReadByte();
    letra2 = (char)fichero.ReadByte();
    letra3 = (char)fichero.ReadByte();

    if(letra1 == 'G' && letra2 == 'I' && letra3 == 'F')
    {
        Console.WriteLine("GIF válido");
    }
    else
    {
        Console.WriteLine("GIF NO válido");
    }
}