using System;

class Program
{
    static Grupo BuscarGrupo(Grupo[] grupos, string codigo)
    {
        Grupo resultado = null;

        for (int i = 0; i < grupos.Length; i++)
        {
            if (grupos[i].Codigo == codigo)
            {
                resultado = grupos[i];
            }
        }

        return resultado;
    }

    static void Main()
    {
        Personal[] personal = new Personal[5];
        personal[0] = new Profesor("11111A", "Profesor1",
            "612345678", "Matemáticas");
        personal[1] = new Profesor("22222B", "Profesor2",
            "611223344", "Física");
        personal[2] = new Administrativo("33333C", "Administrativo1",
            "699887766", 'A');
        personal[3] = new Profesor("44444D", "Profesor3",
            "655443322", "Informática");
        personal[4] = new Administrativo("555555E", "Administrativo2",
            "655778844", 'B');

        Curso[] cursos = new Curso[3];
        cursos[0] = new Curso("1º DAM");
        cursos[1] = new Curso("1º DAW");
        cursos[2] = new Curso("3º ESO");

        Grupo[] grupos = new Grupo[3];
        grupos[0] = new Grupo("1CFSA", 'B', "E204", 
            cursos[0], (Profesor)personal[0]);
        grupos[1] = new Grupo("1CFSB", 'A', "I101", 
            cursos[1], (Profesor)personal[1]);
        grupos[2] = new Grupo("3ESOC", 'C', "A022", 
            cursos[2], (Profesor)personal[3]);

        foreach (Grupo g in grupos)
        {
            Console.WriteLine(g);
        }

        // Parte 2: rellenar alumnos

        Alumno[] alumnos = new Alumno[5];
        int nia;
        string nombre, email, codigoGrupo;
        Grupo grupoAux;

        for (int i = 0; i < alumnos.Length; i++)
        {
            Console.WriteLine("NIA del alumno:");
            nia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre del alumno:");
            nombre = Console.ReadLine();
            Console.WriteLine("Email del alumno:");
            email = Console.ReadLine();
            Console.WriteLine("Código del grupo:");
            codigoGrupo = Console.ReadLine();
            grupoAux = BuscarGrupo(grupos, codigoGrupo);

            if (grupoAux != null)
            {
                alumnos[i] = new Alumno(nia, nombre, email, grupoAux);
            }
            else
            {
                // No se añade el alumno al array. Posición nula
                // Se puede corregir con "while" o con un grupo por defecto
            }
        }

        foreach(Alumno a in alumnos)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("Escribe un código de grupo:");
        codigoGrupo = Console.ReadLine();
        grupoAux = BuscarGrupo(grupos, codigoGrupo);
        Console.WriteLine(grupoAux);
    }
}
