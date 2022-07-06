/*Este programa lee equipos de un archivo de texto,los mete en una lista,
 poniendo todos sus demás atributos a 0,luego lee partidos de otro archivo
de texto,los mete en una lista y en base a ella actualiza los atriburos de
los equipos,posteriormente el usuario introducirá nuevos partidos,y si cumplen
las condiciones se darán de alta en la lista de partidos,una vez el usuario
introduzca una cadena vacía el programa mostrará la lista de equipos ordenada
y actualizará el archivo de partidos*/
class Principal
{
    static void Main()
    {
        string nombre, linea, lineaInsertar;
        bool Equipo1 = false, Equipo2 = false;
        List<Equipo> Equipos = new List<Equipo>();
        using (StreamReader ficheroE = new StreamReader("Equipos.txt"))
        {
            do
            {
                nombre = ficheroE.ReadLine();
                if (nombre != null)
                {
                    Equipos.Add(new Equipo(nombre));
                }
            }
            while (nombre != null);
        }

        List<string> Partidos = new List<string>();
        using (StreamReader ficheroP = new StreamReader("Partidos.txt"))
        {
            do
            {
                linea = ficheroP.ReadLine();
                if (linea != null)
                {
                    Partidos.Add(linea);
                    string[] partes = linea.Split(';');
                    int puntos1 = Convert.ToInt32(partes[1]);
                    int puntos2 = Convert.ToInt32(partes[3]);
                    for (int i = 0; i < Equipos.Count; i++)
                    {
                        if (partes[0] == Equipos[i].Nombre)
                        {
                            Equipo equipo1 = Equipos[i];
                            Equipos[i].PuntosFavor = Equipos[i].PuntosFavor
                                + puntos1;
                            Equipos[i].PuntosContra = Equipos[i].PuntosContra
                                + puntos2;
                            if (puntos1 > puntos2)
                            {
                                Equipos[i].PartidosGan++;
                            }
                            else
                            {
                                Equipos[i].PartidosPer++;
                            }
                        }

                        if (partes[2] == Equipos[i].Nombre)
                        {
                            Equipo equipo2 = Equipos[i];
                            Equipos[i].PuntosFavor = Equipos[i].PuntosFavor
                                + puntos2;
                            Equipos[i].PuntosContra = Equipos[i].PuntosContra
                                + puntos1;
                            if (puntos1 < puntos2)
                            {
                                Equipos[i].PartidosGan++;
                            }
                            else
                            {
                                Equipos[i].PartidosPer++;
                            }
                        }
                    }
                }
            }
            while (linea != null);
        }
        do
        {
            Console.WriteLine("Introduzca un partido");
            Console.WriteLine("equipo;resultado;equipo;resultado");
            using (StreamWriter fichero = new StreamWriter("Partidos.txt", true))
            {
                lineaInsertar = Console.ReadLine();
                if (lineaInsertar != null)
                {
                    string[] insert = lineaInsertar.Split(';');
                    if (insert.Length == 4)
                    {
                        for (int i = 0; i < Equipos.Count; i++)
                        {
                            if (insert[0] == Equipos[i].Nombre)
                            {
                                Equipo1 = true;
                            }
                        }
                        for (int i = 0; i < Equipos.Count; i++)
                        {
                            if (insert[2] == Equipos[i].Nombre)
                            {
                                Equipo2 = true;
                            }
                        }
                        if (Equipo1 == true && Equipo2 == true)
                        {
                            if (Convert.ToInt32(insert[1]) < 200 &&
                               Convert.ToInt32(insert[1]) > 0 &&
                               Convert.ToInt32(insert[3]) < 200 &&
                               Convert.ToInt32(insert[3]) > 0)
                            {
                                Partidos.Add(lineaInsertar);
                            }
                        }
                        else
                        {
                            Console.WriteLine("El partido no es correcto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El partido no es correcto");
                    }
                }
                else
                {
                    Console.WriteLine("El partido no es correcto");
                }
            }
        }
        while (lineaInsertar != "");

        while (linea != null) ;
        for (int i = 0; i < Partidos.Count; i++)
        {
            Console.WriteLine(Partidos[i]);
        }
        Console.WriteLine("");

        Console.WriteLine("Nombre equipo   ganados   perdidos   puntos_favor"
    + "   puntos_contra");
        for (int i = 0; i < Equipos.Count; i++)
        {
            Console.WriteLine(Equipos[i]);
        }
    }
}
