/*
 * Alumnos del instituto
 */
class Alumno
{
    private int nia;
    private string nombre;
    private string email;
    private Grupo grupo;

    public int Nia
    {
        get { return nia; }
        set { nia = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public Grupo Grupo
    {
        get { return grupo; }
        set { grupo = value; }
    }

    public Alumno(int nia, string nombre, string email,
        Grupo grupo)
    {
        this.nia = nia;
        this.nombre = nombre;
        this.email = email;
        this.grupo = grupo;

        // Acceder al grupo y meter el alumno this en el array
        this.grupo.NuevoAlumno(this);
    }

    public override string ToString()
    {
        return nia + " - " + nombre + " - " + email + " - " +
            grupo.Curso.Nombre + " " + grupo.Letra;
    }
}