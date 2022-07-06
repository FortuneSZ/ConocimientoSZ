/*
 * Clase que representa una fracción con su numerador
 * y denominador
 */
class Fraccion
{
    private int numerador;
    private int denominador;

    public int Denominador
    {
        get { return denominador; }
    }

    public Fraccion(int numerador, int denominador)
    {
        this.numerador = numerador;
        this.denominador = denominador;
    }

    public static int MCM(int n1, int n2)
    {
        int resultado = Math.Max(n1, n2);
        while (resultado % n1 != 0 || resultado % n2 != 0)
        {
            resultado++;
        }
        return resultado;
    }

    public override string ToString()
    {
        return numerador + " / " + denominador;
    }

    public static Fraccion operator *(Fraccion f1, Fraccion f2)
    {
        Fraccion resultado =
            new Fraccion(f1.numerador * f2.numerador,
                f1.denominador * f2.denominador);
        return resultado;
    }

    public static Fraccion operator +(Fraccion f1, Fraccion f2)
    {
        int mcm = MCM(f1.denominador, f2.denominador);
        Fraccion resultado = new Fraccion(
            mcm / f1.denominador * f1.numerador +
            mcm / f2.denominador * f2.numerador,
            mcm);
        return resultado;
    }
}