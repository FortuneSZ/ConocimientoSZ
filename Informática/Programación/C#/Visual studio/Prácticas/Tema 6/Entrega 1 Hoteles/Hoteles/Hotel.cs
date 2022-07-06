/*Clase hotel*/
class Hotel
{
    private string nombre;
    private string localidad;
    private float precio;
    private int estrellas;

    // Constructor por defecto
    public Hotel()
    {
        nombre = "";
        localidad = "";
        precio = 0;
        estrellas = 1;
    }
    // Constructor parametrizado
    public Hotel(string nombre, string localidad, int precio, int estrellas)
    {
        this.nombre = nombre;
        this.localidad = localidad;
        if (precio >= 0)
        {
            this.precio = precio;
        }
        if (estrellas >= 1 && estrellas >= 5)
        {
            this.estrellas = estrellas;
        }
    }
    // Getters y setters
    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }
    public string Localidad
    {
        get
        {
            return localidad;
        }
        set
        {
            localidad = value;
        }
    }
    public float Precio
    {
        get
        {
            return precio;
        }
        set
        {
            if (precio >= 0)
            {
                precio = value;
            }

        }
    }
    public int Estrellas
    {
        get
        {
            return estrellas;
        }
        set
        {
            if (estrellas >= 1 && estrellas <= 5)
            {
                estrellas = value;
            }

        }
    }
    public void Mostrar()
    {
        Console.Write("Nombre del hotel, Localidad (precio, estrellas)");
        Console.WriteLine("Hotel " + nombre + ", " + localidad + " (" + precio + " eur/noche, " + new String('*', estrellas) + ")");
    }
}


