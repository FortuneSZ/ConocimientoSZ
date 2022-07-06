/*Este programa pide al usuario cuantos valores quiere evaluar en la bolsa
y en base de si todos los valores son progresivamente superiores,progresivamente
inferiores,o ninguna de las dos,dirá si las acciones van en alza,a la baja
o si oscilan*/

class Practica_4_1_1
{
    static void Main()
    {
        int valores, contadoralza = 0, contadorbaja = 0;
        Console.WriteLine("¿Cuantos valores quieres?");
        valores = Convert.ToInt32(Console.ReadLine());
        float[] bolsa = new float[valores];

        for (int i = 0; i < valores; i++)
        {
            Console.WriteLine("escriba el valor");
            bolsa[i] = Convert.ToSingle(Console.ReadLine());
        }
        Console.Clear();
        for (int i = 0; i < valores; i++)
        {
            Console.WriteLine("-" + bolsa[i]);
        }
        for (int i = 0; i < bolsa.Length; i++)
        {
            if (i > 0)
            {
                if (bolsa[i] > bolsa[i - 1])
                {
                    contadoralza++;
                }
                else
                {
                    contadorbaja++;
                }
            }
        }
        if (contadoralza == valores - 1)
        {
            Console.WriteLine("Las acciones están al alza");
        }
        else if (contadorbaja == valores - 1)
        {
            Console.WriteLine("Las acciones están a la baja");
        }
        else
        {
            Console.WriteLine("Las acciones están oscilando");
        }
    }
}
