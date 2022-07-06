/*
 * Programa que lee una lista de personas
 * de un fichero de texto
 */
List<Persona> personas = new List<Persona>();
string linea;

using(StreamReader fichero = 
    new StreamReader("personas.dat"))
{
    while((linea = fichero.ReadLine()) != null)
    {
        string[] partes = linea.Split(';');
        if (partes.Length == 2)
        {
            Persona p = new Persona(partes[0],
                Convert.ToInt32(partes[1]));
            personas.Add(p);
        }
    }
}

foreach(Persona p in personas)
{
    Console.WriteLine(p);
}