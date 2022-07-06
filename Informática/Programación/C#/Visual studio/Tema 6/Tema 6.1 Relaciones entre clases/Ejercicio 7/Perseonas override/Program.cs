/*Este programa crea 3 objetos,uno de clase persona,personaItaliana y
 personaInglesa,estas dos últimas heredando de la primera,posteriormente hará 
que saluden,cada cual de una forma diferente debido a que sobreescriben el
método saludar las clase hijas*/
class Principal
{
    static void Main()
    {
        Persona persona = new Persona("Paco");
        PersonaInglesa personaInglesa = new PersonaInglesa("James");
        PersonaItaliana person = new PersonaItaliana("Prociutto");

        persona.Saludar();
        personaInglesa.Saludar();
        person.Saludar();
    }
}
