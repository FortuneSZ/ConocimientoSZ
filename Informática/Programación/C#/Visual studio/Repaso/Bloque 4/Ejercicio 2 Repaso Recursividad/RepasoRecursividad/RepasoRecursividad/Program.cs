Console.WriteLine(Funciones.MCD(12, 8));
Console.WriteLine(Funciones.MCD(12, 24));

int[] datos = { 7, 4, 2, 9, 8 };
Console.WriteLine(Funciones.BuscarArray(datos, 9, 0));                         
Console.WriteLine(Funciones.BuscarArray(datos, 3, 0));

Console.WriteLine(Funciones.Secuencia(5));
Console.WriteLine(Funciones.Secuencia(3, 7));

float media = 0;
for (int i = 0; i < 10; i++)
{
    media += Funciones.CalcularTiempoRaton();
}
media /= 10;
Console.WriteLine("Media de tiempos del ratón: {0} minutos",
    media.ToString("N2"));

Console.WriteLine(
    Funciones.ObtenerPosiciones(
        "Esto es un texto con una frase un poco rara", 
        "un", 0));

Console.WriteLine("8 y 2 {0}", Funciones.EsPotencia(8, 2));
Console.WriteLine("15 y 3 {0}", Funciones.EsPotencia(15, 3));
Console.WriteLine("256 y 8 {0}", Funciones.EsPotencia(256, 8));
Console.WriteLine("512 y 8 {0}", Funciones.EsPotencia(512, 8));

Console.WriteLine("Par 38: {0}", Funciones.Par(38));
Console.WriteLine("Par 45: {0}", Funciones.Par(45));
Console.WriteLine("Impar 45: {0}", Funciones.Impar(45));
Console.WriteLine("Impar 22: {0}", Funciones.Impar(22));