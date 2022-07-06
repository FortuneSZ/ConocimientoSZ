//Este programa sirve para probar los métodos estáticos
class Principal
{
    static void Main()
    {
        Hardware.BorrarPantalla();
        Hardware.EscribirCentradoS("si");
        Hardware H = new Hardware();
        H.EscribirCentrado("No te ama");

    }
}
