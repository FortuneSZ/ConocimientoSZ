/*Clase vehiculo*/
class Vehiculo
{
    protected string marca;
    protected string modelo;
    protected int cilindrada;
    protected float potencia;
    protected int cantidadDeRuedas;

    //getters y setters
    public string GetMarca()
    {
        return marca;
    }
    public void SetMarca(string marc)
    {
        this.marca = marc;
    }
    public string GetModelo()
    {
        return modelo;
    }
    public void SetModelo(string mod)
    {
        this.modelo = mod;
    }
    public int GetCilindrada()
    {
        return cilindrada;
    }
    public void SetCilindrada(int cil)
    {
        this.cilindrada = cil;
    }
    public float GetPotencia()
    {
        return potencia;
    }
    public void SetPotencia(float pot)
    {
        this.potencia = pot;
    }
    public int CantidadDeRuedas
    {
        get { return cantidadDeRuedas; }
        set { this.cantidadDeRuedas = value; }
    }
    //Constructores
    public Vehiculo()
    {
        this.marca = "marca";
        this.modelo = "modelo";
        this.cilindrada = 0;
        this.potencia = 0;
    }
    public Vehiculo(string marca, string modelo, int cilindrada, float potencia)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cilindrada = cilindrada;
        this.potencia = potencia;
    }
}

