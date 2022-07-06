string ruta = @".\CopiasCSharp";
string rutaUsuario;

// 1. Crear "CopiasCSharp"
Directory.CreateDirectory(ruta);

// 2. Pedir ruta al usuario
Console.WriteLine("Indica una carpeta:");
rutaUsuario = Console.ReadLine();

// 3. Obtener archivos .cs de ruta de usuario
DirectoryInfo raiz = new DirectoryInfo(rutaUsuario);
FileInfo[] archivos = 
    raiz.GetFiles("*.cs", SearchOption.AllDirectories);
foreach (FileInfo archivo in archivos)
{
    Console.WriteLine(archivo.FullName);
}

// 4. Copiar ficheros a ruta
foreach (FileInfo archivo in archivos)
{
    File.Copy(archivo.FullName, ruta + "\\" +
        archivo.Name, true);
}

// 5. Esperar a que el usuario pulsa una tecla
Console.WriteLine("Pulsa una tecla para continuar...");
Console.ReadKey(true);

// 6. Borrar archivos de menos de 500 bytes
DirectoryInfo destino = new DirectoryInfo(ruta);
FileInfo[] archivosDestino =
    destino.GetFiles("*.cs", SearchOption.AllDirectories);
foreach(FileInfo archivo in archivosDestino)
{
    if (archivo.Length < 500)
    {
        Console.WriteLine("Borrando " +
            archivo.FullName);
        File.Delete(archivo.FullName);
    }
}
