/* Clase hotel para gestionar los datos de cada hotel y poder llamar a la 
 * lectura del archivo Json para cargar hoteles y al guardado de los hoteles
 * en el mismo archivo.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

public class Hotel : IComparable<Hotel>
{
    private const string FICHERO = "hoteles.json";

    private string nombre;
    private string provincia;
    private float precio;
    public int estrellas;

    public Hotel(string nombre, string provincia, float precio, int estrellas)
    {
        this.nombre = nombre;
        this.provincia = provincia;
        this.precio = precio;
        if(estrellas >= 1 || estrellas <=5)
            this.estrellas = estrellas;
    }

    public string Nombre { get { return nombre; } }
    public string Provincia { get { return provincia; } }
    public float Precio { get { return precio; } }
    public int Estrellas { get { return estrellas; } }

    public static List<Hotel> LeerHoteles()
    {
        List<Hotel> listado = new List<Hotel>();
        if (File.Exists(FICHERO))
        {
            string jsonString = File.ReadAllText(FICHERO);
            listado =
                JsonSerializer.Deserialize<List<Hotel>>(jsonString);
        }
        return listado;
    }

    public static void GuardarHoteles(List<Hotel> listado)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(listado, opciones);
        File.WriteAllText(FICHERO, jsonString);
    }

    public string FormatoEstrellas()
    {
        string formato="";

        for (int i = 0; i < estrellas; i++)
            formato += '*';

        return formato;
    }

    public override string ToString()
    {
        return nombre + " ( " + provincia + ", " + precio + "eur/noche, " + 
            FormatoEstrellas() + ")";
    }

    public int CompareTo(Hotel other)
    {
        return nombre.CompareTo(other.nombre);
    }
}