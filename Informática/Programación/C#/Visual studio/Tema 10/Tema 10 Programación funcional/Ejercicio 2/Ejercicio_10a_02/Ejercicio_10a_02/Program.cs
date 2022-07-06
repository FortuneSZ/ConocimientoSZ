/*
 * Programa que manipula una lista de recetas
 */
List<Receta> recetas = new List<Receta> ();
recetas.Add(new Receta("Ratatouille", "Verduras", 230));
recetas.Add(new Receta("Estofado de ternera", "Carnes", 850));
recetas.Add(new Receta("Pollo con almendras", "Carnes", 630));
recetas.Add(new Receta("Ensalada", "Verduras", 210));
recetas.Add(new Receta("Macarrones con atún", "Pasta", 420));

// Recetas de menos de 500 cal con LINQ

IEnumerable<Receta> recetas500 =
    from receta in recetas
    where receta.Calorias < 500
    select receta;
Console.WriteLine("Recetas de menos de 500 calorías con LINQ:");
foreach(Receta r in recetas500)
{
    Console.WriteLine(r);
}

// Recetas de menos de 500 cal con IEnumerable

List<Receta> recetas500_2 =
    recetas.Where(r => r.Calorias < 500)
           .ToList(); 

Console.WriteLine("Recetas de menos de 500 calorías con IEnumerable:");
foreach (Receta r in recetas500_2)
{
    Console.WriteLine(r);
}

// Nombres de recetas de "carnes" alfabéticamente: LINQ

IEnumerable<string> nombresRecetasCarne =
    from receta in recetas
    where receta.Categoria == "Carnes"
    orderby receta.Nombre
    select receta.Nombre;

Console.WriteLine("Recetas de carne con LINQ:");
foreach(string n in nombresRecetasCarne)
{
    Console.WriteLine(n);
}

// Nombres de recetas de "carnes" alfabéticamente: IEnumerable

List<string> nombresRecetasCarne_2 =
    recetas.Where(r => r.Categoria == "Carnes")
           .OrderBy(r => r.Nombre)
           .Select(r => r.Nombre)
           .ToList();

Console.WriteLine("Recetas de carne con IEnumerable:");
foreach (string n in nombresRecetasCarne_2)
{
    Console.WriteLine(n);
}

// Media de calorías de las recetas de verduras

double mediaCalorias =
    recetas.Where(r => r.Categoria == "Verduras")
           .Average(r => r.Calorias);
Console.WriteLine("Media calorias de verduras: {0}", mediaCalorias);

// Número de recetas con más de 800 calorías

int recetas800 =
    recetas.Where(r => r.Calorias > 800).Count();
Console.WriteLine("Hay {0} recetas de más de 800 cal.", recetas800);