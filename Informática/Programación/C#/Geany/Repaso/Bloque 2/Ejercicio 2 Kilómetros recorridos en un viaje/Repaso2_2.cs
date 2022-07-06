/* Programa que pida cuantos dias va a tardar el usuario, de cada dias cuantos
Km ha recorrido , al final dirá que día es el que mas km ha recorrido y
cuantos ha hecho */
 
 using System;
 class Repaso2_2
 {
     static void Main()
     {
         int numeroDias;
         int [ ] km;
         int maximo = 0, posicion;
         Console.WriteLine("Dime cuantos días has tardado en llegar");
         numeroDias = Convert.ToInt32(Console.ReadLine());
         km = new int [numeroDias];
         Console.WriteLine("Dime de cada dia, los km que has recorrido");
         for (int i = 0; i < numeroDias; i++)
         {
             km[i]= Convert.ToInt32(Console.ReadLine());
         }
         maximo = km[0];
         posicion = 0;
         for(int i = 1; i < km.Length; i++)
         {
             if (km[i] > maximo)
             {
                 maximo = km[i];
                 posicion = i;
             }
         }
        Console.WriteLine("El dia {0} es el que más has recorrido", posicion+1);
        Console.WriteLine("Se recorrió {0} km", maximo);
         
         
     }
 }
