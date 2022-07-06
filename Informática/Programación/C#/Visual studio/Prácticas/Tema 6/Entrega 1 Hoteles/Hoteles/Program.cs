/* Programa que registra hoteles con sus variables y muestre por pantalla un menu que sea : 
 * 1. Añadir nuevo hotel, 2. Hoteles baratos, 3. Hoteles por estrellas y 4. salir */

Hotel[] hoteles = new Hotel[20];
Hotel nuevoHotel = new Hotel();

bool parse = false;
bool salir = false;
bool hayEstrella;
float precio;
int opcion, cantidad = 0, estrellas, estrellasAbuscar;

do
{
    try
    {
        Console.WriteLine("1. Nuevo hotel:");
        Console.WriteLine("2. Hoteles baratos:");
        Console.WriteLine("3. Hoteles por estrellas:");
        Console.WriteLine("4. Salir");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcion)
        {
            case 1:
                if (cantidad < hoteles.Length)
                {
                    Console.WriteLine("Escribe el nombre del hotel:");
                    nuevoHotel.Nombre = Console.ReadLine();

                    Console.WriteLine("Inserte la localidad donde se encuentra:");
                    nuevoHotel.Localidad = Console.ReadLine();


                    do
                    {
                        Console.WriteLine("Precio euro/noche:");
                        if (Single.TryParse(Console.ReadLine(), out precio))
                        {
                            parse = true;
                            nuevoHotel.Precio = precio;
                        }
                    }
                    while (!parse && precio < 0);
                    do
                    {
                        Console.WriteLine("Numero de estrellas:");
                        if (Int32.TryParse(Console.ReadLine(), out estrellas))
                        {
                            parse = true;
                            nuevoHotel.Estrellas = estrellas;
                        }
                    }
                    while (!parse && estrellas > 0 && estrellas < 5);

                    hoteles[cantidad] = nuevoHotel;
                    cantidad++;
                }
                break;

            case 2:
                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = i + 1; j < cantidad; j++)
                    {
                        if (hoteles[i].Precio > hoteles[j].Precio)
                        {
                            Hotel auxiliar = hoteles[i];
                            hoteles[i] = hoteles[j];
                            hoteles[j] = auxiliar;
                        }
                    }
                }
                for (int i = 0; i < cantidad; i++)
                {

                    hoteles[i].Mostrar();
                }
                break;

            case 3:
                Console.WriteLine("Introduce la cantidad de estrellas");
                estrellasAbuscar = Convert.ToInt32(Console.ReadLine());
                hayEstrella = false;
                for (int i = 0; i < cantidad; i++)
                {
                    if (hoteles[i].Estrellas == estrellasAbuscar)
                    {
                        hayEstrella = true;
                        hoteles[i].Mostrar();
                    }
                }
                if (!hayEstrella)
                {
                    Console.WriteLine("No se ha encontrado ningun hotel con esa cantidad de estrellas o es incorrecto");
                }
                break;
            case 4:
                Console.WriteLine("Has elegido salir de la aplicación");
                salir = true;
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}
while (!salir);