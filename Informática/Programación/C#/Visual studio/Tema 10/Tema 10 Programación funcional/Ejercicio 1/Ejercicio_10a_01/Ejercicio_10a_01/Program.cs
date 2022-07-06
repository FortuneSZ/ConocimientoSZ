/*
 * Listado de libros ordenado por precio descendente
 * usando lambdas
 */

List<Libro> libros = new List<Libro> ();
libros.Add(new Libro("El juego de Ender", "Orson Scott Card", 7.95f));
libros.Add(new Libro("La tabla de Flandes", "A. P. Reverte", 8.45f));
//libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 4.95f));
//libros.Add(new Libro("La historia interminable", "Michael Ende", 11.15f));

libros.Sort((l1, l2) => l2.Precio.CompareTo(l1.Precio));

Console.WriteLine("Top 3 libros más caros:");
for(int i = 0; i < Math.Min(3, libros.Count); i++)
{
    Console.WriteLine(libros[i]);
}