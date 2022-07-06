/*Este programa crea dos objetos de tipo coche,uno es construido por un
 * constructor predeterminado y el otro parametrizado,posteriormente
 se muestran sus datos*/
class PruebaCoche
{
    static void Main()
    {
        Coche coche = new Coche();
        Coche coche1 = new Coche("noama", "dapoio", 55, 200);

        Console.WriteLine("Modelo: " + coche.GetModelo() +
            ", Marca: " + coche.GetMarca() + ", Cilindrada: " +
            coche.GetCilindrada() + ", Potencia: " + coche.GetPotencia());

        Console.WriteLine("Modelo: " + coche1.GetModelo() +
            ", Marca: " + coche1.GetMarca() + ", Cilindrada: " +
            coche1.GetCilindrada() + ", Potencia: " + coche1.GetPotencia());
    }
}
