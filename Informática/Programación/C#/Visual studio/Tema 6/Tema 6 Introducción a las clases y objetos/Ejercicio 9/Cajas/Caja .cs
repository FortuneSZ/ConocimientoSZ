/*Clase caja*/
class Caja
{
    private int litros;

    //Getters y setters
    public int Litros
    {
        get
        {
            return litros;
        }
        set
        {
            if (litros < 250)
            {
                litros = value;
            }
        }
    }
}
