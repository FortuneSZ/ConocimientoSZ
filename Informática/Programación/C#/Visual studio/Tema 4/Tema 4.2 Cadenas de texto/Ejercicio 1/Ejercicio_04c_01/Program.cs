/*Este programa le pedirá al usuario que introduzca 2 números,y le dará a elegir
si quiere,sumar,restar,multiplicar o dividir esos números*/

class Ejercicio_04c_01
{
    static void Main()
    {
        int resultado;
        string eleccion;
        int[] numeros = new int[2];
        string[] opciones = new string[4]
        {"sumar","restar","multiplicar","dividir"};
        Console.WriteLine("introduzca los numeros");
        for (int i = 0; i < 2; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("seleccione una operación");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(opciones[i]);
        }
        eleccion = Console.ReadLine();
        switch (eleccion)
        {
            case "sumar":
            case "+":
                resultado = numeros[0] + numeros[1];
                Console.WriteLine("{0} + {1} = {2}"
                , numeros[0], numeros[1], resultado);
                break;

            case "restar":
            case "-":
                resultado = numeros[0] - numeros[1];
                Console.WriteLine("{0} - {1} = {2}"
                , numeros[0], numeros[1], resultado);
                break;

            case "multiplicar":
            case "*":
            case "x":
                resultado = numeros[0] * numeros[1];
                Console.WriteLine("{0} * {1} = {2}"
                , numeros[0], numeros[1], resultado);
                break;

            case "division":
            case "/":
                resultado = numeros[0] / numeros[1];
                Console.WriteLine("{0} / {1} = {2}"
                , numeros[0], numeros[1], resultado);
                break;
        }


    }

}
