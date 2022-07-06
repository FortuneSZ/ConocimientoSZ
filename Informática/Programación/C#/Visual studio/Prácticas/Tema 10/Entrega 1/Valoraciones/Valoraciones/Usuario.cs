using System;

class Usuario
{
    private string nombre;
    private string email;
    private DateTime fechaNac;
    private Valoracion valoracion;

    public Usuario(string nombre, string email,
        DateTime fechaNac, Valoracion valoracion)
    {
        this.nombre = nombre;
        this.email = email;
        this.fechaNac = fechaNac;
        this.valoracion = valoracion;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public DateTime FechaNac
    {
        get { return fechaNac; }
        set { fechaNac = value; }
    }

    public Valoracion Valoracion
    {
        get { return valoracion; }
        set { valoracion = value; }
    }

    public string PasarFormato()
    {
        string resultado = Nombre + ";" + Email + ";"
            + FechaNac.ToString("dd/MM/yyyy") + ";" + (int)valoracion;
        return resultado;
    }

    public override string ToString()
    {
        return Nombre + ", " + Email + ", " +
            FechaNac.ToString("d") + ", " + Valoracion;
    }
}