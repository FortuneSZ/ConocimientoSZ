/*Este programa crea dos objetos de clase persona,les da nombre empleando un
 getter y luego emplea el método saludar para saludar a cada persona por su
nombre*/
class PruebaPersona
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.SetNombre("Paco");
        persona.saludar();
        Persona persona2 = new Persona();
        persona2.SetNombre("Andrea");
        persona2.saludar();
    }
}