/*
 * Clase referente a empleados, padre de arquitecto y obreros.
*/

using System;

class Empleado
{
    protected string dni;
    protected string nombre;
    protected string telefono;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public Empleado(string dni, string nombre, string telefono)
    {
        Nombre = nombre;
        Dni = dni;
        Telefono = telefono;
    }
}