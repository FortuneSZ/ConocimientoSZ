/*
 * Gestión de videojuegos en una base de datos
 */
using System.Data.SQLite;

class GestionVideojuegos
{
    private SQLiteConnection conexion;

    public void CrearConexion()
    {
        if (!File.Exists("videojuegos.sqlite"))
        {
            conexion =
                new SQLiteConnection("Data Source=videojuegos.sqlite;Version=3;New=True;Compress=True;");
            conexion.Open();
            CrearTablas();
        }
        else
        {
            conexion =
                new SQLiteConnection("Data Source=videojuegos.sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();
        }
    }

    public void CrearTablas()
    {
        string creacion = "CREATE TABLE videojuegos " +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "titulo VARCHAR(200) NOT NULL, " +
            "precio FLOAT NOT NULL);";

        SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
        cmd.ExecuteNonQuery();
    }

    public void CrearVideojuego()
    {
        string titulo;
        float precio;

        Console.WriteLine("Escribe el título:");
        titulo = Console.ReadLine();
        Console.WriteLine("Escribe el precio:");
        precio = Convert.ToSingle(Console.ReadLine());

        string insercion = "INSERT INTO videojuegos (titulo, precio)" +
            " VALUES (@titulo, @precio)";
        SQLiteCommand cmd = new SQLiteCommand(insercion, conexion);
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@precio", precio);
        cmd.Prepare();
        int cantidad = cmd.ExecuteNonQuery();
        if (cantidad < 1)
            Console.WriteLine("No se ha podido insertar");
    }

    public void ListarVideojuegos(bool pedir)
    {
        string consulta;
        SQLiteCommand cmd;
        if (pedir)
        {
            Console.WriteLine("Escribe el precio máximo:");
            float precio = Convert.ToSingle(Console.ReadLine());
            consulta = "SELECT * FROM videojuegos WHERE precio < @precio";
            cmd = new SQLiteCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Prepare();
        }
        else
        {
            consulta = "SELECT * FROM videojuegos";
            cmd = new SQLiteCommand(consulta, conexion);
        }

        SQLiteDataReader resultados = cmd.ExecuteReader();
        while (resultados.Read())
        {
            string titulo = Convert.ToString(resultados[1]);
            float precio = Convert.ToSingle(resultados[2]);
            Console.WriteLine("{0}: {1}", titulo, precio.ToString("0.00"));
        }
    }

    public void CerrarConexion()
    {
        conexion.Close();
    }
}