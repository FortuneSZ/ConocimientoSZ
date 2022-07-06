//Subclase alimento liquido
class AlimentoLiquido : Alimento
{
    public AlimentoLiquido(string nombre) : base(nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
