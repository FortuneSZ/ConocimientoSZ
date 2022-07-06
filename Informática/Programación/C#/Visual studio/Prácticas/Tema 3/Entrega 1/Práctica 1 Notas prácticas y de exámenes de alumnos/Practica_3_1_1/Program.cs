/*Este programa realizara la nota del primer semestre,primero pedira el numero
de practicas,sus respectivas notas y las notas de los 2 examenes,luego calculara
la media de ambos y nota final(70% practicas,30% examenes) y si ambas medias
son superiores a 4 mostrara el valor de la nota final,si alguna no lo es
la nota maxima sera un 4*/
class Practica_3_1_1
{

    static void Main()
    {
        int numpracticas;
        float notapractica = 0, notapracticaauxiliar = 0, mediapracticas;
        float notaexamen = 0, notaexamenauxiliar = 0, mediaexamen;
        float notafinal;

        Console.WriteLine("¿cuantas practicas has realizado?");
        numpracticas = Convert.ToInt32(System.Console.ReadLine());

        for (int y = numpracticas; y > 0; y--)
        {
            Console.WriteLine("escriba su nota de la practica");
            notapracticaauxiliar = Convert.ToSingle(System.Console.ReadLine());
            Console.WriteLine("nota de practica " + notapracticaauxiliar);
            notapractica = notapractica + notapracticaauxiliar;
        }
        mediapracticas = notapractica / numpracticas;

        for (int x = 2; x > 0; x--)
        {
            Console.WriteLine("introduzca su nota de examen");
            notaexamenauxiliar = Convert.ToSingle(System.Console.ReadLine());
            Console.WriteLine("nota de examen " + notaexamenauxiliar);
            notaexamen = notaexamen + notaexamenauxiliar;
        }
        mediaexamen = notaexamen / 2;

        notafinal = mediapracticas * 30 / 100 + mediaexamen * 70 / 100;

        if (Math.Min(mediapracticas, mediaexamen) > 4)
        {
            Console.WriteLine("la nota final es " + notafinal.ToString("N2"));
        }
        else if (Math.Min(mediapracticas, mediaexamen) < 4 && notafinal > 4)
        {
            notafinal = 4;
            Console.WriteLine("la nota final es un " + notafinal);
        }
    }

}
