/*este programa crea una función que calcula el área y el perímetro de un
circulo de radio dado por el usuario*/
using System;


class Ejercicio_05a_010
{
    static void DatosCirculo(float radio,out double area,out double perimetro)
    {
        area= Math.PI * (radio*radio);
        
        perimetro=2*Math.PI * radio;

    }
    
    static void Main()
	{
        double area,perimetro;
      float radio;
      Console.WriteLine("escribe el valor del radio");
      radio =Convert.ToInt32(Console.ReadLine());
      DatosCirculo(radio,out area,out perimetro);
      Console.WriteLine("el perimetro es {0}",perimetro);
      Console.WriteLine("el area es {0}",area);
      
    }
   
}
