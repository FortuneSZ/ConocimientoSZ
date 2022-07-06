/*
 * Programa que encripta/desencripta una imagen BMP
 * intercambiando sus dos primeros bytes
 */
byte dato1, dato2;

using (FileStream fichero =
    File.Open("ejemplo.bmp", FileMode.Open,
    FileAccess.ReadWrite))
{
    dato1 = (byte)fichero.ReadByte();
    dato2 = (byte)fichero.ReadByte();
    fichero.Seek(0, SeekOrigin.Begin);
    fichero.WriteByte(dato2);
    fichero.WriteByte(dato1);
}