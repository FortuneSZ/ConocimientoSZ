/* 
 * Programa que define una función que indica si una matriz es triangular
 */

class Repaso3_2
{
    static bool EsTriangular(int[,] matriz)
    {
        bool triangularSuperior = true, triangularInferior = true;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i > j && matriz[i, j] != 0)
                {
                    triangularInferior = false;
                }
                else if (i < j && matriz[i, j] != 0)
                {
                    triangularSuperior = false;
                }
            }
        }

        return triangularInferior || triangularSuperior;
    }

    static void Main()
    {
        int[,] matriz1 = {
            {1, 2, 3},
            {0, 6, 4},
            {0, 0, 5}
        };

        int[,] matriz2;
        int tamano;
        string linea;
        string[] partes;

        Console.WriteLine(EsTriangular(matriz1));

        Console.WriteLine("Indica el tamaño de la matriz:");
        tamano = Convert.ToInt32(Console.ReadLine());
        matriz2 = new int[tamano, tamano];

        for (int i = 0; i < tamano; i++)
        {
            linea = Console.ReadLine();
            partes = linea.Split();
            for (int j = 0; j < tamano; j++)
            {
                matriz2[i, j] = Convert.ToInt32(partes[j]);
            }
        }

        Console.WriteLine(EsTriangular(matriz2));
    }
}
