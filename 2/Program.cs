using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un programa que lea numeros de la entrada estandard e imprima la sumatoria 	
            //El "fin" es la lectura de una linea en blanco / nula 

            int numero = 0;
            int acum = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum += numero;
                }
                
            } while (success != false);

            Console.WriteLine(acum);
        }
    }
}
