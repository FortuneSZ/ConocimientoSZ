/*
 * Programa que valida un e-mail escrito por el usuario
 */
using System.Text.RegularExpressions;

Regex email = new Regex(@"^\w+(\.\w+)*@\w+(\.\w+)+$");
Console.WriteLine("Escribe un e-mail:");
string emailUsuario = Console.ReadLine();

if (email.IsMatch(emailUsuario))
{
    Console.WriteLine("E-mail válido");
}
else
{
    Console.WriteLine("E-mail inválido");
}