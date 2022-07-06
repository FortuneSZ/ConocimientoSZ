/*pida al usuario una expresión matemática en una línea,
y calcule el resultado. La expresión matemática estará formada únicamente
por números y operadores aritméticos de suma (+), resta (-),
multiplicación () y división(/), y se resolverá de izquierda a derecha
, sin importar la precedencia.*/
class Repaso2_1
{
    static void Main()
    {
        string expresion, operacion = "+";
        int resultado = 0, numero;
        Console.WriteLine("Introduce una expresión matemática ");
        expresion = Console.ReadLine();
        string[] partes = expresion.Split();
        for (int i = 0; i < partes.Length; i++)
        {
            if (i % 2 != 0)
            {
                operacion = partes[i];
            }
            else
            {
                numero = Convert.ToInt32(partes[i]);
                if (i == 0)
                {
                    resultado = numero;
                }
                else
                {
                    switch (operacion)
                    {
                        case "+":
                            resultado = resultado + numero;
                            break;
                        case "-":
                            resultado = resultado - numero;
                            break;
                        case "*":
                            resultado = resultado * numero;
                            break;
                        case "/":
                            resultado = resultado / numero;
                            break;
                    }
                }
            }
        }
        Console.WriteLine("El resultado es: {0}", resultado);
    }
}
