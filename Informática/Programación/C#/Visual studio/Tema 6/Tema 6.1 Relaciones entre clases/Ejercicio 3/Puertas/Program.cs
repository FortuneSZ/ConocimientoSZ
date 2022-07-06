/*Este programa crea un objeto de tipo puerta y uno de tipo portón,un suibtipo
 de puerta,y luego muestra sus datos*/
class Principal
{
    static void Main()
    {
        Console.WriteLine("Puerta");
        Puerta p = new Puerta(70, 200, "blanco");
        p.Abrir();
        p.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("Portón");
        Porton p2 = new Porton(80, 210, "marron");
        p2.Cerrar();
        p2.Bloquear();
        p2.MostrarInformacion();
    }
}
