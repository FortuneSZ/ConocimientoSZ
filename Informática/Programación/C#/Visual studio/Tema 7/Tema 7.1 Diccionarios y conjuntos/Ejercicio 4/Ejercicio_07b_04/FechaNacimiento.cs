/*
 * Datos de una fecha de nacimiento
 */
class FechaNacimiento
{
    private int dia;
    private int mes;
    private int anyo;

    public FechaNacimiento(int dia, int mes, int anyo)
    {
        this.dia = dia;
        this.mes = mes;
        this.anyo = anyo;
    }

    public override bool Equals(object? obj)
    {
        return obj is FechaNacimiento nacimiento &&
               dia == nacimiento.dia &&
               mes == nacimiento.mes;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(dia, mes);
    }
}