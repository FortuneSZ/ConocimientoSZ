/*
 * Gestión de una lista de hoteles con
 * programación funcional
 */
List<Hotel> hoteles = new List<Hotel>();
hoteles.Add(new Hotel("Meliá", "Alicante", 4));
hoteles.Add(new Hotel("Maya", "Alicante", 3));
hoteles.Add(new Hotel("Costa Narejos", "Los Alcázares", 3));
hoteles.Add(new Hotel("Marina D'Or", "Oropesa", 5));
hoteles.Add(new Hotel("Salou", "Salou", 2));

// Hoteles ordenados de más a menos estrellas

hoteles.Sort((h1, h2) => h2.Estrellas.CompareTo(h1.Estrellas));
Console.WriteLine("Hoteles ordenados de más a menos estrellas:");
foreach(Hotel h in hoteles)
{
    Console.WriteLine(h);
}

// Hoteles de más de 3 estrellas

IEnumerable<Hotel> hoteles3 =
    from hotel in hoteles
    where hotel.Estrellas > 3
    select hotel;
Console.WriteLine("Hoteles de más de 3 estrellas");
foreach(Hotel h in hoteles3)
{
    Console.WriteLine(h);
}

// Media de estrellas de hoteles de Alicante

double mediaEstrellas =
    hoteles.Where(h => h.Localidad == "Alicante")
           .Average(h => h.Estrellas);
Console.WriteLine("Media de hoteles de Alicante: {0}", mediaEstrellas);