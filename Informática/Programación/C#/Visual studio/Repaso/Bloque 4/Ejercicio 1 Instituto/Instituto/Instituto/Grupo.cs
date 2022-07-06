/*
 * Clase para representar los grupos de distintos cursos
 */
class Grupo
{
    const int MAX_ALUMNOS = 25;

    private string codigo;
    private char letra;
    private string aula;
    private Curso curso;
    private Alumno[] alumnos;
    private int cantidadAlumnos;
    private Profesor tutor;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; } 
    }

    public char Letra
    {
        get { return letra; }
        set { letra = value; } 
    }

    public string Aula
    {
        get { return aula; }
        set { aula = value; }
    }

    public Curso Curso
    {
        get { return curso; }
        set { curso = value; }
    }

    public Profesor Tutor
    {
        get { return tutor; }
        set { tutor = value; }
    }

    public Grupo(string codigo, char letra, string aula, 
        Curso curso, Profesor tutor)
    {
        this.codigo = codigo;
        this.letra = letra;
        this.aula = aula;
        this.curso = curso;
        this.tutor = tutor;
        this.alumnos = new Alumno[MAX_ALUMNOS];
        this.cantidadAlumnos = 0;
    }

    public override string ToString()
    {
        string resultado = codigo + " - " + curso.Nombre + 
            " " + letra + " (Aula " + aula +
            ", " + tutor.Nombre + ")\n";

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            resultado += "\t" + alumnos[i].ToString() + "\n";
        }

        return resultado;
    } 

    public bool NuevoAlumno(Alumno a)
    {
        bool resultado = false;

        if (cantidadAlumnos < MAX_ALUMNOS)
        {
            alumnos[cantidadAlumnos] = a;
            cantidadAlumnos++;
            resultado = true;
        }

        return resultado;
    }
}