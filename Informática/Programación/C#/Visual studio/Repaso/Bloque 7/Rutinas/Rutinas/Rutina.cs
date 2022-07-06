using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

/*
 * Clase para definir los distintos tipos de rutinas
 */
[Serializable]
abstract class Rutina
{
    const string FICHERO_RUTINAS = "rutinas.dat";

    protected string descripcion;
    protected DateTime fecha;
    protected int duracion;
    protected int calorias;

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    public int Duracion
    {
        get { return duracion; }
        set { duracion = value; }
    }

    public int Calorias
    {
        get { return calorias; }
        set { calorias = value; }
    }

    public Rutina()
    { }

    public Rutina(string descripcion, DateTime fecha, int duracion, int calorias)
    {
        this.descripcion = descripcion;
        this.fecha = fecha;
        this.duracion = duracion;
        this.calorias = calorias;
    }

    public override string ToString()
    {
        return descripcion + "\n" + 
            fecha.ToString("d") + ", " +
            duracion + " minutos, " +
            calorias + " cal.";
    }

    public static List<Rutina> LeerRutinas()
    {
        List<Rutina> rutinas = new List<Rutina>();
        if (File.Exists(FICHERO_RUTINAS))
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(FICHERO_RUTINAS,
                FileMode.Open, FileAccess.Read, FileShare.Read);
            rutinas = (List<Rutina>)formatter.Deserialize(stream);
            stream.Close();
        }

        return rutinas;
    }

    public static void GuardarRutinas(List<Rutina> rutinas)
    {
        List<Rutina> rutinasMesActual =
            rutinas.Where(r => r.Fecha.Month == DateTime.Now.Month &&
                          r.Fecha.Year == DateTime.Now.Year).ToList();

        IFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(FICHERO_RUTINAS,
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, rutinasMesActual);
        stream.Close();
    }
}