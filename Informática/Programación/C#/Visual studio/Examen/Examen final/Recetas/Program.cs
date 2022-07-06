/*Este programa consiste en base a unos ingrdientes leidos al principio del 
 programa de un fichero,crear recetas en base a esos ingrdientes,al número de
comensales mandados por el usuario,la fecha y el nombre de la receta.

 luego de que cada receta esté terminada será almacenada en una lista de 
recetas,las cuales serán ordenadas y escritas en un fichero*/
class Examen
{
    static void Main()
    {
        string linea;
        string titulo;
        byte numcomensales;
        int año;
        int mes;
        int dia;
        DateTime fecha;
        int eleccion;
        uint cantidad;
        string unidad;
        List<Alimento> Alimentos = new List<Alimento>();
        List<Receta> recetas = new List<Receta>();
        using (StreamReader fichero = new StreamReader("alimentos.dat"))
        {
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    string[] partes = linea.Split(";");
                    if (partes[0] == "Liquido")
                    {
                        Alimentos.Add(new AlimentoLiquido(partes[1]));
                    }
                    if (partes[0] == "Solido")
                    {
                        Alimentos.Add(new AlimentoSolido(partes[1]));
                    }
                }
            }
            while (linea != null);
        }
        do
        {
            Console.WriteLine("Escribe el título de la receta");
            titulo = Console.ReadLine();
            if (titulo != "")
            {
                do
                {
                    Console.WriteLine("Introduzca el número de comensales");
                    numcomensales = Convert.ToByte(Console.ReadLine());
                }
                while (numcomensales < 0);

                do
                {
                    Console.WriteLine("Introduzca la fecha");
                    Console.WriteLine();
                    Console.WriteLine("introduce el año(numero)");
                    año = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("introduce el mes(numero)");
                    mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("introduce el día(numero)");
                    dia = Convert.ToInt32(Console.ReadLine());
                    fecha = new DateTime(año, mes, dia);

                }
                while (mes < 0 || mes > 12 || dia < 0 || dia > 31);
                Console.Clear();

                Receta receta = new Receta(titulo, numcomensales, fecha);
                do
                {
                    for (int i = 1; i < Alimentos.Count; i++)
                    {
                        Console.Write(i + ": ");
                        Console.WriteLine(Alimentos[i]);
                    }
                    Console.WriteLine("Elije un alimento");
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seleccione la cantidad");
                    cantidad = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Seleccione la unidad");
                    unidad = Console.ReadLine();

                    Ingrediente ingre = new Ingrediente(Alimentos[eleccion], cantidad, unidad);
                    receta.AñadirIngrediente(ingre);
                    Console.Clear();
                }
                while (eleccion != 0);
                recetas.Add(receta);
            }
        }
        while (titulo != "");

        using (StreamWriter ficheroEscribir = new StreamWriter("recetas.dat"))
        {
            for (int i = 0; i < recetas.Count; i++)
            {
                ficheroEscribir.WriteLine(recetas[i].ToString);
                ficheroEscribir.WriteLine("--------");
            }
        }

        Console.WriteLine("Introduzca un año");
        año = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introduzca un mes");
        mes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < recetas.Count; i++)
        {

        }
    }
}

