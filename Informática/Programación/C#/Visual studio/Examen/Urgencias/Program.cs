/*Este programa es una aplicación de gestión de urgencias de un hospital,
 con una lista de pacientes previamente rellenada,pediremos al usuario que 
añada pacientes,una vez pulse la opción 0 pasaremos a dividir a los pacientes
en una cola para los pacientes normales y una lñista para pacientes urgentes,
una vez hecho esto pediremos al usuario que rellene los diagnósticos de los 
pacientes urgentes y los mostraremos junto a dichos diagnósticos,posteriormente
haremos los mismo con los pacientes normales*/
class Examen
{
    static void PacienteUrg(List<Paciente> Pacientes, int ed, int num,
        string nom, string tel, string dol)
    {
        int tri;
        bool encontrado = false;
        Console.WriteLine("Introduzca el nivel de triaje del paciente");
        tri = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        /*for (int i = 0; i < Pacientes.Count; i++)
        {
            if (Pacientes[i].numero == num)
            {
                encontrado = true;
            }
        }*/
        if (encontrado != true)
        {
            Pacientes.Add(new PacienteCritico(num, nom, ed, tel, dol, tri));
        }
        else
        {
            Console.WriteLine("El paciente ya está en la lista");
            Console.ReadLine();
        }
    }
    static void PacienteNorm(List<Paciente> Pacientes, int ed, int num,
        string nom, string tel, string dol)
    {
        string cabemed;
        bool encontrado;
        Console.WriteLine("Introduzca el nombre de su médico de cabecera");
        cabemed = Console.ReadLine();
        Console.Clear();
        for (int i = 0; i < Pacientes.Count; i++)
        {
            if (Pacientes[i].numero == num)
            {
                encontrado = true;
            }
        }
        if (encontrado = false)
        {
            Pacientes.Add(new PacienteNormal(num, nom, ed, tel, dol, cabemed));
        }
        else
        {
            Console.WriteLine("El paciente ya está en la lista");
            Console.ReadLine();
        }
    }
    static void Paciente(List<Paciente> Pacientes, int eleccion)
    {
        int ed, num;
        string nom, tel, dol;
        Console.WriteLine("Introduzca el número del paciente");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Introduzca el nombre del paciente");
        nom = Console.ReadLine();
        Console.Clear();
        do
        {
            Console.WriteLine("Introduzca la edad del paciente");
            ed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        while (ed > 100 || ed < 0);
        Console.WriteLine("Introduzca el número de teléfono del paciente");
        tel = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Introduzca la dolencia del paciente");
        dol = Console.ReadLine();
        Console.Clear();
        if (eleccion == 1)
        {
            PacienteNorm(Pacientes, ed, num, nom, tel, dol);
        }
        if (eleccion == 2)
        {
            PacienteUrg(Pacientes, ed, num, nom, tel, dol);
        }

    }
    static void Main()
    {
        int eleccion;
        List<Paciente> Pacientes = new List<Paciente>();
        Pacientes.Add(new PacienteCritico(4999, "Fran García", 22,
            "654145598", "Depresión", 3));
        Pacientes.Add(new PacienteNormal(1904, "Rosa Rodriguez", 58,
            "658741236", "Cansancio extremo", "Nuria"));

        /*for (int i = 0; i < Pacientes.Count; i++)
        {
            Console.WriteLine(Pacientes[i]);
            Console.WriteLine();
        }*/
        do
        {
            Console.WriteLine("Elija el tipo de paciente que quiere" +
                "añadir a la lista");
            Console.WriteLine("1. Paciente normal");
            Console.WriteLine("2. Paciente Crítico");
            Console.WriteLine("0. Salir");
            eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    Paciente(Pacientes, eleccion);
                    break;
                case 2:
                    Console.Clear();
                    Paciente(Pacientes, eleccion);
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        }
        while (eleccion != 0);
        Console.Clear();
        Queue<PacienteNormal> Normalpac = new Queue<PacienteNormal>();
        for (int i = 0; i < Pacientes.Count; i++)
        {
            if (Pacientes[i] is PacienteNormal)
            {
                Normalpac.Enqueue((PacienteNormal)Pacientes[i]);
                Pacientes.RemoveAt(i);
            }
        }
        List<PacienteCritico> Urgpac = new List<PacienteCritico>();
        for (int i = 0; i < Pacientes.Count; i++)
        {
            Urgpac.Add((PacienteCritico)Pacientes[i]);
        }
        Urgpac.Sort();

        for (int i = 0; i < Urgpac.Count; i++)
        {
            Console.WriteLine("Introduzca su diagnóstico");
            Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del doctor que lo atendió");
            string doc = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca la fecha en la que lo atendieron");
            string fech = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Introduzca el tratamiento suminstrado");
            string trat = Console.ReadLine();
            Console.Clear();
            Diagnostico dig = new Diagnostico(doc, fech, trat);
        }

    }
}
