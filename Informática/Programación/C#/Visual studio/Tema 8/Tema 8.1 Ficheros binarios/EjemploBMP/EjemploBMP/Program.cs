/*
 * Programa que lee diferentes datos de un BMP
 */
using (BinaryReader fichero =
    new BinaryReader(File.Open("ejemplo.bmp", 
    FileMode.Open)))
{
    fichero.BaseStream.Seek(18, SeekOrigin.Begin);
    int anchura = fichero.ReadInt32();
    int altura = fichero.ReadInt32();
    Console.WriteLine("La anchura es de {0} píxeles", 
        anchura);
    Console.WriteLine("La altura es de {0} píxeles",
        altura);

    fichero.BaseStream.Seek(2, SeekOrigin.Begin);
    int tamano = fichero.ReadInt32();
    Console.WriteLine("Imagen de {0} bytes", tamano);
}