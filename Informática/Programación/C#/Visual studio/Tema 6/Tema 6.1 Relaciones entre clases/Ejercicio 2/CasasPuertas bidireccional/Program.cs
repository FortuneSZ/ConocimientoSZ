/*Este programa crea 3 puertas,se las asigna a una casa y emplea el método
 Y utiliza el método MostrarEstado para mostrar el nombre y los datos de sus
puertas,al ser birideccional también se puede saber la casa a la que pertenece
la casa desde la propia puerta*/
class principal
{
    static void Main()
    {
        Puerta p1 = new Puerta(5, 10);
        Puerta p2 = new Puerta(2, 4);
        Puerta p3 = new Puerta(3, 6);

        Casa casa = new Casa("casa paco", p1, p2, p3);

        casa.MostrarEstado();

        p1.Casa = casa.Nombre;
        p2.Casa = casa.Nombre;
        p3.Casa = casa.Nombre;

        Console.WriteLine();
        Console.WriteLine("Casa de la puerta 1: " + p1.Casa);
        Console.WriteLine("Casa de la puerta 2: " + p2.Casa);
        Console.WriteLine("Casa de la puerta 3: " + p3.Casa);
    }
}
