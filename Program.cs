using System;

namespace AciertaElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroR = numero.Next(1, 100);
            int contador = 0;
            bool empezamos = true;

            do
            {
                Console.WriteLine("Di un numero del 1 al 100, a ver si aciertas");
                string ReadLine = Console.ReadLine();
                int valor = int.Parse(ReadLine);
                
                if( contador < 5)
                {
                    if (valor > numeroR)
                    {
                        Console.WriteLine("Tu numero es mayor");
                        contador += 1;
                        empezamos = true;
                    }
                    else if (valor < numeroR)
                    {
                        Console.WriteLine("Tu numero es menor");
                        contador += 1;
                        empezamos = true;
                    }
                    else
                    {
                        Console.WriteLine("Este es el numero");
                        Console.WriteLine("Has Acertado");
                        empezamos = false;
                    }                
                }
                else
                {
                    Console.WriteLine("Se Acabo el Juego");
                }

            } while (empezamos == true);
        }
    }
}
