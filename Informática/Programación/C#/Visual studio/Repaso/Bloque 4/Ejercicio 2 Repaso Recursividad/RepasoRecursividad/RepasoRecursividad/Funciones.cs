/*
 * Clase con funciones recursivas
 */
class Funciones
{
    static Random random = new Random();

    public static int MCD(int m, int n)
    {
        if (m < n)
        {
            int aux = m;
            m = n;
            n = aux;
        }

        int r = m % n;
        if (r == 0)
            return n;
        else
            return MCD(n, r);
    }

    public static int BuscarArray(int[] datos, int num, 
        int contador)
    {
        if (contador == datos.Length)
        {
            return -1;
        }
        else if (datos[contador] == num)
        {
            return contador;
        }
        else
        {
            return BuscarArray(datos, num, contador + 1);
        }
    }

    public static string Secuencia(int n)
    {
        if (n == 1)
            return "1";
        else
            return Secuencia(n - 1) + ", " + n;
    }

    public static string Secuencia(int n, int m)
    {
        if (n == m)
            return "" + n;
        else
            // return n + ", " + Secuencia(n + 1 , m);
            return Secuencia(n, m - 1) + ", " + m;
    }

    public static int CalcularTiempoRaton()
    {
        int caminoSeleccionado = random.Next(1, 4);
        int tiempo = 0;
        
        switch(caminoSeleccionado)
        {
            case 1:
                tiempo = CalcularTiempoRaton() + 3;
                break;
            case 2:
                tiempo = CalcularTiempoRaton() + 5;
                break;
            case 3:
                tiempo = 7;
                break;
        }

        return tiempo;
    }

    public static string ObtenerPosiciones(string a, 
        string b, int contador)
    {
        if (contador == a.Length || 
            a.IndexOf(b, contador+1) < 0)
        {
            return "";
        }
        else
        {
            contador = a.IndexOf(b, contador+1);
            return contador + " " + 
                ObtenerPosiciones(a, b, contador);
        }
    }

    public static bool EsPotencia(int n, int b)
    {
        if (n == 1 || n == b)
            return true;
        else if (n < b || n % b != 0)
            return false;
        else
            return EsPotencia(n / b, b);
    }

    public static bool Par(int n)
    {
        if (n == 1)
            return false;
        else
            return Impar(n - 1);
    }

    public static bool Impar(int n)
    {
        if (n == 1)
            return true;
        else
            return Par(n - 1);
    }
}