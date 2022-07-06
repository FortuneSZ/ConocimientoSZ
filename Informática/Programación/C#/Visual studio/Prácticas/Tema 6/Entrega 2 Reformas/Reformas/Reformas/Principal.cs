/*
 * Clase principal del programa.
*/
using System;


enum menu { NUEVAREFORMA=1, REFORMABARATA, LISTADO, 
    REFORMASARQUITECTO, SALIR=0};
class Principal
{
    static void Main()
    {
        Empleado[] empleados = new Empleado[5];
        Reforma[] reformas = new Reforma[10];
        int op, cant=0;

        empleados[0] = new Arquitecto("111E", "Juanjo", "965 67", 12345);
        empleados[1] = new Arquitecto("111B", "Manuel", "962165 67", 55668);
        empleados[2] = new Arquitecto("111C", "e1", "962165 67", 12388);
        empleados[3] = new Arquitecto("111A", "e2", "962165 67", 98722);
        empleados[4] = new Arquitecto("111V", "e3", "962165 67", 66685);

        do
        {
            Console.WriteLine((int)menu.NUEVAREFORMA+". Nueva reforma.");
            Console.WriteLine((int)menu.REFORMABARATA+". Reforma más barata.");
            Console.WriteLine((int)menu.LISTADO+". Listado de reformas");
            Console.WriteLine((int)menu.REFORMASARQUITECTO+". " +
                "Reformas de un arquitecto");
            Console.WriteLine((int)menu.SALIR+". Salir");
            Console.WriteLine("Elige una opción");
            op= Convert.ToInt32(Console.ReadLine());

            switch((menu)op)
            {
                case menu.NUEVAREFORMA:
                    NuevaReforma(ref reformas, ref cant, empleados);
                    break;
                case menu.REFORMABARATA:
                    ReformaBarata(reformas, cant);
                    break;
                case menu.LISTADO:
                    ListarReformas(reformas, cant);
                    break;
                case menu.REFORMASARQUITECTO:
                    ReformasArquitecto(empleados);
                    break;
                case menu.SALIR:
                    Console.WriteLine("Has salido de la aplicación");
                    break;
            }

        } while(op != (int)menu.SALIR);
    }

    static void NuevaReforma(ref Reforma[] reformas, ref int cant, 
        Empleado[] empleados)
    {
        bool dnicorrecto = true, preciocorrecto= true, codigocorrecto= true,
            duracioncorrecto = true;
        string fecha, dni;
        int duracion, codigo;
        float precio;
        Arquitecto auxiliar;
        

        Console.WriteLine("Dime el codigo de la reforma: ");
        codigo = Convert.ToInt32(Console.ReadLine());
        if(!ComprobarCodigo(codigo, reformas, cant))
        {
            codigocorrecto = false;
        }


        Console.WriteLine("Dime la fecha de la reforma: ");
        fecha = Console.ReadLine();

        Console.WriteLine("Dime la duración de la reforma: ");
        duracion = Convert.ToInt32(Console.ReadLine());
        if(duracion < 0)
        {
            duracioncorrecto = false;
        }


        Console.WriteLine("Dime el precio de la reforma: ");
        precio = Convert.ToSingle(Console.ReadLine());
        if(precio < 0)
        {
            preciocorrecto = false;
        }

        Console.WriteLine("Dime el DNI del arquitecto: ");
        dni = Console.ReadLine();
        if(ComprobarDNI(dni, empleados) == -1)
        {
            dnicorrecto = false;
        }

        if(preciocorrecto && codigocorrecto && duracioncorrecto && dnicorrecto)
        {
            reformas[cant] = new Reforma(codigo, fecha, duracion, precio, 
                (Arquitecto)empleados[ComprobarDNI(dni, empleados)]);

            ((Arquitecto)empleados[ComprobarDNI(dni, empleados)]).
                AñadirReforma(reformas[cant]);
            cant++;

            
        }
        else
        {
            Console.WriteLine("Datos incorrectos para la reforma");

            if(!dnicorrecto)
            {
                Console.WriteLine("No se ha encontrado un arquitecto " +
                    "con el DNI indicado");
            }

            if(!preciocorrecto)
            {
                Console.WriteLine("Precio incorrecto");
            }

            if(!codigocorrecto)
            {
                Console.WriteLine("El codigo ya existe");
            }

            if(!duracioncorrecto)
            {
                Console.WriteLine("Duración incorrecta");
            }
        }
    }

    static int ComprobarDNI(string dni, Empleado[] empleados)
    {
        int n = -1;

        for(int i = 0; i < empleados.Length; i++)
        {
            if(dni == empleados[i].Dni && empleados[i] is Arquitecto)
            {
                n = i;
            }
        }

        return n;

    }

    static bool ComprobarCodigo(int codigo, Reforma[] reformas, int cant)
    {
        for(int i = 0; i < cant;i++)
        {
            if(codigo == reformas[i].Codigo)
            {
                return false;
            }
        }

        return true;
    }

    static void ReformaBarata(Reforma[] reformas, int cant)
    {
        Reforma min = reformas[0];
        for (int i = 1; i < cant; i++)
        {
            if((reformas[i].Precio / reformas[i].Duracion) < 
                (min.Precio / min.Duracion))
            {
                min = reformas[i];
            }
        }

        Console.WriteLine("Reforma mas barata: "+min.ToString());
    }

    static void ListarReformas(Reforma[] reformas, int cant)
    {
        for(int i = 0; i < cant; i++)
        {
            Console.WriteLine(reformas[i].ToString());
        }
    }

    static void ReformasArquitecto(Empleado[] empleados)
    {
        string dni;
        Console.WriteLine("Dime el DNI del arquitecto: ");
        dni= Console.ReadLine();

        if (ComprobarDNI(dni, empleados) >= 0)
        {
            ((Arquitecto)empleados[ComprobarDNI(dni, empleados)]).MostrarReformas();
        }

    }

}