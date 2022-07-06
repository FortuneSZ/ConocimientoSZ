/*Este programa pide números al usuario hasta que este introduce 0 y los 
 añade a una lista,luego pedirá al usuario que introduzca un número que
desea borrar y borrará todas las veces que aparezca dicho número*/
class ListaOr
{
    static void Main()
    {
        int num, numBorrar;
        List<int> lista = new List<int>();
        do
        {
            Console.WriteLine("Escribe un número");
            num = Convert.ToInt32(Console.ReadLine());
            lista.Add(num);
            Console.Clear();
        }
        while (num != 0);

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        Console.WriteLine("Escriba un número que desea borrar de la lista");
        numBorrar = Convert.ToInt32(Console.ReadLine());

        int ii = 0;
        while (ii < lista.Count)
        {
            if (lista[ii] == numBorrar)
            {
                lista.RemoveAt(ii);
            }
            else
            {
                ii++;
            }
        }
        Console.Clear();
        Console.WriteLine("Lista actualizada");

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}
