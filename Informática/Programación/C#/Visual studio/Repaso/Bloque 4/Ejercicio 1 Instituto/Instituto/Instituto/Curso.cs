/*
 * Clase para gestionar los cursos del instituto
 */
class Curso
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
    }

    public Curso(string nombre)
    {
        this.nombre = nombre;
    }
}