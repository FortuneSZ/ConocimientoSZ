/*
 * Rutinas de tipo circuito de fitness
 */
[Serializable]
class RutinaCircuito : Rutina
{
    private int ejercicios;

    public int Ejercicios
    {
        get { return ejercicios; }
        set { ejercicios = value; }
    }

    public RutinaCircuito() { }

    public RutinaCircuito(string descripcion, DateTime fecha,
        int duracion, int calorias, int ejercicios)
        : base(descripcion, fecha, duracion, calorias)
    {
        this.ejercicios = ejercicios;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + 
            ejercicios + " ejercicios";
    }
}