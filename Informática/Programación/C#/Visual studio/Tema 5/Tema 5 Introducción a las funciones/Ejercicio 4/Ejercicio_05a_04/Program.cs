/*Este programa crea una función que dice uno si el número introducido por el
usuario es positivo y -1 si es negativo*/

class Ejercicio_05a_04
{
    static int Signo(int numero)
    {
        int resultado = 0;
        if (numero > 0)
        {
            resultado = 1;
        }
        else if (numero < 0)
        {
            resultado = -1;
        }
        return resultado;

    }


    static void Main()
    {
        int numero;
        Console.WriteLine("Escriba un número");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El signo de {0} es {1}", numero, Signo(numero));


    }

}
