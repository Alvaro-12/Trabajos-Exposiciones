using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo: (Hombre = H.   Mujer = M)");
            char sexo = char.Parse(Console.ReadLine());


            if (sexo == char.Parse("H"))
            {
                Console.WriteLine();
                Console.WriteLine("El Sr. {0} se ha registrado", nombre);
            }
            if (sexo == char.Parse("M"))
            {
                Console.WriteLine();
                Console.WriteLine("La Sra. {0} se ha registrado.", nombre);

            }
        
        }
    }
}
