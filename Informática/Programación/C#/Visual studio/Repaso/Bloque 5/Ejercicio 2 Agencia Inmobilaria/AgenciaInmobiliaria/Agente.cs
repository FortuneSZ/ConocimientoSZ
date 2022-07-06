/*
 * Clase para gestionar los agentes inmobiliarios
 */
class Agente
{ 
    private string nombre;
    private string telefono;

    public Agente(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public override string ToString()
    {
        return nombre + " - " + telefono;
    }
}