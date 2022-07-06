class Trabajador
{
    string numSeg, telefono, nombre;

    public Trabajador(string numseg, string nombre, string telef)
    {
        this.numSeg = numseg;
        this.nombre = nombre;
        this.telefono = telef;

    }

    public override string ToString()
    {
        return "Nombre: " + nombre + " , Teléfono: " + telefono;
    }

}

