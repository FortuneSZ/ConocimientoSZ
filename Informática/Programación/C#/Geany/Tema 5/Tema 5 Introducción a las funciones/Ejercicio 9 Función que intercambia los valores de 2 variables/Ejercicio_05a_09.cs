/*este programa crea una función que intercambiar el valor de a por el valor
de b*/
using System;


class Ejercicio_05a_09
{
    static void intercambiar(ref int a,ref int b)
    {
        int c;
        c=a;
        a=b;
        b=c;
        

    }
    
    static void Main()
	{
      int a,b;
      Console.WriteLine("esfribe el valor de a");
      a =Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("esfribe el valor de b");
      b =Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("valor original a={0} b={1}",a,b);
      intercambiar(ref a,ref b);
      Console.WriteLine("valor actual a={0} b={1}",a,b);
    }
   
}
