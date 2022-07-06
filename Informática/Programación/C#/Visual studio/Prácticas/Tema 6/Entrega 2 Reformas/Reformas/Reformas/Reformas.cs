/*
 * Clase referente a reformas.
*/

using System;

class Reforma
{
    private int codigo;
    private string fecha;
    private int duracion;
    private float precio;
    private Arquitecto arquitecto;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    public int Duracion
    {
        get { return duracion; }
        set { duracion = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Reforma(int codigo, string fecha, int duracion, float precio, 
        Arquitecto arquitecto)
    {
        this.arquitecto = arquitecto;
        Codigo = codigo;
        Fecha = fecha;
        Duracion = duracion;
        Precio = precio;
    }

    public string ToString()
    {
        return codigo + ", " + fecha + ", " + duracion + ", " + precio + ", "+ 
            arquitecto.ToString();
    }
}