/*
 * Clase para representar una matriz bidimensional
 */
class Matriz
{
    private int[,] datos;

    public Matriz(int[,] datos)
    {
        this.datos = datos;
    }

    public static Matriz operator +(Matriz m1, Matriz m2)
    {
        int[,] resultado =
            new int[m1.datos.GetLength(0), m1.datos.GetLength(1)];

        for(int i = 0; i < m1.datos.GetLength(0); i++)
        {
            for(int j = 0; j < m1.datos.GetLength(1); j++)
            {
                resultado[i,j] = m1.datos[i,j] + m2.datos[i,j];
            }
        }

        Matriz r = new Matriz(resultado);
        return r;
    }

    public override string ToString()
    {
        string resultado = "";

        for(int i = 0;i < datos.GetLength(0);i++)
        {
            for(int j = 0;j < datos.GetLength(1);j++)
            {
                resultado += datos[i, j] + " ";
            }
            resultado = resultado + "\n";
        }

        return resultado;
    }
}