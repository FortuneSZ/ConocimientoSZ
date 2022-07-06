/*Este programa consiste en crear un array de trabajadores,y demostrar el
 polimorfismo empleando virtual en el método saludar del padre y override
en las que heredan de el*/
class Ejercicio
{
    static void Main()
    {
        Trabajador[] Array = new Trabajador[5];
        Trabajador T = new Trabajador();
        Array[0] = T;
        Programador P = new Programador();
        Array[1] = P;
        Analista A = new Analista();
        Array[2] = A;
        Ingeniero I = new Ingeniero();
        Array[3] = I;
        IngenieroInformatico IE = new IngenieroInformatico();
        Array[4] = IE;

        for (int i = 0; i < Array.Length; i++)
        {
            Array[i].Saludar();
        }
    }
}
