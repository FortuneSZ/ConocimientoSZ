/*Este programa crea un objeto de clase coche y de clase moto,que heredan
 todos sus atributos de la clase vehiculo,luego de eso muestra los datos de
ambos objetos*/
class Principal
{
    static void Main()
    {
        Coche coche = new Coche("seat", "altea", 45, 98);

        Moto moto = new Moto("vespa", "noidea", 35, 57);

        Console.WriteLine("Modelo: " + coche.GetModelo() +
            ", Marca: " + coche.GetMarca() + ", Cilindrada: " +
            coche.GetCilindrada() + ", Potencia: " + coche.GetPotencia()
            + ", cantidad de ruedas: " + coche.CantidadDeRuedas);
        Console.WriteLine();
        Console.WriteLine("Modelo: " + moto.GetModelo() +
            ", Marca: " + moto.GetMarca() + ", Cilindrada: " +
            moto.GetCilindrada() + ", Potencia: " + moto.GetPotencia()
            + ", cantidad de ruedas: " + moto.CantidadDeRuedas);
    }
}

