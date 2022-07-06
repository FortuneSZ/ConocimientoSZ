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

    public void CerrarConexion()
    {
        conexion.Close();
    }

    public SQLiteConnection getConexion()
    {
        return conexion;
    }
}