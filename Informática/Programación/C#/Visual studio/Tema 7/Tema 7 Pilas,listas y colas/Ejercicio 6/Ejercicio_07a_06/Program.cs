/*Este programa pide números al usuario hasta que este introduce 0 y los 
 añade a una lista,luego la ordena de menor a mayor y la muestra*/
class ListaOr
{
    static void Main()
    {
        int num;
        List<int> lista = new List<int>();
        do
        {
            Console.WriteLine("Escribe un número");
            num = Convert.ToInt32(Console.ReadLine());
            lista.Add(num);
            Console.Clear();
        }
        while (num != 0);
        lista.Sort();
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}
