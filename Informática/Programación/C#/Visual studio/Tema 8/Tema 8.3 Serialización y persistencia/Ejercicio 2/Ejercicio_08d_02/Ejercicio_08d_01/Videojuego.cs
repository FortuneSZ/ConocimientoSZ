/*
 * Clase con los datos de los videojuegos a serializar
 */
using System.Text.Json;

class Videojuego
{
    private const string FICHERO = "videojuegos.json";

    private string titulo;
    private string genero;
    private float precio;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

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
            string jsonString = File.ReadAllText(FICHERO);
            listado = 
                JsonSerializer.Deserialize<List<Videojuego>>(jsonString);
        }
        return listado;
    }

    public static void GuardarVideojuegos(List<Videojuego> listado)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(listado, opciones);
        File.WriteAllText(FICHERO, jsonString);
    }
}