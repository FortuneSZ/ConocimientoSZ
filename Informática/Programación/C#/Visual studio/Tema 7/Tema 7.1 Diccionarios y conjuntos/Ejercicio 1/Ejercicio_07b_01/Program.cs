/*Esta programa consiste en un diccionario de alumnos que el usuario rellena
con el nombre y las notas del alumno,luego los muestra por pantalla*/
class Diccion
{
    static void Main()
    {
        string nombre;
        int notas;
        SortedList<string, int> Alumnos = new SortedList<string, int>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Escribe el nombre del alumno");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Escriba la nota del alumno");
            notas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Alumnos[nombre] = notas;
        }
        for (int i = 0; i < Alumnos.Count; i++)
        {
            Console.WriteLine("Nombre: " + Alumnos.Keys[i]
                + ", Notas: " + Alumnos.Values[i]);
        }
    }
}