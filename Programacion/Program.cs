using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa
{
    class persona
    {

        public string nombre;
        public string correo;
        public int edad;

        public static void Main(string[] args)
        {
            persona p = new persona();

            Console.WriteLine("Cual es tu nombre");
            p.nombre = Console.ReadLine();

            Console.WriteLine("Cual es tu correo!");
            p.correo = Console.ReadLine();
            Console.WriteLine("Cual es tu edad!");
            p.edad = int.Parse(Console.ReadLine());


            Console.WriteLine("Mi nombre es:\n " + p.nombre + "\nMi correo es:\nd " + p.correo + "\nTengo " + p.edad + " años");

            Console.Read();




        }
    }
}