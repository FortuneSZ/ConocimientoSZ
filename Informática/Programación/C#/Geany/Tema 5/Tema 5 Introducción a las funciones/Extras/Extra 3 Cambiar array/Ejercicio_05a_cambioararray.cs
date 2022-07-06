/*Este programaes una modificación del anterior,cambiamos los datos del array
por otros dentro de la función y mostramos sus valores*/
 
 using System;
 class Ejercicio_05a_incrementar
 {
    static void Incrementar (ref int numero)
    {
        numero++;
        Console.WriteLine("Aqui dentro numero es {0}", numero);
    }
    static void IncrementarArray (int[] numeros)
    {
        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i]++;
        }
    }
    static void CambiarArray(int[] numeros)
    {
        numeros = new int[] {10,20,30,40,50};
    }
    static void Main ()
    {
        int n = 1;
        int[] datos = {1,2,3,4,5};
        int[] datos2 = {1,2,3,4,5};
        Incrementar(ref n);
        Console.WriteLine("En el Main numero es {0}",n);
        
        IncrementarArray(datos);
        Console.WriteLine("Array despues de llamar a la funcion");
        foreach(int numero in datos)
        {
            Console.WriteLine("{0} ", numero);
        }
        CambiarArray(datos2);
        Console.WriteLine("Array despues de llamar a CambiarArray");
        foreach(int numero in datos2)
        {
            Console.Write("{0} ", numero);
        }
    }
 }
