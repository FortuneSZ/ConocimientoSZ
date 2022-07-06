using System;

class Coche
{
    string marca;
    string modelo;
    int cilindrada;
    float potencia;
    
    public void Setmarca(string m)
    {
        marca = m;
    }
    
    public void Setmodelo(string m)
    {
        modelo = m;
    }
    
    public void Setcilindrada(int m)
    {
        cilindrada = m;
    }
    
    public void Setpotencia(float m)
    {
        potencia = m;
    }
    
    public string Getmarca()
    {
        return marca;
    }
    
    public string Getmodelo()
    {
        return modelo;
    }
    
    public int Getcilindrada()
    {
        return cilindrada;
    }
    
    public double Getpotencia()
    {
        return potencia;
    }
}

class Pruebacoche
{
    static void Main()
    {
        Coche forocoches = new Coche();
        Console.WriteLine("Introduzca la marca");
        forocoches.Setmarca(Console.ReadLine());
        Console.WriteLine("Introduzca el modelo");
        forocoches.Setmodelo(Console.ReadLine());
        Console.WriteLine("Introduzca la cilindrada");
        forocoches.Setcilindrada(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Introduzca la potencia");
        forocoches.Setpotencia(Convert.ToSingle(Console.ReadLine()));
        
        Console.WriteLine("Marca " + forocoches.Getmarca());
        Console.WriteLine("Modelo " + forocoches.Getmodelo());
        Console.WriteLine("Cilindrada " + forocoches.Getcilindrada());
        Console.WriteLine("Potencia " + forocoches.Getpotencia());
    }
}
