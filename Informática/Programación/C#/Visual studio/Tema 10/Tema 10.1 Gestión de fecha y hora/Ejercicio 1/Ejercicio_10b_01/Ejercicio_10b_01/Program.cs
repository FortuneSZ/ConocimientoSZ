/*
 * Ejercicio para practicar con fechas y
 * operaciones con fechas
 */
Console.WriteLine("Escribe tu fecha de nacimiento");
try
{
    DateTime fechaNacimiento =
        DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    Console.WriteLine("Has escrito: {0}", fechaNacimiento.ToString("d"));

    // Años del usuario
    DateTime ahora = DateTime.Today;
    int anyos = ahora.Year - fechaNacimiento.Year;
    if (fechaNacimiento.Month > ahora.Month ||
        fechaNacimiento.Month == ahora.Month &&
        fechaNacimiento.Day > ahora.Day)
    {
        anyos--;
    }
    Console.WriteLine("Tienes {0} años", anyos);

    // Fecha del próximo cumpleaños
    DateTime proximoCumple = new DateTime(ahora.Year,
        fechaNacimiento.Month, fechaNacimiento.Day);
    if (fechaNacimiento.Month < ahora.Month ||
        fechaNacimiento.Month == ahora.Month &&
        fechaNacimiento.Day <= ahora.Day)
    {
        proximoCumple = proximoCumple.AddYears(1);
    }
    Console.WriteLine("Tu próximo cumple es el {0}",
        proximoCumple.ToString("d"));

    // Cuántos días faltan para el próximo cumpleaños

    TimeSpan diferencia = proximoCumple.Subtract(ahora);
    Console.WriteLine("Faltan {0} días", diferencia.Days);
}
catch (Exception ex)
{
    Console.WriteLine("Fecha incorrecta");
}
