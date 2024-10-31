using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana12
{
    internal class estudiantes
    {
        byte[] edades = new byte[0];
        int posicion = 0;
        string seguir;

        public void insertar()
        {
            byte ed;
            do
            {
                Console.Write("\nIngrese edad: ");
                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.Write("Error: Ingrese edad: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("\nEdad registrado correcatamente ");
                Console.WriteLine("\nDesea seguir registrando [si] ");
                seguir = Console.ReadLine();
            } while (seguir == "si");
        }
        public void mostrar()
        {
            Console.SetCursorPosition(10, 12);
            Console.Write("POSICION");
            Console.SetCursorPosition(30, 12);
            Console.Write("EDADES");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(i);
                Console.SetCursorPosition(30, 13 + i);
                Console.Write(edades[i]);
            }
        }
        public void eliminar(byte ed)
        {
            int indice = Array.IndexOf(edades, ed);
            
            if (indice != -1)
            {
                for (int i = indice; i < edades.Length -1; i++)
                {
                    edades [i] = edades[i+1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                posicion--;
                Console.WriteLine("\nEdad elmininado correcatamente");
            }
            else
            {
                Console.WriteLine("\nNo se puede eliminar porque no existe");
            }
        }
        public void ordenar()
        {

        }
    }
}
