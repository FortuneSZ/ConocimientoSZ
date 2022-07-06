// subclase alimento solido
class AlimentoSolido : Alimento
{
    public AlimentoSolido(string nombre) : base(nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

