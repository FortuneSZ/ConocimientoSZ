/*
 * Subtipo de personal para los administrativos
 */
class Administrativo : Personal
{
    private char nivel;

    public char Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public Administrativo(string dni, string nombre, 
        string telefono, char nivel)
        :base(dni, nombre, telefono)
    {
        this.nivel = nivel;
    }
}