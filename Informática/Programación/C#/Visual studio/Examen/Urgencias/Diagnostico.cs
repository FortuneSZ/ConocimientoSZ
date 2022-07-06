/*Clase diagnóstico*/
class Diagnostico
{
    private string Doctor;
    private string Fecha;
    private string Tratamiento;

    public string doctor
    {
        get { return Doctor; }
        set { Doctor = value; }
    }
    public string fecha
    {
        get { return Fecha; }
        set { Fecha = value; }
    }
    public string tratamiento
    {
        get { return Tratamiento; }
        set { Tratamiento = value; }
    }

    public Diagnostico(string Doctor, string Fecha, string Tratamiento)
    {
        this.Doctor = Doctor;
        this.Fecha = Fecha;
        this.Tratamiento = Tratamiento;
    }
}
