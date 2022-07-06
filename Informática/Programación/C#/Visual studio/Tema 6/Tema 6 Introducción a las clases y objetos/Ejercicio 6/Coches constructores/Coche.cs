/*Clase coche*/
class Coche
{
    private string marca;
    private string modelo;
    private int cilindrada;
    private float potencia;

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
    //Constructores
    public Coche()
    {
        this.marca = "marca";
        this.modelo = "modelo";
        this.cilindrada = 0;
        this.potencia = 0;
    }
    public Coche(string marca, string modelo, int cilindrada, float potencia)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.cilindrada = cilindrada;
        this.potencia = potencia;
    }
}

