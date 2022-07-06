/*
 Acepta el reto - Reto 366: Los niños buenos
 https://www.aceptaelreto.com/problem/statement.php?id=366
 */

class Nino : IComparable<Nino>
{
    private int nivelBondad;
    private int pesoRegalos;

    public Nino()
    {
    }

    public Nino(int nivelBondad, int pesoRegalos)
    {
        this.nivelBondad = nivelBondad;
        this.pesoRegalos = pesoRegalos;
    }

    public int GetNivelBondad()
    {
        return nivelBondad;
    }

    public void SetNivelBondad(int nivelBondad)
    {
        this.nivelBondad = nivelBondad;
    }

    public int GetPesoRegalos()
    {
        return pesoRegalos;
    }

    public void SetPesoRegalos(int pesoRegalos)
    {
        this.pesoRegalos = pesoRegalos;
    }

    public int CompareTo(Nino n)
    {
        if (n.nivelBondad != nivelBondad)
        {
            return n.nivelBondad.CompareTo(nivelBondad);
        }
        else
        {
            return pesoRegalos.CompareTo(n.pesoRegalos);
        }
    }
}

class Reto366_Los_ninos_buenos
{
    static void Main()
    {
        int totalNinos;

        do
        {
            totalNinos = Convert.ToInt32(Console.ReadLine());

            if (totalNinos > 0)
            {
                Nino[] ninos = new Nino[totalNinos];

                for (int i = 0; i < totalNinos; i++)
                {
                    ninos[i] = new Nino();
                    string[] datos = Console.ReadLine().Split();
                    ninos[i].SetNivelBondad(Convert.ToInt32(datos[0]));
                    ninos[i].SetPesoRegalos(Convert.ToInt32(datos[1]));
                }

                Array.Sort(ninos);

                for (int i = 0; i < totalNinos; i++)
                {
                    Console.WriteLine(ninos[i].GetNivelBondad() + " " +
                        ninos[i].GetPesoRegalos());
                }

                Console.WriteLine();
            }
        } while (totalNinos > 0);
    }
}


