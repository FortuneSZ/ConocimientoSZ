/*
 * Clase con los datos de los videojuegos a serializar
 */
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Videojuego
{
    private const string FICHERO = "videojuegos.dat";

    private string titulo;
    private string genero;
    private float precio;

    public Videojuego(string titulo, string genero, float precio)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
    }

    public override string ToString()
    {
        return titulo + ", " + genero + ", " + precio;
    }

    public static List<Videojuego> LeerVideojuegos()
    {
        List<Videojuego> listado = new List<Videojuego>();
        if (File.Exists(FICHERO))
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(FICHERO,
                FileMode.Open, FileAccess.Read, FileShare.Read);
            listado = (List<Videojuego>)formatter.Deserialize(stream);
            stream.Close();
        }
        return listado;
    }

    public static void GuardarVideojuegos(List<Videojuego> listado)
    {
        IFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(FICHERO,
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, listado);
        stream.Close();
    }
}