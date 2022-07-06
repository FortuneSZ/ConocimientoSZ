/*Programa que detecta cumpleaños repetidos en un conjunto*/
HashSet<FechaNacimiento> fechas =
    new HashSet<FechaNacimiento>();
string linea;
string[] partes;

Console.WriteLine("Escribe las fechas:");
linea = Console.ReadLine();
partes = linea.Split();
foreach (string parte in partes)
{
    string[] numeros = parte.Split("/");
    fechas.Add(new FechaNacimiento(
        Convert.ToInt32(numeros[0]),
        Convert.ToInt32(numeros[1]),
        Convert.ToInt32(numeros[2])));
}

if (fechas.Count == partes.Length)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("SI");
}