/*Este programa solicita al alumno sus notas y calcula su media */
class Practica_1_1_1
{

    static void Main()
    {
        int examen, notaexamen, practica, notapractica, notafinal;

        Console.WriteLine("Escribe tus notas de examen");
        examen = Convert.ToInt32(System.Console.ReadLine());
        notaexamen = examen * 70 / 100;

        Console.WriteLine("Escribe tus notas de practicas");
        practica = Convert.ToInt32(System.Console.ReadLine());
        notapractica = practica * 30 / 100;

        notafinal = notaexamen + notapractica;

        Console.WriteLine("Su nota final,siendo su nota de examen un {0} " +
        "Y su nota practica un {1} es un {2}", examen, practica, notafinal);

    }
}
