/*Clase coche*/
class Coche : Vehiculo
{

    //Constructores
    public Coche()
    {
        this.marca = "marca";
        this.modelo = "modelo";
        this.cilindrada = 0;
        this.potencia = 0;
    }
    public Coche(string marca, string modelo, int cilindrada, float potencia)
        : base(marca, modelo, cilindrada, potencia)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.cilindrada = cilindrada;
        this.potencia = potencia;
        this.cantidadDeRuedas = 4;
    }
}

