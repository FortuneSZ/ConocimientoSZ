/*Programa que le pide al usuario dos números grandes y los suma
manualmente*/
class Ejercicio_04c_04
{
    static void Main()
    {
        string num1, num2, resultado;
        int digito1, digito2, llevar, sumaparcial;
        Console.WriteLine("Introduce dos numeros a sumar : ");
        Console.Write("Numero 1: ");
        num1 = Console.ReadLine();
        Console.Write("Numero 2: ");
        num2 = Console.ReadLine();
        while (num1.Length < num2.Length)
        {
            num1 = "0" + num1;
        }
        while (num2.Length < num1.Length)
        {
            num2 = "0" + num2;
        }
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        resultado = "";
        llevar = 0;
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            digito1 = Convert.ToInt32(num1[i] - '0');
            digito2 = Convert.ToInt32(num2[i] - '0');
            sumaparcial = digito1 + digito2 + llevar;
            if (sumaparcial >= 10)
            {
                sumaparcial -= 10;
                llevar = 1;
            }
            else
            {
                llevar = 0;
            }
            resultado = sumaparcial + resultado;
        }
        if (llevar == 1)
        {
            resultado = llevar + resultado;
        }
        Console.WriteLine(resultado);

    }
}
