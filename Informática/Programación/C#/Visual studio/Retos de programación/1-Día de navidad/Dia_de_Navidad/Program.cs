/* */

class Dia_de_Navidad
{
    static void Main()
    {
        int numCasos;
        string fecha;
        string[] partesFecha;

        Console.WriteLine("Escriba el numero de casos");
        numCasos = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numCasos; i++)
        {
            Console.WriteLine("Escriba el día y el mes");
            fecha = Console.ReadLine();
            partesFecha = fecha.Split('/');
            if (partesFecha[0] == "25" && partesFecha[1] == "12")
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}