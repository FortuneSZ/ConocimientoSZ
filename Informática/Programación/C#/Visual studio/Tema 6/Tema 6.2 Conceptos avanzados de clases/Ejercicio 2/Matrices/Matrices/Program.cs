int[,] m1 =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] m2 =
{
    {1, 1, 1},
    {2, 2, 2},
    {3, 3, 3}
};

Matriz matriz1 = new Matriz(m1);
Matriz matriz2 = new Matriz(m2);
Matriz matriz3 = matriz1 + matriz2;
Console.WriteLine(matriz3);