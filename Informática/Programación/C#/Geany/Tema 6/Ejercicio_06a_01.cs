using System;

class persona
{
    string nombre;
    
    public void SetNombre(string nom)
    {
        nombre = nom;
    }
    
    public void Saludar()
    {
        Console.WriteLine("Hola,soy {0}",nombre);
    }
}

class PruebaPersona
{
    static void Main()
    {
        string nom,nom2;
        persona gente = new persona();
        persona gente2 = new persona();
        Console.WriteLine("Escribe un nombre");
        nom = Console.ReadLine();
        gente.SetNombre(nom);
        
        Console.WriteLine("Escribe un nombre");
        nom2 = Console.ReadLine();
        gente2.SetNombre(nom2);
        
        gente.Saludar();
        gente2.Saludar();
    }
}
