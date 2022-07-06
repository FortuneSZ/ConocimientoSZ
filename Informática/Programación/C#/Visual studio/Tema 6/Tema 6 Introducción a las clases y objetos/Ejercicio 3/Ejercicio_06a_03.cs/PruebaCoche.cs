class PruebaCoche
{
    static void Main()
    {
        Coche coche = new Coche();
        coche.SetModelo("noama");
        coche.SetMarca("dapoio");
        coche.SetCilindrada(55);
        coche.SetPotencia(200);
        Console.WriteLine("Modelo: " + coche.GetModelo() +
            ", Marca: " + coche.GetMarca() + ", Cilindrada: " +
            coche.GetCilindrada() + ", Potencia: " + coche.GetPotencia());
    }
}