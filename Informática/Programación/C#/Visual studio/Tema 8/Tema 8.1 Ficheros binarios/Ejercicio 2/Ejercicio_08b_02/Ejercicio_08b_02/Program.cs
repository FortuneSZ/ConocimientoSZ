/*
 * Programa que comprueba si un BMP está comprimido
 */
byte dato;

using (FileStream fichero =
        new FileStream("ejemplo.bmp", FileMode.Open))
{
    fichero.Seek(30, SeekOrigin.Begin);
    dato = (byte)fichero.ReadByte();
    if (dato == 0)
    {
        Console.WriteLine("El BMP NO está comprimido");
    }
    else
    {
        Console.WriteLine("El BMP está comprimido");
    }
}