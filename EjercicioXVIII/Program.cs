using System;

namespace EjercicioXVIII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isString;


            do
            {

                Console.WriteLine("Ingrese un número (de ser decimal de 5 cifras, mejor): ");

                string n = Console.ReadLine();

                isString = Decimal.TryParse(n, out decimal m);

                if (isString == false)
                {
                    Console.WriteLine("No se ingresó un número válido");

                }else
                {
                    m = decimal.Round(m, 2);
                    Console.WriteLine("Su número redondeado a 2 decimales es: " + m);
                }

            } while (isString == false);

            Console.ReadKey();
            Console.Clear();


        }
    }
}
