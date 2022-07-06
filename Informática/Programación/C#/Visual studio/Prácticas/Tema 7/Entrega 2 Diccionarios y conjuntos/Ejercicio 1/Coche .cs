/*Clase coche*/
class Coche
{
    protected string matricula;
    protected string marca;
    protected string modelo;
    protected List<Mantenimiento> mantenimientos = new List<Mantenimiento>();

    public string Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public Coche(string matricula, string marca, string modelo)
    {
        this.matricula = matricula;
        this.marca = marca;
        this.modelo = modelo;
        mantenimientos = new List<Mantenimiento>();
    }
    public void AddMant(Mantenimiento mant)
    {
        this.mantenimientos.Add(mant);
    }
    public float Coste()
    {
        float coste = 0;
        foreach (Mantenimiento result in mantenimientos)
        {
            coste += result.Precio;
        }
        return coste;
    }
    public override string ToString()
    {
        return "Matricula: " + this.matricula + " , Marca: " + this.marca
            + " , Modelo: " + this.modelo;
    }
}

