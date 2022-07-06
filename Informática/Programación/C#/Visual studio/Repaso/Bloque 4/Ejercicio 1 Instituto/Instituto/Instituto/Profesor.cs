/*
 * Clase para representar al personal de tipo profesor
 */
class Profesor : Personal
{
    private string especialidad;

    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }

    public Profesor(string dni, string nombre,
        string telefono, string especialidad)
    : base(dni, nombre, telefono)
    {
        this.especialidad = especialidad;
    }
}