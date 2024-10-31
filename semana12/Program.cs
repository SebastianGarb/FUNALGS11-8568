using semana12;
using System.Runtime.Serialization.Formatters;

byte opcion;
string regresar;
estudiantes e = new estudiantes();

do
{
    Console.WriteLine("BIENVENIDO AL SISTEMA DE REGISTRO DE EDADES\n ");
    Console.WriteLine("******* MENÚ *******");
    Console.WriteLine("* 1. Insertar      *");
    Console.WriteLine("* 2. Mostrar       *");
    Console.WriteLine("* 3. Eliminar      *");
    Console.WriteLine("* 4. Ordenar       *");
    Console.WriteLine("* 0. Salir         *");
    Console.WriteLine("********************");
    Console.Write("\nIngrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.Write("Error: Ingrese opcion: ");
    }

    switch (opcion)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            e.insertar();
            break;
        case 2:
            e.mostrar();
            break;
        case 3:
            e.mostrar();
            Console.WriteLine("\nIngrese edad a eliminar: ");
            byte ed = byte.Parse(Console.ReadLine());
            e.eliminar(ed);
            break;
        case 4:

            break;
    }
    Console.WriteLine("\n\nDesea regresar al menu? (si)");
    regresar = Console.ReadLine();
    Console.Clear();    
} while (regresar == "si");