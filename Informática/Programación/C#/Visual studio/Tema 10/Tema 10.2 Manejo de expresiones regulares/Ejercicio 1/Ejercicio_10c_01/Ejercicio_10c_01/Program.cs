/*
 * Programa que comprueba si una matrícula de coche
 * es válida
 */
using System.Text.RegularExpressions;

Regex matricula1 = new Regex(@"^[0-9]{4}[A-Z]{3}$");
Regex matricula2 = new Regex(@"^[A-Z]{1,2} [0-9]{4} [A-Z]{2}$");

Console.WriteLine("Escribe una matrícula:");
string matriculaUsuario = Console.ReadLine();

if (matricula1.IsMatch(matriculaUsuario) ||
    matricula2.IsMatch(matriculaUsuario))
{
    Console.WriteLine("Matrícula válida");
}
else
{
    Console.WriteLine("Matrícula inválida");
}