/*
 * Clase referente a arquitecto, hedera de Empleados.
*/

using System;

class Arquitecto : Empleado
{
    private int ncolegiado;
    private Reforma[] reformas;
    private int cantidadReformas=0;


    public int Ncolegiado
    {
        get { return ncolegiado; }
        set { ncolegiado = value;}
    }

    public int CantidadReformas
    {
        get { return cantidadReformas;}
    }

    public Arquitecto(string dni, string nombre, string telefono, 
        int ncolegiado) : base (dni, nombre, telefono)
    {
        Ncolegiado = ncolegiado;
        reformas = new Reforma[10];
    }

    public void AñadirReforma(Reforma reforma)
    {
        reformas[cantidadReformas] = reforma;
        cantidadReformas++;
    }

    public void MostrarReformas()
    {
        for (int i = 0; i < cantidadReformas; i++)
        {
            Console.WriteLine(reformas[i].ToString());
        }
    }

    public string ToString()
    {
        return Nombre + " " + Ncolegiado;
    }
}