/*este programa pide al usuario su nota trimestral y en base a la misma
decir si tiene un suspenso,aprobado,notable o sobresaliente*/
class Practica_2_1_2
{

    static void Main()
    {
        int nota;

        Console.WriteLine("introduzca su nota trimestral");
        nota = Convert.ToInt32(System.Console.ReadLine());


        switch (nota)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("SUSPENSO");
                break;

            case 5:
            case 6:
                Console.WriteLine("APROBADO");
                break;

            case 7:
            case 8:
                Console.WriteLine("NOTABLE");
                break;

            case 9:
            case 10:
                Console.WriteLine("SOBRESALIENTE");
                break;
        }

    }
}
