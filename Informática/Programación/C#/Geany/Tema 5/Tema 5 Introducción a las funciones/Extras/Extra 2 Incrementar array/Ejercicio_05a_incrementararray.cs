/*Este programaes una modificación del anterior,
crea una función que incrementa todos los valores de un array*/
 
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
    
    static void Main ()
    {
        int n = 1;
        int[] datos = {1,2,3,4,5};
        Incrementar(ref n);
        Console.WriteLine("En el Main numero es {0}",n);
        
        IncrementarArray(datos);
        Console.WriteLine("Array despues de llamar a la funcion");
        foreach(int numero in datos)
        {
            Console.WriteLine("{0} ", numero);
        }
    }
 }
