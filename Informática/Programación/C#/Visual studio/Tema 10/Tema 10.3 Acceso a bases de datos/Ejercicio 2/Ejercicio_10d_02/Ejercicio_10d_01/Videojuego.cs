using System.Data.SQLite;

/*
 * Clase para gestionar los videojuegos de la colección
 */
class Videojuego
{
    private int id;
    private string titulo;
    private float precio;

    public float Precio
    {
        get { return precio; }
    }

    public Videojuego(string titulo, float precio)
    {
        this.titulo = titulo;
        this.precio = precio;
    }

    public Videojuego(int id, string titulo, float precio)
    {
        this.id = id;
        this.titulo = titulo;
        this.precio = precio;
    }

    public override string ToString()
    {
        return titulo + ": " + precio;
    }

    public bool Insertar(SQLiteConnection conexion)
    {
        string insercion = "INSERT INTO videojuegos (titulo, precio)" +
            " VALUES (@titulo, @precio)";
        SQLiteCommand cmd = new SQLiteCommand(insercion, conexion);
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@precio", precio);
        cmd.Prepare();
        int cantidad = cmd.ExecuteNonQuery();
        return cantidad == 1;
    }

    public bool Borrar(SQLiteConnection conexion)
    {
        string borrado = "DELETE FROM videojuegos WHERE id = @id";
        SQLiteCommand cmd = new SQLiteCommand(borrado, conexion);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Prepare();
        int cantidad = cmd.ExecuteNonQuery();
        return cantidad == 1;
    }

    public bool Actualizar(SQLiteConnection conexion)
    {
        string actualizacion = "UPDATE videojuegos SET titulo = @titulo, " +
            "precio = @precio WHERE id = @id";
        SQLiteCommand cmd = new SQLiteCommand(actualizacion, conexion);
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@precio", precio);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Prepare();
        int cantidad = cmd.ExecuteNonQuery();
        return cantidad == 1;
    }

    public static List<Videojuego> Listar(SQLiteConnection conexion)
    {
        List<Videojuego> resultado = new List<Videojuego>();
        string consulta = "SELECT * FROM videojuegos";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader resultados = cmd.ExecuteReader();
        while (resultados.Read())
        {
            int id = Convert.ToInt32(resultados[0]);
            string titulo = Convert.ToString(resultados[1]);
            float precio = Convert.ToSingle(resultados[2]);
            resultado.Add(new Videojuego(id, titulo, precio));
        }

        return resultado;
    }
}