/*Este programa crea dos objetos de clase persona,les da nombre empleando un
 constructor y luego emplea el método saludar para saludar a cada persona por
su nombre*/
class PruebaPersona
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.saludar();
        Persona persona2 = new Persona("Andrea");
        persona2.saludar();
    }
}