/*Este programa crea un objetos de clase persona y otro de clase PersonaInglesa
les da nombre empleando un constructor y luego emplea el método saludar para
saludar a cada persona por su nombre,y en caso de la inglesa decir que toma te*/
class PruebaPersona
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.saludar();
        PersonaInglesa persona2 = new PersonaInglesa("Andrea");
        persona2.saludar();
        persona2.TomarTe();
    }
}