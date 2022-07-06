/*Este programa crea 3 puertas,se las asigna a una casa y emplea el método
 Y utiliza el método MostrarEstado para mostrar el nombre y los datos de sus
puertas*/
class principal
{
    static void Main()
    {
        Puerta p1 = new Puerta(5, 10);
        Puerta p2 = new Puerta(2, 4);
        Puerta p3 = new Puerta(3, 6);

        Casa casa = new Casa("casa paco", p1, p2, p3);

        casa.MostrarEstado();
    }
}
