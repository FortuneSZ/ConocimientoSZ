/*
 * Clase referente a obreros, hedera de Empleados.
*/

using System;


class Obrero : Empleado
{
    private int edad;
    private string especialidad;

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }

    public Obrero(string dni, string nombre, string telefono, int edad, 
        string especialidad) : base(dni, nombre, telefono)
    {
        Edad = edad;
        Especialidad = especialidad;
    }
}
