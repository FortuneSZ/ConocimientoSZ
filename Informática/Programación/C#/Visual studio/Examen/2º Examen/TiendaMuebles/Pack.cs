//Clase pack
class Pack
{

    private Muebles[] mueble;
    private string codigopack;
    private string nombrepack;

    private string Codigopack
    {
        get { return codigopack; }
        set { codigopack = value; }
    }

    public string Nombrepack
    {
        set { nombrepack = value; }
        get { return nombrepack; }
    }

    public Muebles[] Muebles
    {
        get { return mueble; }
        set { mueble = value; }
    }

    public Pack(Muebles[] mueble, string codigopack, string nombrepack)
    {
        this.mueble = mueble;
        this.codigopack = codigopack;
        this.nombrepack = nombrepack;
    }
}
