/* este programa pide al usuario 2 notas enteras del 1 al 10,las pedira las
veces que haga falta hasta que su valor sea correcto,despues calculara su
media*/
class practica_2_2_1
{
    static void Main()
    {
        int nota1, nota2, media;
        do
        {
            Console.WriteLine("dime el primer número ");
            nota1 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("dime el segundo número ");
            nota2 = Convert.ToInt32(System.Console.ReadLine());
        }
        while (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10);

        media = (nota1 + nota2) / 2;
        Console.WriteLine("la media de {0} y {1} es {2}", nota1, nota2, media);
    }
}
